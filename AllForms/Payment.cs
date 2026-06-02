using SmartFarmManagementSystem.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class Payment : Form
    {

        int selectedpaymentid = -1;
        public Payment()
        {
            InitializeComponent();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payments cannot be deleted for audit purposes.");
        }

        private void LoadMethodItems()
        {
            cmbmethods.Items.Clear();
            cmbmethods.Items.Add("Cash");
            cmbmethods.Items.Add("Bank Transfer");
            cmbmethods.Items.Add("Cheque");
            cmbmethods.Items.Add("Pending");
        }

        private void LoadSaleDropdown()
        {
            string query = @"SELECT s.SaleID,
                        CONCAT('Sale #',s.SaleID,' - ',b.Name) AS SaleName
                        FROM sale s
                        JOIN buyer b ON s.BuyerID = b.BuyerID";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbsales.DisplayMember = "SaleName";
                    cmbsales.ValueMember = "SaleID";
                    cmbsales.DataSource = dt;
                    cmbsales.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadPayments()
        {
            PaymentBL bl = new PaymentBL(0, 0, "", DateTime.Now);
            DataTable dt = bl.loadPayments();
            if (dt != null)
            {
                dgvpayments.DataSource = dt;
                dgvpayments.Columns["PaymentID"].Visible = false;
                dgvpayments.Columns["SaleID"].Visible = false;
            }
        }



        private void dgvpayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvpayments.Rows[e.RowIndex];
                selectedpaymentid = Convert.ToInt32(row.Cells["PaymentID"].Value);
                DataBaseHelper.SetComboValue(cmbsales, "SaleID",
                    Convert.ToInt32(row.Cells["SaleID"].Value));

                txtamount.Clear();
                txtamount.Focus();

                txtamount.Text = row.Cells["Amount"].Value.ToString();
                cmbmethods.Text = row.Cells["Method"].Value.ToString();
                dtppaymentdate.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);

                if (e.RowIndex >= 0)
                {

                    // compare paid amount vs total amount
                    decimal paidAmount = Convert.ToDecimal(row.Cells["Amount"].Value);
                    decimal totalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value);

                    if (row.Cells["Method"].Value.ToString() == "Pending")
                    {
                        lblpaymentstatus.ForeColor = Color.Red;
                        lblpaymentstatus.Text = "Status: UNPAID";
                    }
                    else if (paidAmount < totalAmount)
                    {
                        lblpaymentstatus.ForeColor = Color.Orange;
                        lblpaymentstatus.Text = "Status: PARTIALLY PAID" +
                            " (Remaining: Rs. " + (totalAmount - paidAmount).ToString("N2") + ")";
                    }
                    else
                    {
                        lblpaymentstatus.ForeColor = Color.Green;
                        lblpaymentstatus.Text = "Status: FULLY PAID";
                    }
                }
                   
            }
        }

        private void ClearFields()
        {
            selectedpaymentid = -1;
            cmbsales.SelectedIndex = -1;
            txtamount.Clear();
            cmbmethods.SelectedIndex = -1;
            dtppaymentdate.Value = DateTime.Now;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            LoadMethodItems();
            LoadSaleDropdown();
            LoadPayments();
        }

        private void btnsave_Click_1(object sender, EventArgs e)
        {

            if (selectedpaymentid == -1)
            {
                MessageBox.Show("Please select a payment to update.");
                return;
            }

            if (string.IsNullOrEmpty(txtamount.Text) ||
                string.IsNullOrEmpty(cmbmethods.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }


            decimal newPayment = Convert.ToDecimal(txtamount.Text);
            decimal totalAmount = Convert.ToDecimal(dgvpayments.CurrentRow.Cells["TotalAmount"].Value);
            decimal alreadyPaid = Convert.ToDecimal(dgvpayments.CurrentRow.Cells["Amount"].Value);
            decimal remaining = totalAmount - alreadyPaid;


            if (newPayment <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            if (newPayment > remaining)
            {
                MessageBox.Show("You are trying to pay Rs. " + newPayment.ToString("N2") +
                                " but remaining amount is only Rs. " + remaining.ToString("N2"));
                return;
            }

            if (newPayment < remaining)
            {
                DialogResult result = MessageBox.Show(
                    "Paying Rs. " + newPayment.ToString("N2") +
                    " out of remaining Rs. " + remaining.ToString("N2") +
                    ". Still partial. Continue?",
                    "Partial Payment",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;
            }

            PaymentBL bl = new PaymentBL(
                Convert.ToInt32(cmbsales.SelectedValue),
                newPayment,
                cmbmethods.Text,
                dtppaymentdate.Value);

            if (bl.updatePayment(selectedpaymentid))
            {
                MessageBox.Show("Payment updated! Total paid: Rs. " + (alreadyPaid + newPayment).ToString("N2"));
                ClearFields();
                LoadPayments();
            }
        }
        }
}
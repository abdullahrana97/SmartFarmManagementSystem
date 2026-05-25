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
            if (dt != null) dgvpayments.DataSource = dt;
        }



        private void dgvpayments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvpayments.Rows[e.RowIndex];
                selectedpaymentid = Convert.ToInt32(row.Cells["PaymentID"].Value);
                DataBaseHelper.SetComboValue(cmbsales, "SaleID",
                    Convert.ToInt32(row.Cells["SaleID"].Value));
                txtamount.Text = row.Cells["Amount"].Value.ToString();
                cmbmethods.Text = row.Cells["Method"].Value.ToString();
                if (e.RowIndex >= 0)
                {
 
                    string method = row.Cells["Method"].Value.ToString();

                    if (method == "Pending")
                    {
                        lblpaymentstatus.ForeColor = Color.Red;
                        lblpaymentstatus.Text = "Status: UNPAID";
                    }
                    else
                    {
                        lblpaymentstatus.ForeColor = Color.Green;
                        lblpaymentstatus.Text = "Status: PAID";
                    }
                }
                dtppaymentdate.Value = Convert.ToDateTime(row.Cells["PaymentDate"].Value);
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

            if (cmbsales.SelectedValue == null ||
                string.IsNullOrEmpty(txtamount.Text) ||
                string.IsNullOrEmpty(cmbmethods.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            decimal amount;
            if (!decimal.TryParse(txtamount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Please enter valid amount.");
                return;
            }

            PaymentBL bl = new PaymentBL(
                Convert.ToInt32(cmbsales.SelectedValue),
                amount,
                cmbmethods.Text,
                dtppaymentdate.Value);

            string currentMethod = dgvpayments.CurrentRow.Cells["Method"].Value.ToString();
            if (currentMethod != "Pending")
            {
                MessageBox.Show("This payment is already processed and cannot be changed.");
                return;
            }

            if (bl.updatePayment(selectedpaymentid))
            {
                MessageBox.Show("Payment updated!");
                ClearFields();
                LoadPayments();
            }
        }
    }
}
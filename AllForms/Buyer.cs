using SmartFarmManagementSystem.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class Buyer : Form
    {
        int selectedbuyerid = -1;
        public Buyer()
        {
            InitializeComponent();
        }

        private void Buyer_Load(object sender, EventArgs e)
        {
            if (LoginInfo.role.ToLower() != "admin")
            { 
                buttdelete.Enabled = false;
            }
            LoadBuyers();
        }

        private void LoadBuyers()
        {
            BuyerBL bl = new BuyerBL("", "");
            DataTable dt = bl.loadBuyers();
            if (dt != null)
            {
                dgvbuyers.DataSource = dt;
                dgvbuyers.Columns["BuyerID"].Visible = false;

            }
        }

        private void buttsave_Click(object sender, EventArgs e)
        {
            if(!ValidateBuyer())
            {
                return;
            }


            BuyerBL bl = new BuyerBL(txtname.Text, txtphone.Text);

            if (!bl.checkinputs())
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (selectedbuyerid == -1)
            {
                if (bl.addBuyer())
                {
                    MessageBox.Show("Buyer added!");
                    ClearFields();
                    LoadBuyers();
                }
            }
            else
            {
                if (bl.updateBuyer(selectedbuyerid))
                {
                    MessageBox.Show("Buyer updated!");
                    ClearFields();
                    LoadBuyers();
                }
            }
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {
            if (selectedbuyerid == -1)
            {
                MessageBox.Show("Please select a buyer first.");
                return;
            }

            if (MessageBox.Show("Delete this buyer?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                BuyerBL bl = new BuyerBL("", "");
                if (bl.deleteBuyer(selectedbuyerid))
                {
                    MessageBox.Show("Deleted.");
                    ClearFields();
                    LoadBuyers();
                }
            }
        }

        private bool ValidateBuyer()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (Validator.IsEmpty(txtname.Text))
            {
                errorProvider.SetError(txtname, "Buyer name is required.");
                isValid = false;
            }

            if (Validator.IsEmpty(txtphone.Text))
            {
                errorProvider.SetError(txtphone, "Phone is required.");
                isValid = false;
            }
            else if (!Validator.IsValidPhone(txtphone.Text))
            {
                errorProvider.SetError(txtphone, "Enter valid number e.g. 03001234567");
                isValid = false;
            }

            return isValid;
        }


        private void ClearFields()
        {
            selectedbuyerid = -1;
            txtname.Clear();
            txtphone.Clear();
        }

        private void dgvbuyers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvbuyers.Rows[e.RowIndex];
                selectedbuyerid = Convert.ToInt32(row.Cells["BuyerID"].Value);
                txtname.Text = row.Cells["Name"].Value.ToString();
                txtphone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void buttclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtname, "");
        }

        private void txtphone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            errorProvider.SetError(txtphone, "");
        }
    }
}

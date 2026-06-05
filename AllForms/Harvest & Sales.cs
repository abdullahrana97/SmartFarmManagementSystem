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
    public partial class Harvest___Sales : Form
    {

        int selectedharvestid = -1;
        int selectedsaleid = -1;


        public Harvest___Sales()
        {
            InitializeComponent();
            
        }






        // ==================== TAB 1 — HARVEST ====================

        private void LoadPlantationDropdown()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT p.PlantationID,
                          CONCAT(c.Name,' - ',f.Name) AS PlantationName
                          FROM plantation p
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          WHERE p.status = 'Active'";
            else
                query = @"SELECT p.PlantationID,
                          CONCAT(c.Name,' - ',f.Name) AS PlantationName
                          FROM plantation p
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          JOIN farm fm ON f.FarmID = fm.FarmID
                          WHERE p.status = 'Active'
                          AND fm.FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbplantation.DisplayMember = "PlantationName";
                    cmbplantation.ValueMember = "PlantationID";
                    cmbplantation.DataSource = dt;
                    cmbplantation.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadHarvests()
        {
            HarvestBL bl = new HarvestBL(0, 0, DateTime.Now);
            DataTable dt = bl.loadHarvests();
            if (dt != null)
            {
                dgvharvest.DataSource = dt;
                dgvharvest.Columns["HarvestID"].Visible = false;
                dgvharvest.Columns["PlantationID"].Visible = false;
            }
        }

        private void Harvest___Sales_Load(object sender, EventArgs e)
        {
            if(LoginInfo.role.ToLower() == "farmer")
            {
                btndelete.Visible = false;
                buttdelete.Visible = false;

            }

            LoadPlantationDropdown();
            LoadHarvests();
            LoadHarvestDropdown();
            LoadBuyerDropdown();
            LoadSales();
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (!ValidateHarvest())
            {
                MessageBox.Show("Please correct the errors and try again.");
                return;
            }


            if (cmbplantation.SelectedValue == null ||
                string.IsNullOrEmpty(txtquantityharvested.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            decimal qty;
            if (!decimal.TryParse(txtquantityharvested.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("Please enter valid quantity.");
                return;
            }

            HarvestBL bl = new HarvestBL(
                Convert.ToInt32(cmbplantation.SelectedValue),
                qty,
                dtpharvestdate.Value);

            if (bl.addHarvest())
            {
                MessageBox.Show("Harvest recorded and plantation marked as Harvested!");
                ClearHarvestFields();
                LoadHarvests();
                LoadPlantationDropdown();
                LoadHarvestDropdown(); // refresh sales tab
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedharvestid == -1)
            {
                MessageBox.Show("Please select a harvest first.");
                return;
            }

            if (MessageBox.Show("Delete this harvest?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                HarvestBL bl = new HarvestBL(0, 0, DateTime.Now);
                if (bl.deleteHarvest(selectedharvestid))
                {
                    MessageBox.Show("Deleted.");
                    ClearHarvestFields();
                    LoadHarvests();
                    LoadPlantationDropdown();
                    LoadHarvestDropdown();
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearHarvestFields();
        }

        private void dgvharvest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvharvest.Rows[e.RowIndex];
                selectedharvestid = Convert.ToInt32(row.Cells["HarvestID"].Value);
                DataBaseHelper.SetComboValue(cmbplantation, "PlantationID",
                    Convert.ToInt32(row.Cells["PlantationID"].Value));
                txtquantityharvested.Text = row.Cells["QuantityHarvested"].Value.ToString();
                dtpharvestdate.Value = Convert.ToDateTime(row.Cells["HarvestDate"].Value);
            }
        }

        private void ClearHarvestFields()
        {
            selectedharvestid = -1;
            cmbplantation.SelectedIndex = -1;
            txtquantityharvested.Clear();
            dtpharvestdate.Value = DateTime.Now;
        }

        private bool ValidateHarvest()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (cmbplantation.SelectedValue == null)
            {
                errorProvider.SetError(cmbplantation, "Please select a plantation.");
                isValid = false;
            }

            if (Validator.IsEmpty(txtquantityharvested.Text))
            {
                errorProvider.SetError(txtquantityharvested, "Quantity is required.");
                isValid = false;
            }
            else if (!Validator.IsValidQuantity(txtquantityharvested.Text))
            {
                errorProvider.SetError(txtquantityharvested, "Quantity must be a positive number.");
                isValid = false;
            }

            if (dtpharvestdate.Value > DateTime.Now)
            {
                errorProvider.SetError(dtpharvestdate, "Harvest date cannot be in future.");
                isValid = false;
            }

            return isValid;
        }





        // ==================== TAB 2 — SALES ====================

        private void LoadHarvestDropdown()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT h.HarvestID,
                          CONCAT(c.Name,' - ',f.Name,' (',h.Quantity,' kg)') AS HarvestName
                          FROM harvest h
                          JOIN plantation p ON h.PlantationID = p.PlantationID
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID";
            else
                query = @"SELECT h.HarvestID,
                          CONCAT(c.Name,' - ',f.Name,' (',h.Quantity,' kg)') AS HarvestName
                          FROM harvest h
                          JOIN plantation p ON h.PlantationID = p.PlantationID
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          JOIN farm fm ON f.FarmID = fm.FarmID
                          WHERE fm.FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbharvest.DisplayMember = "HarvestName";
                    cmbharvest.ValueMember = "HarvestID";
                    cmbharvest.DataSource = dt;
                    cmbharvest.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadBuyerDropdown()
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(
                        "SELECT BuyerID, Name FROM buyer", con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbbuyer.DisplayMember = "Name";
                    cmbbuyer.ValueMember = "BuyerID";
                    cmbbuyer.DataSource = dt;
                    cmbbuyer.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadSales()
        {
            SaleBL bl = new SaleBL(0, 0, 0, 0, DateTime.Now);
            DataTable dt = bl.loadSales();
            if (dt != null)
            {
                dgvsales.DataSource = dt;
                dgvsales.Columns["SaleID"].Visible = false;
                dgvsales.Columns["HarvestID"].Visible = false;
                dgvsales.Columns["BuyerID"].Visible = false;
                dgvsales.Columns["FarmerID"].Visible = false;
                
            }

        }

        

        private void buttdelete_Click(object sender, EventArgs e)
        {
            if (selectedsaleid == -1)
            {
                MessageBox.Show("Please select a sale first.");
                return;
            }

            if (MessageBox.Show("Delete this sale?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SaleBL bl = new SaleBL(0, 0, 0, 0, DateTime.Now);
                if (bl.deleteSale(selectedsaleid))
                {
                    MessageBox.Show("Deleted.");
                    ClearSaleFields();
                    LoadSales();
                }
            }
        }

        private void buttclear_Click(object sender, EventArgs e)
        {
            ClearSaleFields();
        }




        private void ClearSaleFields()
        {
            selectedsaleid = -1;
            cmbharvest.SelectedIndex = -1;
            cmbbuyer.SelectedIndex = -1;
            txtquantity.Clear();
            txtprice.Clear();
            dtpsaledate.Value = DateTime.Now;
        }

        private void dgvsales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvsales.Rows[e.RowIndex];
                selectedsaleid = Convert.ToInt32(row.Cells["SaleID"].Value);
                DataBaseHelper.SetComboValue(cmbbuyer, "BuyerID",
                    Convert.ToInt32(row.Cells["BuyerID"].Value));
                txtquantity.Text = row.Cells["QuantitytoSale"].Value.ToString();
                txtprice.Text = row.Cells["Price"].Value.ToString();
                dtpsaledate.Value = Convert.ToDateTime(row.Cells["SaleDate"].Value);
            }
        }


        private void CalculateTotal()
        {
            decimal qty, price;
            if (decimal.TryParse(txtquantity.Text, out qty) &&
                decimal.TryParse(txtprice.Text, out price))
            {
                lbltotal.Text = "Total: Rs. " + (qty * price).ToString("N2");
            }
            else
            {
                lbltotal.Text = "Total: Rs. 0.00";
            }
        }
        private void Sales_Click(object sender, EventArgs e)
        {
            if(LoginInfo.role.ToLower() != "admin")
            {
                buttdelete.Visible = false;
            }
        }

      

        private void buttsave_Click_1(object sender, EventArgs e)
        {

            if(!ValidateSale())
            {
                MessageBox.Show("Please correct the errors and try again.");
                return;
            }

            if (cmbharvest.SelectedValue == null ||
                           cmbbuyer.SelectedValue == null ||
                           string.IsNullOrEmpty(txtquantity.Text) ||
                           string.IsNullOrEmpty(txtprice.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            decimal qty, price;
            if (!decimal.TryParse(txtquantity.Text, out qty) || qty <= 0)
            {
                MessageBox.Show("Please enter valid quantity.");
                return;
            }
            if (!decimal.TryParse(txtprice.Text, out price) || price <= 0)
            {
                MessageBox.Show("Please enter valid price.");
                return;
            }

            // get harvested quantity from database
            decimal harvestedQty = 0;
            int harvestid = Convert.ToInt32(cmbharvest.SelectedValue);

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT Quantity FROM harvest WHERE HarvestID = @id", con);
                    cmd.Parameters.AddWithValue("@id", harvestid);
                    harvestedQty = Convert.ToDecimal(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }

            // validating quantity against harvested quantity
            if (qty > harvestedQty)
            {
                MessageBox.Show("Sale quantity " + qty + " kg cannot exceed " +"harvested quantity " + harvestedQty + " kg.");
                return;
            }

            SaleBL bl = new SaleBL(
                Convert.ToInt32(cmbharvest.SelectedValue),
                Convert.ToInt32(cmbbuyer.SelectedValue),
                qty, price,
                dtpsaledate.Value);

            if (bl.addSale())
            {
                MessageBox.Show("Sale recorded and payment entry created!");
                ClearSaleFields();
                LoadSales();
            }
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            errorProvider.SetError(txtquantity, "");
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            errorProvider.SetError(txtprice, "");   
        }

        private void cmbharvest_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbharvest, ""); 


            if (cmbharvest.SelectedValue == null) return;

            int harvestid = Convert.ToInt32(cmbharvest.SelectedValue);

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(
                        "SELECT Quantity FROM harvest WHERE HarvestID = @id", con);
                    cmd.Parameters.AddWithValue("@id", harvestid);
                    decimal harvestedQty = Convert.ToDecimal(cmd.ExecuteScalar());
                    lblavailablequantity.Text = "Available: " + harvestedQty + " kg";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private bool ValidateSale()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (cmbharvest.SelectedValue == null)
            {
                errorProvider.SetError(cmbharvest, "Please select a harvest.");
                isValid = false;
            }

            if (cmbbuyer.SelectedValue == null)
            {
                errorProvider.SetError(cmbbuyer, "Please select a buyer.");
                isValid = false;
            }

            if (Validator.IsEmpty(txtquantity.Text))
            {
                errorProvider.SetError(txtquantity, "Quantity is required.");
                isValid = false;
            }
            else if (!Validator.IsValidQuantity(txtquantity.Text))
            {
                errorProvider.SetError(txtquantity, "Quantity must be a positive number.");
                isValid = false;
            }

            if (Validator.IsEmpty(txtprice.Text))
            {
                errorProvider.SetError(txtprice, "Price is required.");
                isValid = false;
            }
            else if (!Validator.IsValidPrice(txtprice.Text))
            {
                errorProvider.SetError(txtprice, "Price must be a positive number.");
                isValid = false;
            }

            return isValid;
        }

        private void cmbplantation_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbplantation, "");

        }

        private void txtquantityharvested_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtquantityharvested, "");
        }

        private void cmbbuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbbuyer, "");   
        }
    }
}

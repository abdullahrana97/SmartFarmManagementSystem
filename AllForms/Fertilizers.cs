using SmartFarmManagementSystem.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class Fertilizers : Form
    {
        int selectedfertilizerID = -1;
        int selectedstockID = -1;
        int selectedapplicationID = -1;
        int selectedfieldID = -1;
        int selectedworkerID = -1;

        public Fertilizers()
        {
            InitializeComponent();
        }


        private void Fertilizers_Load(object sender, EventArgs e)
        {
            // Tab 1
            LoadTypeItems();
            LoadFertilizers();

            // Tab 2
            LoadFertilizerDropdown();
            LoadStock();

            // Tab 3
            LoadFieldDropdown();
            LoadFertilizerNameDropdown();
            LoadWorkerDropdown();
            LoadApplications();

        }


        private void LoadTypeItems()
        {
            cmbtype.Items.Clear();
            cmbtype.Items.Add("Chemical");
            cmbtype.Items.Add("Organic");
            cmbtype.Items.Add("Bio");
        }

        private void LoadFertilizers()
        {
            FertilizerBL bl = new FertilizerBL("", "");
            DataTable dt = bl.loadFertilizers();
            if (dt != null)
            {
                dgvfertilizers.DataSource = dt;
                dgvfertilizers.Columns["FertilizerID"].Visible = false;

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            FertilizerBL bl = new FertilizerBL(txtfname.Text, cmbtype.Text);

            if (!bl.checkinputs())
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (selectedfertilizerID == -1)
            {
                if (bl.addFertilizer())
                {
                    MessageBox.Show("Fertilizer added!");
                    ClearFertilizerFields();
                    LoadFertilizers();
                    LoadFertilizerDropdown();
                    LoadFertilizerNameDropdown();
                }
            }
            else
            {
                if (bl.updateFertilizer(selectedfertilizerID))
                {
                    MessageBox.Show("Fertilizer updated!");
                    ClearFertilizerFields();
                    LoadFertilizers();
                    LoadFertilizerDropdown();
                    LoadFertilizerNameDropdown();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedfertilizerID == -1)
            {
                MessageBox.Show("Please select a fertilizer first.");
                return;
            }

            if (MessageBox.Show("Delete this fertilizer?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FertilizerBL bl = new FertilizerBL("", "");
                if (bl.deleteFertilizer(selectedfertilizerID))
                {
                    MessageBox.Show("Deleted.");
                    ClearFertilizerFields();
                    LoadFertilizers();
                }
            }
        }


        private void ClearFertilizerFields()
        {
            selectedfertilizerID = -1;
            txtfname.Clear();
            cmbtype.SelectedIndex = -1;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFertilizerFields();
        }


        private void LoadFertilizerDropdown()
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(
                        "SELECT FertilizerID, Name FROM fertilizer", con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbfertilizer.DisplayMember = "Name";
                    cmbfertilizer.ValueMember = "FertilizerID";
                    cmbfertilizer.DataSource = dt;
                    cmbfertilizer.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadStock()
        {
            FertilizerStockBL bl = new FertilizerStockBL(0, 0, DateTime.Now);
            DataTable dt = bl.loadStock();
            if (dt != null)
            {
                dgvfertilizerstock.DataSource = dt;
                dgvfertilizerstock.Columns["StockID"].Visible = false;
                dgvfertilizerstock.Columns["FertilizerID"].Visible = false;
            }
        }
        private void dgvfertilizers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvfertilizers.Rows[e.RowIndex];
                selectedfertilizerID = Convert.ToInt32(row.Cells["FertilizerID"].Value);
                txtfname.Text = row.Cells["Name"].Value.ToString();
                cmbtype.Text = row.Cells["Type"].Value.ToString();
            }
        }








        // ==================== TAB 2 — STOCK ====================



        private void butsave_Click(object sender, EventArgs e)
        {
            if (cmbfertilizer.SelectedValue == null ||
                string.IsNullOrEmpty(txtquantityadded.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            FertilizerStockBL bl = new FertilizerStockBL(
                Convert.ToInt32(cmbfertilizer.SelectedValue),
                Convert.ToDouble(txtquantityadded.Text),
                dtpstockdate.Value);

            if (!bl.checkinputs())
            {
                MessageBox.Show("Quantity must be greater than zero.");
                return;
            }

            if (bl.addStock())
            {
                MessageBox.Show("Stock added!");
                ClearStockFields();
                LoadFertilizerNameDropdown();
                LoadStock();
            }
        }

        private void ClearStockFields()
        {
            selectedstockID = -1;
            cmbfertilizer.SelectedIndex = -1;
            txtquantityadded.Clear();
            dtpstockdate.Value = DateTime.Now;
        }

        private void butclear_Click(object sender, EventArgs e)
        {
            ClearStockFields();
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            if (selectedstockID == -1)
            {
                MessageBox.Show("Please select a stock record first.");
                return;
            }

            if (MessageBox.Show("Delete this stock record?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FertilizerStockBL bl = new FertilizerStockBL(0, 0, DateTime.Now);
                if (bl.deleteStock(selectedstockID))
                {
                    MessageBox.Show("Deleted.");
                    ClearStockFields();
                    LoadStock();
                }
            }
        }

        private void dgvfertilizerstock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvfertilizerstock.Rows[e.RowIndex];
                selectedstockID = Convert.ToInt32(row.Cells["StockID"].Value);
                DataBaseHelper.SetComboValue(cmbfertilizer, "FertilizerID",
                    Convert.ToInt32(row.Cells["FertilizerID"].Value));
                txtquantityadded.Text = row.Cells["QuantityAdded"].Value.ToString();
                dtpstockdate.Value = Convert.ToDateTime(row.Cells["StockDate"].Value);
            }
        }


        // ==================== TAB 3 — APPLICATION ====================


        private void LoadFieldDropdown()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT field.FieldID, 
                          CONCAT(farm.Name,' - ',field.Name) AS FieldName
                          FROM field JOIN farm ON field.FarmID = farm.FarmID";
            else
                query = @"SELECT field.FieldID, 
                          CONCAT(farm.Name,' - ',field.Name) AS FieldName
                          FROM field JOIN farm ON field.FarmID = farm.FarmID
                          WHERE farm.FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbfieldname.DisplayMember = "FieldName";
                    cmbfieldname.ValueMember = "FieldID";
                    cmbfieldname.DataSource = dt;
                    cmbfieldname.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void LoadFertilizerNameDropdown()
        {
            // show available quantity next to name
            string query = @"SELECT FertilizerID, 
                            CONCAT(Name, ' (Available: ', AvailableQuantity, ' kg)') AS FertilizerName
                            FROM vw_FertilizerAvailable
                            WHERE AvailableQuantity > 0";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbfertilizername.DisplayMember = "FertilizerName";
                    cmbfertilizername.ValueMember = "FertilizerID";
                    cmbfertilizername.DataSource = dt;
                    cmbfertilizername.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvapplication_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex >= 0)
            {
                

                DataGridViewRow row = dgvapplication.Rows[e.RowIndex];
                selectedapplicationID =
              Convert.ToInt32(row.Cells["ApplicationID"].Value);

                cmbfieldname.SelectedValue =
                    Convert.ToInt32(row.Cells["FieldID"].Value);

                cmbfertilizername.SelectedValue =
                    Convert.ToInt32(row.Cells["FertilizerID"].Value);

                cmbworker.SelectedValue =
                    Convert.ToInt32(row.Cells["WorkerID"].Value);

                txtquantityused.Text =
                    row.Cells["QuantityUsed"].Value.ToString();

                dtpapplicationstart.Value =
                    Convert.ToDateTime(row.Cells["ApplicationDate"].Value);
            }
        }

        private void buttdelete_Click(object sender, EventArgs e)
        {

            if (selectedapplicationID == -1)
            {
                MessageBox.Show("Please select an application first.");
                return;
            }

            if (MessageBox.Show("Delete this application?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                FertilizerApplicationBL bl = new FertilizerApplicationBL(0, 0, 0, 0, DateTime.Now);
                if (bl.deleteApplication(selectedapplicationID))
                {
                    MessageBox.Show("Deleted.");
                    ClearApplicationFields();
                    LoadApplications();
                    LoadFertilizerNameDropdown();
                }
            }
        }

        private void ClearApplicationFields()
        {
            selectedapplicationID = -1;
            cmbfieldname.SelectedIndex = -1;
            cmbfertilizername.SelectedIndex = -1;
            cmbworker.SelectedIndex = -1;
            txtquantityused.Clear();
            dtpapplicationstart.Value = DateTime.Now;
        }

        private void buttsave_Click(object sender, EventArgs e)
        {
            if (cmbfieldname.SelectedValue == null ||
                cmbfertilizername.SelectedValue == null ||
                cmbworker.SelectedValue == null ||
                string.IsNullOrEmpty(txtquantityused.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            FertilizerApplicationBL bl = new FertilizerApplicationBL(
                Convert.ToInt32(cmbfieldname.SelectedValue),
                Convert.ToInt32(cmbfertilizername.SelectedValue),
                Convert.ToInt32(cmbworker.SelectedValue),
                Convert.ToDecimal(txtquantityused.Text),
                dtpapplicationstart.Value);

            if (!bl.checkinputs())
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            // trigger will automatically check if enough stock available
            if (bl.addApplication())
            {
                MessageBox.Show("Application recorded!");
                ClearApplicationFields();
                LoadApplications();
                LoadFertilizerNameDropdown(); // refresh available qty
            }
        }

        private void LoadApplications()
        {
            FertilizerApplicationBL bl = new FertilizerApplicationBL(0, 0, 0, 0, DateTime.Now);
            DataTable dt = bl.loadApplications();
            if (dt != null)
            {
                dgvapplication.DataSource = dt;
                dgvapplication.Columns["ApplicationID"].Visible = false;
                dgvapplication.Columns["FieldID"].Visible = false;
                dgvapplication.Columns["FertilizerID"].Visible = false;
                dgvapplication.Columns["WorkerID"].Visible = false;
               
            }
        }

        private void LoadWorkerDropdown()
        {
            string query;
            if (LoginInfo.role.ToLower() == "admin")
                query = "SELECT WorkerID, WorkerName FROM worker";
            else
                query = "SELECT WorkerID, WorkerName FROM worker WHERE FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbworker.DisplayMember = "WorkerName";
                    cmbworker.ValueMember = "WorkerID";
                    cmbworker.DataSource = dt;
                    cmbworker.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

       
    }

}

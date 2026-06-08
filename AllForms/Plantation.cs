using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using SmartFarmManagementSystem.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class Plantation : Form
    {
        public Plantation()
        {
            InitializeComponent();
        }

        int selectedplantationid = -1;
        private void LoadFieldDropdown()
        {
            string query;

            if (LoginInfo.role.ToLower() == "admin")
                query = @"SELECT f.FieldID, CONCAT(fm.Name,' - ',f.Name) AS FieldName 
                          FROM field f 
                          INNER JOIN farm fm ON f.FarmID = fm.FarmID";
            else
                query = @"SELECT f.FieldID, CONCAT(fm.Name,' - ',f.Name) AS FieldName 
                          FROM field f 
                          INNER JOIN farm fm ON f.FarmID = fm.FarmID 
                          WHERE fm.FarmerID = " + LoginInfo.userid;

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbfields.DisplayMember = "FieldName";
                    cmbfields.ValueMember = "FieldID";
                    cmbfields.DataSource = dt;
                    cmbfields.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading fields: " + ex.Message);
                }
            }
        }

        // Load crops dropdown
        private void LoadCropDropdown()
        {
            string query = "SELECT CropID, CONCAT(Name,' (',Season,')') AS CropName FROM crop";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbcrops.DisplayMember = "CropName";
                    cmbcrops.ValueMember = "CropID";
                    cmbcrops.DataSource = dt;
                    cmbcrops.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading crops: " + ex.Message);
                }
            }
        }

        private void Plantation_Load(object sender, EventArgs e)
        {
            if (LoginInfo.role.ToLower() != "admin")
            {
                btndelete.Visible = false;
            }

            LoadCropDropdown();
            LoadFieldDropdown();
            loadplantations();

            cmbstatus.Items.Add("Active");
            cmbstatus.Items.Add("Harvested");
            cmbstatus.Items.Add("Failed");
            cmbstatus.SelectedIndex = 0;

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidatePlantation())
                return;


            int cropid = Convert.ToInt32(cmbcrops.SelectedValue);
            int fieldid = Convert.ToInt32(cmbfields.SelectedValue);
            string status = cmbstatus.SelectedItem.ToString();

            PlantationBL plantation = new PlantationBL(fieldid, cropid, dtpplantationdate.Value, status);

            if (plantation.checkinput())
            {

                DateTime? harvestDate = plantation.gettingharvestdate();

                if (harvestDate.HasValue)
                    lblexpecteddate.Text = harvestDate.Value.ToString("dd MMM yyyy");
                


                if (selectedplantationid == -1)
                {
                    if (plantation.saveplantation())
                    {
                        MessageBox.Show("Plantation saved successfully.");
                        ClearFields();
                        loadplantations();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save plantation.");
                    }
                }
                else
                {
                    if (plantation.updateplantation(selectedplantationid))
                    {
                        MessageBox.Show("Plantation updated successfully.");
                        ClearFields();
                        loadplantations();

                    }
                    else
                    {
                        MessageBox.Show("Failed to update plantation.");
                    }
                }
            }
        }

        private void dgvplantations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvplantations.Rows[e.RowIndex];
                selectedplantationid = Convert.ToInt32(row.Cells["PlantationID"].Value);
               cmbfields.SelectedValue = Convert.ToInt32(row.Cells["FieldID"].Value);
                cmbcrops.SelectedValue = Convert.ToInt32(row.Cells["CropID"].Value);
                cmbstatus.Text = row.Cells["status"].Value.ToString();
                dtpplantationdate.Value = Convert.ToDateTime(row.Cells["PlantingDate"].Value);
                lblexpecteddate.Text = Convert.ToDateTime(row.Cells["ExpectedHarvestDate"].Value).ToString("dd MMM yyyy");

            }
        }

        private void ClearFields()
        {
            selectedplantationid = -1;

            cmbfields.SelectedIndex = -1;
            cmbcrops.SelectedIndex = -1;
            cmbstatus.SelectedIndex = -1;   
            dtpplantationdate.Value = DateTime.Now;
            lblexpecteddate.Text = "Auto Calculated";

        }

        private bool ValidatePlantation()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (cmbfields.SelectedValue == null)
            {
                errorProvider.SetError(cmbfields, "Please select a field.");
                isValid = false;
            }

            if (cmbcrops.SelectedValue == null)
            {
                errorProvider.SetError(cmbcrops, "Please select a crop.");
                isValid = false;
            }

            if (dtpplantationdate.Value > DateTime.Now)
            {
                errorProvider.SetError(dtpplantationdate, "Planting date cannot be in future.");
                isValid = false;
            }

            return isValid;
        }



        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedplantationid != -1)
            {

                // jo mrzi constructor ko value de do doesnot matter this time as we delete on basis of plantationid

                PlantationBL plantation = new PlantationBL(0, 0, DateTime.Now,"");

                if (MessageBox.Show("Are you sure you want to delete this plantation?", "Confirm Deletion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (plantation.deleteplanataion(selectedplantationid))
                    {
                        MessageBox.Show("Plantation deleted successfully.");
                        ClearFields();
                        loadplantations();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete plantation.");
                    }
                }
                else
                {
                    MessageBox.Show("Deletion cancelled.");
                    ClearFields();
                }
            }
        }


        public void loadplantations()
        {
            //ConstructionCallvalues doesnot matter at this place


            PlantationBL plantation = new PlantationBL(0, 0, DateTime.Now,"");
            dgvplantations.DataSource = plantation.loaddgvplantations();
            dgvplantations.Columns["PlantationID"].Visible = false;
            dgvplantations.Columns["FieldId"].Visible = false;
            dgvplantations.Columns["CropId"].Visible = false;
            dgvplantations.Columns["FarmerID"].Visible = false;
        }

        private void dtpplantationdate_ValueChanged(object sender, EventArgs e)
        {

            if (cmbcrops.SelectedValue == null) return;

            int cropid = cmbcrops.SelectedValue != null ? Convert.ToInt32(cmbcrops.SelectedValue) : 0;  
            int fieldid = cmbfields.SelectedValue != null ? Convert.ToInt32(cmbfields.SelectedValue) : 0;
            string status = cmbstatus.SelectedItem != null ? cmbstatus.SelectedItem.ToString() : "";

            PlantationBL plantation = new PlantationBL(fieldid,cropid, dtpplantationdate.Value, status);

            DateTime? harvestDate = plantation.gettingharvestdate();

            if (harvestDate.HasValue) {
                lblexpecteddate.Text = harvestDate.Value.ToString("dd MMM yyyy");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cmbfields_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbfields, "");
        }

        private void cmbcrops_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbcrops, "");
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cmbstatus, "");
        }
    }
}

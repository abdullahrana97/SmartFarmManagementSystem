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
        public void loadfields()
        {
            string query;

            if (LoginInfo.role.ToLower() == "farmer")
            {
                query = $"Select field.Name as FieldName,FieldId from field inner join farm fm on field.farmid = fm.farmid inner join user u on fm.FarmerId = u.UserId where u.userid = " + LoginInfo.userid;

            }
            else
            {
                query = $"Select field.Name as FieldName,FieldId from field inner join farm fm on field.farmid = fm.farmid inner join user u on fm.FarmerId = u.UserId ";
            }

            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {


                try
                {
                    DataBaseHelper.FillComboBox(cmbfields, query, "FieldName", "FieldId");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void loadcrops()
        {
            string query = $"Select CropId,Name from crop";
            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {
                try
                {
                    DataBaseHelper.FillComboBox(cmbcrops, query, "Name", "CropId");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Plantation_Load(object sender, EventArgs e)
        {
            loadcrops();
            loadfields();
            loadplantations();

        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            int cropid = Convert.ToInt32(cmbcrops.SelectedValue);
            int fieldid = Convert.ToInt32(cmbfields.SelectedValue);
            PlantationBL plantation = new PlantationBL(fieldid, cropid, dtpplantationdate.Value);

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
                cmbfields.Text = row.Cells["FieldName"].Value.ToString();
                cmbcrops.Text = row.Cells["CropName"].Value.ToString();
                dtpplantationdate.Value = Convert.ToDateTime(row.Cells["PlantingDate"].Value);
                lblexpecteddate.Text = Convert.ToDateTime(row.Cells["ExpectedHarvestDate"].Value).ToString("dd MMM yyyy");

            }
        }

        private void ClearFields()
        {
            selectedplantationid = -1;

            cmbfields.SelectedIndex = -1;
            cmbcrops.SelectedIndex = -1;
            dtpplantationdate.Value = DateTime.Now;
            lblexpecteddate.Text = "Auto Calculated";

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (selectedplantationid != -1)
            {

                // jo mrzi constructor ko value de do doesnot matter this time as we delete on basis of plantationid

                PlantationBL plantation = new PlantationBL(0, 0, DateTime.Now);

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


            PlantationBL plantation = new PlantationBL(0, 0, DateTime.Now);
            dgvplantations.DataSource = plantation.loaddgvplantations();
        }

        private void dtpplantationdate_ValueChanged(object sender, EventArgs e)
        {

            if (cmbcrops.SelectedValue == null) return;

            int cropid = cmbcrops.SelectedValue != null ? Convert.ToInt32(cmbcrops.SelectedValue) : 0;  
            int fieldid = cmbfields.SelectedValue != null ? Convert.ToInt32(cmbfields.SelectedValue) : 0;

            PlantationBL plantation = new PlantationBL(fieldid,cropid, dtpplantationdate.Value);

            DateTime? harvestDate = plantation.gettingharvestdate();

            if (harvestDate.HasValue) {
                lblexpecteddate.Text = harvestDate.Value.ToString("dd MMM yyyy");
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}

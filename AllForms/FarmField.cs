using MySql.Data.MySqlClient;
using SmartFarmManagementSystem.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class FarmField : Form
    {
        public FarmField()
        {
            InitializeComponent();
            LoadFarms();
            loadcombofarms();
            loadcombosoiltypes();
            loadfields();
        }



        int selectedfarmid = -1;    
        int selectedfieldid = -1;
        private void LoadFarms()
        {
            if (LoginInfo.role.ToLower() == "admin")
            {
                string query = $"SELECT f.FarmID, f.Name, f.Location, f.Status, u.Username AS AssignedTo FROM farm f INNER JOIN user u ON f.FarmerID = u.UserID";

                using (MySqlConnection con = DataBaseHelper.getconnection())
                {
                    try
                    {
                        MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                        DataTable dt = new DataTable();

                        adp.Fill(dt);
                        dgvfarm.DataSource = dt;
                        dgvfarm.Columns["FarmID"].Visible = false; 
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading Grid" + "Error");
                    }
                }
            }

            else if (LoginInfo.role.ToLower() == "farmer")
            {
                string query = "SELECT f.FarmID, f.Name, f.Location, f.Status, u.Username AS AssignedTo FROM farm f INNER JOIN user u ON f.FarmerID = u.UserID WHERE f.FarmerID = " + LoginInfo.userid;
                using (MySqlConnection con = DataBaseHelper.getconnection())
                {
                    try
                    {
                        MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                        DataTable dt = new DataTable();

                        adp.Fill(dt);
                        dgvfarm.DataSource = dt;
                        dgvfarm.Columns["FarmID"].Visible = false;
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Loading Grid" + "Error");
                    }
                }

            }






        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            FarmBL farm = new FarmBL(txtfarmname.Text, txtlocation.Text, cmbstatus.Text);

            if (!farm.checkinputs())
            {
                MessageBox.Show("Please Fill all the Fields");
                txtfarmname.Clear();
                txtlocation.Clear();
                txtfarmname.Focus();
            }
            if (selectedfarmid == -1)
            {
                if (farm.addFarm())
                {
                    MessageBox.Show("Successfully Added Farm !");
                    ClearFields();
                    loadcombofarms();
                    LoadFarms();
                   
                }
            }

            else
            {
                if (farm.updateFarm(selectedfarmid))
                {
                    MessageBox.Show("Successfully Updated Farm !");
                    ClearFields();
                    LoadFarms();
                    

                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            FarmBL farm = new FarmBL(txtfarmname.Text, txtlocation.Text, cmbstatus.Text);

            if (selectedfarmid == -1)
            {
                MessageBox.Show("Please Select the farm from grid!", "Error");
            }

            DialogResult result = MessageBox.Show("Do you want to delete this Farm ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (farm.deleteFarm(selectedfarmid))
                {
                    MessageBox.Show("Successfully Deleted the farm!");
                    ClearFields();
                    LoadFarms();
                }
            }

        }

        private void ClearFields()
        {
            selectedfarmid = -1;
            txtfarmname.Clear();
            txtlocation.Clear();
            cmbstatus.SelectedIndex = -1;
        }

        private void dgvfarm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvfarm.Rows[e.RowIndex];
                selectedfarmid = Convert.ToInt32(row.Cells["FarmID"].Value);
                txtfarmname.Text = row.Cells["Name"].Value.ToString();
                txtlocation.Text = row.Cells["Location"].Value.ToString();
                cmbstatus.Text = row.Cells["Status"].Value.ToString();
            }
        }





        //==================FOR FIeld Form========================


        public void loadfields()
        {
          
            string query;

            if (LoginInfo.role.ToLower() == "admin")
                query = "SELECT * FROM vw_FieldDetails";
            else
                query = "SELECT * FROM vw_FieldDetails WHERE FarmName IN " +
                        "(SELECT Name FROM farm WHERE FarmerID = " + LoginInfo.userid + ")";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                 
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dgvfields.DataSource = dt;
                    dgvfields.Columns["FieldID"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        public void loadcombofarms()
        {
            if (LoginInfo.role.ToLower() == "admin")
            {
                DataBaseHelper.FillComboBox(cmbfarms, "Select FarmId, Name from Farm", "Name", "FarmId");
            }
            else
            {
                DataBaseHelper.FillComboBox(cmbfarms, "Select FarmId, Name from Farm where FarmerId = "+LoginInfo.userid, "Name", "FarmId");
            }
        }
        public void loadcombosoiltypes()
        {
            DataBaseHelper.FillComboBox(cmbsoiltypes, "Select SoilTypeID, TypeName from soiltype", "TypeName", "SoilTypeID");

        }

        private void btnsaveupdate_Click(object sender, EventArgs e)
        {
            FieldBL field = new FieldBL(txtfieldname.Text, Convert.ToDouble(txtarea.Text), Convert.ToInt32(cmbsoiltypes.SelectedValue), Convert.ToInt32(cmbfarms.SelectedValue));
            if (selectedfieldid == -1)
            {
                if (field.addField())
                {
                    MessageBox.Show("Successfully Added Field !");
                ClearFieldFields();
                    loadfields();
                    MainForm.LoadForm(new DashBoard());
                }
            }
            else
            {
                if (field.updateField(selectedfieldid))
                {
                    MessageBox.Show("Successfully Updated Field !");
               ClearFieldFields ();
                    loadfields();
                    MainForm.LoadForm(new DashBoard());
                }
            }
        }

        private void dgvfields_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvfields.Rows[e.RowIndex];
                selectedfieldid = Convert.ToInt32(row.Cells["FieldID"].Value);
                txtfieldname.Text = row.Cells["Name"].Value.ToString();
                txtarea.Text = row.Cells["Area"].Value.ToString();
                cmbsoiltypes.Text = row.Cells["SoilType"].Value.ToString();
                cmbfarms.Text = row.Cells["FarmName"].Value.ToString();
            }
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
           ClearFieldFields();
        }

        private void bttndelete_Click(object sender, EventArgs e)
        {
           FieldBL field = new FieldBL(txtfieldname.Text, Convert.ToDouble(txtarea.Text), Convert.ToInt32(cmbsoiltypes.SelectedValue), Convert.ToInt32(cmbfarms.SelectedValue));

            if (selectedfieldid == -1)
            {
                MessageBox.Show("Please Select the field from grid!", "Error");
            }

            DialogResult result = MessageBox.Show("Do you want to delete this Field ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (field.deleteField(selectedfieldid))
                {
                    MessageBox.Show("Successfully Deleted the field!");
                    ClearFieldFields();
                    loadfields();
                    MainForm.LoadForm(new DashBoard());
                }
            }


        }

        private void ClearFieldFields()
        {
            selectedfieldid = -1;
            txtfieldname.Clear();
            txtarea.Clear();
            cmbfarms.SelectedIndex = -1;
            cmbsoiltypes.SelectedIndex = -1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadcombofarms();
        }
    }
}

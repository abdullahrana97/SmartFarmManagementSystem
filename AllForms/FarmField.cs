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

        int farmerid;
        public FarmField()
        {
            InitializeComponent();
            LoadFarms();
            loadcombofarms();
            loadcombosoiltypes();
            loadfields();
            this.Load += FarmField_Load;
        }

        private void FarmField_Load(object sender, EventArgs e)
        {
            if(LoginInfo.role.ToLower() == "farmer")
            {
                btndelete.Visible = false;
                bttndelete.Visible = false;
                lblfarmer.Visible = false;
                cmbfarmer.Visible = false;
               
            }
            if (LoginInfo.role.ToLower() == "admin")
            {
                lblfarmer.Visible = true;
                cmbfarmer.Visible = true;
                LoadFarmerDropdown();
            }
            LoadFarms();
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

        private void LoadFarmerDropdown()
        {
            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(
                        "SELECT UserID, Username FROM user WHERE Role = 'Farmer'", con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    cmbfarmer.DisplayMember = "Username";
                    cmbfarmer.ValueMember = "UserID";
                    cmbfarmer.DataSource = dt;
                    cmbfarmer.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!ValidateFarm()) return;


            if (LoginInfo.role.ToLower() == "admin")
            {
                if (cmbfarmer.SelectedValue == null)
                {
                    MessageBox.Show("Please select a farmer to assign this farm to.");
                    return;
                }
                farmerid = Convert.ToInt32(cmbfarmer.SelectedValue);
            }
            else
            {
                // farmer assigns to himself
                farmerid = LoginInfo.userid;
            }


           

            FarmBL farm = new FarmBL(txtfarmname.Text, txtlocation.Text, cmbstatus.Text,farmerid);

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
            FarmBL farm = new FarmBL(txtfarmname.Text, txtlocation.Text, cmbstatus.Text, farmerid);

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

        private bool ValidateFarm()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (Validator.IsEmpty(txtfarmname.Text))
            {
                errorProvider.SetError(txtfarmname, "Farm name is required.");
                isValid = false;
            }
            else if (txtfarmname.Text.Length < 3)
            {
                errorProvider.SetError(txtfarmname, "Farm name must be at least 3 characters.");
                isValid = false;
            }

            if (Validator.IsEmpty(txtlocation.Text))
            {
                errorProvider.SetError(txtlocation, "Location is required.");
                isValid = false;
            }

            if (string.IsNullOrEmpty(cmbstatus.Text))
            {
                errorProvider.SetError(cmbstatus, "Please select a status.");
                isValid = false;
            }

            return isValid;
        }

        private void txtfarmname_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtfarmname, "");
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
                if (!ValidateField()) return;

            FieldBL field = new FieldBL(txtfieldname.Text, Convert.ToDouble(txtarea.Text), Convert.ToInt32(cmbsoiltypes.SelectedValue), Convert.ToInt32(cmbfarms.SelectedValue));
            if (selectedfieldid == -1)
            {
                if (field.addField())
                {
                    MessageBox.Show("Successfully Added Field !");
                ClearFieldFields();
                    loadfields();
                 
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
                txtfieldname.Text = row.Cells["FieldName"].Value.ToString();
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
            txtfieldname.Focus();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            loadcombofarms();
        }


       



        private bool ValidateField()
        {
            errorProvider.Clear();
            bool isValid = true;

            if (Validator.IsEmpty(txtfieldname.Text))
            {
                errorProvider.SetError(txtfieldname, "Field name is required.");
                isValid = false;
            }

            if (Validator.IsEmpty(txtarea.Text))
            {
                errorProvider.SetError(txtarea, "Area is required.");
                isValid = false;
            }
            else if (!Validator.IsValidArea(txtarea.Text))
            {
                errorProvider.SetError(txtarea, "Area must be a positive number.");
                isValid = false;
            }

            if (cmbfarms.SelectedValue == null)
            {
                errorProvider.SetError(cmbfarms, "Please select a farm.");
                isValid = false;
            }

            if (cmbsoiltypes.SelectedValue == null)
            {
                errorProvider.SetError(cmbsoiltypes, "Please select a soil type.");
                isValid = false;
            }

            return isValid;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtfarmname.Clear();
            txtlocation.Clear();
            cmbstatus.SelectedIndex = -1;
            txtfarmname.Focus();
        }

        private void txtlocation_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtlocation, "");
        }

        private void txtfieldname_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtfieldname, "");
        }

        private void txtarea_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtarea, "");
        }
    }
}

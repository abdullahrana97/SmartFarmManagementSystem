using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartFarmManagementSystem.AllClasses;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class Farm : Form
    {
        public Farm()
        {
            InitializeComponent();
            LoadFarms();
        }

        int selectedfarmid = -1;


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
          
            FarmBL farm = new FarmBL(txtfarmname.Text,txtlocation.Text,cmbstatus.Text);

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
                    MainForm main = new MainForm();
                    main.Show();
                    this.Close();
                }
            }

            else
            {
                if (farm.updateFarm(selectedfarmid))
                {
                    MessageBox.Show("Successfully Updated Farm !");
                    MainForm.LoadForm(new DashBoard());
                    
                }

            }
        }

        

        private void dgvfarm_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
                    LoadFarms();
                }
            }
        }
    }

}

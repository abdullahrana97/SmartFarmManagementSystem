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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        public bool checkinputs()
        {
            errorProvider.SetError(txtusername, "");
            errorProvider.SetError(txtpassword, "");
            errorProvider.SetError(lblrole, "");

            bool isValid = true;

            if (string.IsNullOrEmpty(txtusername.Text))
            {
                errorProvider.SetError(txtusername, "Username is Required!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                errorProvider.SetError(txtpassword, "Password is Required!");
                isValid = false;
            }

            if (!rbuser.Checked)
            {
                errorProvider.SetError(lblrole, "Select a Role");
                isValid = false;
            }

            return isValid;
        }
      

        private void btnlogin_Click(object sender, EventArgs e)
        {

            
            if (checkinputs())
            {

                string role =  "Farmer";

                using (MySqlConnection conn = DataBaseHelper.getconnection())
                {
                    
                    try
                        {
                            string query = "Insert into user (Username,Password,Role) Values (@u,@p,@r)";

                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            cmd.Parameters.AddWithValue("@u", txtusername.Text);
                            cmd.Parameters.AddWithValue("@p", txtpassword.Text);
                            cmd.Parameters.AddWithValue("@r", role);


                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully added as " + role);

                            Login login = new Login();
                            login.Show();
                            this.Hide();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Cannot Add! " + role + ex.Message);
                        }
               
                }
            }

            else
            {
                MessageBox.Show("There was some error with your inputs", "Error");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

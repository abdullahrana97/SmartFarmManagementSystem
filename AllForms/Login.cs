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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string role = rbadmin.Checked ? "Admin" : "Farmer";
            if (checkinputs())
            {
                using(MySqlConnection con = DataBaseHelper.getconnection())
                {
                    try
                    {
                        string query = $"Select * from user where username = @u AND password= @p AND role = @r";
                        
                        MySqlCommand cmd = new MySqlCommand(query,con);

                        cmd.Parameters.AddWithValue("@u", txtusername.Text);
                        cmd.Parameters.AddWithValue("@p", txtpassword.Text);
                        cmd.Parameters.AddWithValue("@r", role);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {

                            // saving these so i can use it in Future for assigning farm to partiular user
                            LoginInfo.userid = Convert.ToInt32(reader["userid"]);
                            LoginInfo.username = reader["username"].ToString();
                            LoginInfo.password = reader["Password"].ToString();
                            LoginInfo.role = reader["Role"].ToString();


                          MainForm main = new MainForm();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            txtpassword.Clear();
                            txtpassword.Focus();
                        }
                    }

                    catch(Exception ex)
                    {
                        MessageBox.Show("Connection Error!", ex.Message);
                    }
                }
            }
        }


        public bool checkinputs()
        {
            errorprovider.SetError(txtusername, "");
            errorprovider.SetError(txtpassword, "");
            errorprovider.SetError(lblrole, "");

            bool isValid = true;

            if (string.IsNullOrEmpty(txtusername.Text))
            {
                errorprovider.SetError(txtusername, "Username is Required!");
                isValid = false;
            }

            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                errorprovider.SetError(txtpassword, "Password is Required!");
                isValid = false;
            }

            if (!rbadmin.Checked && !rbuser.Checked)
            {
                errorprovider.SetError(lblrole, "Select a Role");
                isValid = false;
            }

            return isValid;
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }
    }
}

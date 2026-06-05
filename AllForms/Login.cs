using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using SmartFarmManagementSystem.AllClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
           

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
            errorProvider.Clear();
            lblerror.Text = "";

            if (string.IsNullOrWhiteSpace(txtusername.Text))
            {
                errorProvider.SetError(txtusername, "Required");
                lblerror.Text = "⚠ Username is required.";
                txtusername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                errorProvider.SetError(txtpassword, "Required");
                lblerror.Text = "⚠ Password is required.";
                txtpassword.Focus();
                return;
            }

            if (!rbadmin.Checked && !rbuser.Checked)
            {
                lblerror.Text = "⚠ Please select a role.";
                return;
            }

            string role = rbadmin.Checked ? "Admin" : "Farmer";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {

                    // first check if username exists
                    MySqlCommand cmdUser = new MySqlCommand(
                        "SELECT * FROM user WHERE Username=@u", con);
                    cmdUser.Parameters.AddWithValue("@u", txtusername.Text);
                    MySqlDataReader readerUser = cmdUser.ExecuteReader();

                    if (!readerUser.Read())
                    {
                        readerUser.Close();
                        errorProvider.SetError(txtusername, "Not found");
                        lblerror.Text = "⚠ Username does not exist.";
                        MessageBox.Show("Username does not exist. Please check your username.",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtusername.Focus();
                        return;
                    }

                    // username exists now check password
                    string dbPassword = readerUser["Password"].ToString();
                    string dbRole = readerUser["Role"].ToString();
                    readerUser.Close();

                    if (dbPassword != txtpassword.Text)
                    {
                        errorProvider.SetError(txtpassword, "Wrong");
                        lblerror.Text = "⚠ Incorrect password.";
                        MessageBox.Show("Incorrect password. Please try again.",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtpassword.Clear();
                        txtpassword.Focus();
                        return;
                    }

                    if (dbRole != role)
                    {
                        lblerror.Text = "⚠ Role does not match.";
                        MessageBox.Show("You selected " + role + " but your account role is " + dbRole + ".",
                            "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // all correct — login success
                    MySqlCommand cmdFull = new MySqlCommand(
                        "SELECT * FROM user WHERE Username=@u AND Password=@p AND Role=@r", con);
                    cmdFull.Parameters.AddWithValue("@u", txtusername.Text);
                    cmdFull.Parameters.AddWithValue("@p", txtpassword.Text);
                    cmdFull.Parameters.AddWithValue("@r", role);
                    MySqlDataReader reader = cmdFull.ExecuteReader();

                    if (reader.Read())
                    {
                        LoginInfo.userid = Convert.ToInt32(reader["UserID"]);
                        LoginInfo.username = reader["Username"].ToString();
                        LoginInfo.password = reader["Password"].ToString();
                        LoginInfo.role = reader["Role"].ToString();

                        MainForm main = new MainForm();
                        main.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    lblerror.Text = "⚠ Connection error: " + ex.Message;
                    MessageBox.Show("Connection error: " + ex.Message);
                }
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signup = new SignUp();
            signup.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtusername, "");
            lblerror.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtpassword, "");
            lblerror.Text = "";
        }
    }
}

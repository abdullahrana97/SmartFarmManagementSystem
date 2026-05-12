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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
          
            LoadCounts();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void lblfarmcount_Click(object sender, EventArgs e)
        {
            lblfarmcount.ForeColor = Color.FromArgb(34, 139, 34);
        }

        private void lblplantationcount_Click(object sender, EventArgs e)
        {
            lblplantationcount.ForeColor = Color.FromArgb(34, 139, 34);
        }

        private void lblpendingtasks_Click(object sender, EventArgs e)
        {
            lblpendingtasks.ForeColor = Color.FromArgb(34, 139, 34);
        }

        private void lblworkers_Click(object sender, EventArgs e)
        {
            lblworkers.ForeColor = Color.FromArgb(34, 139, 34);
        }


        private void LoadCounts()
        {
            using (MySqlConnection conn = DataBaseHelper.getconnection())
            {
               
                // 2. Check if the connection actually opened (it won't be null if successful)
                if (conn != null)
                {

                    try
                    {
                        // Total Farms
                        MySqlCommand cmd1 = new MySqlCommand("SELECT COUNT(*) FROM farm", conn);
                        lblfarmcount.Text = cmd1.ExecuteScalar().ToString();

                        // Total Plantations
                        MySqlCommand cmd2 = new MySqlCommand("SELECT COUNT(*) FROM plantation", conn);
                        lblplantationcount.Text = cmd2.ExecuteScalar().ToString();

                        // Pending Tasks
                        MySqlCommand cmd3 = new MySqlCommand("SELECT COUNT(*) FROM task WHERE Status like '%Pending%'", conn);
                        lblpendingtasks.Text = cmd3.ExecuteScalar().ToString();

                        // Total Workers
                        MySqlCommand cmd4 = new MySqlCommand("SELECT COUNT(*) FROM worker", conn);
                        lblworkers.Text = cmd4.ExecuteScalar().ToString();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading dashboard: " + ex.Message);
                    }
                }
            }
        }
    }
}

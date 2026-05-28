using SmartFarmManagementSystem.AllForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem
{
    public partial class MainForm : Form
    {


        public static MainForm Instance;
        public MainForm()

        {
            InitializeComponent();
            Instance = this;

            
        }


        public static void LoadForm(Form childForm)
        {
            if (Instance == null)
            {
                MessageBox.Show("MainForm instance is null");
                return;
            }

            if (Instance.mainpanel == null)
            {
                MessageBox.Show("Main panel is null");
                return;
            }

            // Clear existing controls to avoid stacking forms on top of each other
            Panel panel = Instance.mainpanel;

            panel.Controls.Clear();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel.Controls.Add(childForm);
            childForm.Show();

        }

        private void farmFieldsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadForm(new DashBoard());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(34, 139, 34);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(144, 238, 144);
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            btndashboard.BackColor = Color.FromArgb(34, 139, 34);
            LoadForm(new DashBoard());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btnfarmandfields.BackColor = Color.FromArgb(34, 139, 34);
           LoadForm(new FarmField());
        }

        private void btnPlantation_Click(object sender, EventArgs e)
        {
            btnPlantation.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new Plantation());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnworkers.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new WorkerTask());
        }

        private void btnfertilizer_Click(object sender, EventArgs e)
        {
            btnfertilizer.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new Fertilizers());
        }

        private void btnsales_Click(object sender, EventArgs e)
        {
            btnbuyer.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new Buyer());
        }

        private void btnpayment_Click(object sender, EventArgs e)
        {
            btnharvestandsales.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new Harvest___Sales());
        }

        private void btnreports_Click(object sender, EventArgs e)
        {
            btnpayments.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new Payment());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Logout ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginInfo.userid = -1;
                LoginInfo.role = "";
                LoginInfo.username = "";
                this.Hide();
                Login login = new Login();
                login.Show();
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Exit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginInfo.userid = -1;
                LoginInfo.role = "";
                LoginInfo.username = "";
                Application.Exit();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            btnreports.BackColor = Color.FromArgb(34, 139, 34);
            MainForm.LoadForm(new AllReports());

        }
    }
}

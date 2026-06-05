using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartFarmManagementSystem.AllForms
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }


        private void LoadTableFilterItems()
        {
            cmbTableFilter.Items.Clear();
            cmbTableFilter.Items.Add("All Tables");
            cmbTableFilter.Items.Add("farm");
            cmbTableFilter.Items.Add("field");
            cmbTableFilter.Items.Add("plantation");
            cmbTableFilter.Items.Add("worker");
            cmbTableFilter.Items.Add("task");
            cmbTableFilter.Items.Add("sale");
        }

        private void LoadActFilterItems()
        {
            cmbActionType.Items.Clear();
            cmbActionType.Items.Add("All");
            cmbActionType.Items.Add("Insert");
            cmbActionType.Items.Add("Delete");
        }

        private void LoadLogs()
        {
            string actionFilter = cmbActionType.Text;
            string tableFilter = cmbTableFilter.Text;

            string query = "SELECT ActionType, TableName, Message, CreatedAt FROM log WHERE 1=1";

            if (actionFilter != "All")
                query += " AND ActionType = '" + actionFilter + "'";

            if (tableFilter != "All Tables")
                query += " AND TableName = '" + tableFilter + "'";

            query += " ORDER BY CreatedAt DESC";

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    dgvlogs.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            LoadActFilterItems();
            LoadTableFilterItems();
            LoadLogs();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }
    }
}

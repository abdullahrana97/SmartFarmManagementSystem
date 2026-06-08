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
            cmbTableFilter.Items.Add("buyer");     
            cmbTableFilter.Items.Add("harvest");   
            cmbTableFilter.Items.Add("fertilizerapplication"); 
            cmbTableFilter.Items.Add("fertilizerstock");
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
        // tables that have both INSERT and DELETE logs
        private List<string> bothActionTables = new List<string>
         {
                  "farm"  // has insert trigger + delete trigger
          };

        // tables that only have DELETE logs
        private List<string> deleteOnlyTables = new List<string>
        {
               "field",
                "worker",
                "task",
                "sale",
                "buyer",
                "fertilizerapplication",
                "fertilizerstock",
                "harvest",
                "plantation"
        };

        private void Logs_Load(object sender, EventArgs e)
        {
            LoadActFilterItems();
            LoadTableFilterItems();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void cmbTableFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cmbTableFilter.Text;

            cmbActionType.Items.Clear();
        

            if (selectedTable == "All Tables")
            {
                // show all options
                cmbActionType.Items.Add("INSERT");
                cmbActionType.Items.Add("DELETE");
                lblinfo.Text = ""; 
            }
            else if (bothActionTables.Contains(selectedTable))
            {
                // has both insert and delete logs
                cmbActionType.Items.Add("INSERT");
                cmbActionType.Items.Add("DELETE");
            }
            else if (deleteOnlyTables.Contains(selectedTable))
            {
                // only delete logs exist for this table
                cmbActionType.Items.Add("DELETE");

                // show info to user
                lblinfo.Text = "Only DELETE logs available for " + selectedTable;
                lblinfo.ForeColor = Color.Blue;
            }

            cmbActionType.SelectedIndex = 0;
            LoadLogs();
        }
    }
}

using Microsoft.Reporting.WinForms;
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
    public partial class AllReports : Form
    {
        public AllReports()
        {
            InitializeComponent();
        }


        private void ShowReport(DataTable dt, string datasetName, string rdlcName)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("No data found for selected filters.");
                return;
            }

            ReportViewerForm form = new ReportViewerForm(dt, datasetName, rdlcName);
            MainForm.LoadForm(form);
            
        }

        private void AllReports_Load(object sender, EventArgs e)
        {
            // fill report type dropdown
            cmbreport.Items.Clear();
            cmbreport.Items.Add("Sales Report");
            cmbreport.Items.Add("Harvest Report");
            cmbreport.Items.Add("Plantation Report");
            cmbreport.Items.Add("Worker Task Report");
            cmbreport.Items.Add("Farm Summary Report");
            cmbreport.Items.Add("Field Report");
            cmbreport.Items.Add("Fertilizer Stock Report");
            cmbreport.Items.Add("Buyer Purchase Report");
            cmbreport.Items.Add("Payment Report");
            cmbreport.Items.Add("Farm Expense Report");
            cmbreport.SelectedIndex = 0;
        
    }

        private void btngeneratereport_Click(object sender, EventArgs e)
        {
            string selected = cmbreport.Text;

            if (selected == "Sales Report")
                GenerateSalesReport();
           else if (selected == "Harvest Report")
                GenerateHarvestReport();
             else if (selected == "Plantation Report")
                 GeneratePlantationReport();
            /*  else if (selected == "Worker Task Report")
                 GenerateTaskReport();
             else if (selected == "Farm Summary Report")
                 GenerateFarmSummaryReport();
             else if (selected == "Field Report")
                 GenerateFieldReport();
             else if (selected == "Fertilizer Stock Report")
                 GenerateFertilizerReport();
             else if (selected == "Buyer Purchase Report")
                 GenerateBuyerReport();
             else if (selected == "Payment Report")
                 GeneratePaymentReport();*/
        }


        // ==================== SALES REPORT ====================
        private void GenerateSalesReport()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {

                    // uses SP2 — GetSalesByDateRange
                    MySqlCommand cmd = new MySqlCommand("GetSalesByDateRange", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@fromDate",dtpfromdate.Value.Date);
                    cmd.Parameters.AddWithValue("@toDate", dtptodate.Value.Date);

                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }


            ShowReport(dt, "dsSales", "SalesReport.rdlc");
        }

        // ==================== HARVEST REPORT ====================
        private void GenerateHarvestReport()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    string query;
                    if (LoginInfo.role.ToLower() == "admin")
                        query = @"SELECT h.HarvestID,
                          CONCAT(c.Name,' - ',f.Name) AS PlantationName,
                          c.Name AS CropName,
                          f.Name AS FieldName,
                          fm.Name AS FarmName,
                          h.Quantity,
                          h.HarvestDate
                          FROM harvest h
                          JOIN plantation p ON h.PlantationID = p.PlantationID
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          JOIN farm fm ON f.FarmID = fm.FarmID
                          WHERE h.HarvestDate BETWEEN @f AND @t";
                    else
                        query = @"SELECT h.HarvestID,
                          CONCAT(c.Name,' - ',f.Name) AS PlantationName,
                          c.Name AS CropName,
                          f.Name AS FieldName,
                          fm.Name AS FarmName,
                          h.Quantity,
                          h.HarvestDate
                          FROM harvest h
                          JOIN plantation p ON h.PlantationID = p.PlantationID
                          JOIN crop c ON p.CropID = c.CropID
                          JOIN field f ON p.FieldID = f.FieldID
                          JOIN farm fm ON f.FarmID = fm.FarmID
                          WHERE fm.FarmerID = " + LoginInfo.userid + @"
                          AND h.HarvestDate BETWEEN @f AND @t";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@f", dtpfromdate.Value.Date);
                    cmd.Parameters.AddWithValue("@t", dtptodate.Value.Date);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }
          ShowReport(dt, "dsharvest", "HarvestReport.rdlc");    
        }

        // ==================== PLANTATION REPORT ====================
        private void GeneratePlantationReport()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection con = DataBaseHelper.getconnection())
            {
                try
                {
                    string query;
                    if (LoginInfo.role.ToLower() == "admin")
                        query = "SELECT * FROM vw_PlantationDetails";
                    else
                        query = "SELECT * FROM vw_PlantationDetails WHERE FarmerID = "+ LoginInfo.userid;

                    MySqlDataAdapter adp = new MySqlDataAdapter(query, con);
                    adp.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return;
                }
            }

         ShowReport(dt, "dsplantation", "PlantationReport.rdlc");
        } 

    }
}

using Microsoft.Reporting.WinForms;
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
    public partial class ReportViewerForm : Form
    {
        private DataTable reportData;
        private string datasetName;
        private string rdlcName;

        public ReportViewerForm(DataTable dt, string datasetName, string rdlcName)
        {
            InitializeComponent();
            this.reportData = dt;
            this.datasetName = datasetName;
            this.rdlcName = rdlcName;
        }

        private void ReportViewerForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource(datasetName, reportData);
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "SmartFarmManagementSystem." + rdlcName;
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();


        }

        private void btngeneratereport_Click(object sender, EventArgs e)
        {
            MainForm.LoadForm(new AllReports());
        }
    }
}

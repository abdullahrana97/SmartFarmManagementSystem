namespace SmartFarmManagementSystem.AllForms
{
    partial class ReportViewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btngeneratereport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1443, 950);
            this.reportViewer1.TabIndex = 0;
            // 
            // btngeneratereport
            // 
            this.btngeneratereport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btngeneratereport.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratereport.ForeColor = System.Drawing.Color.White;
            this.btngeneratereport.Location = new System.Drawing.Point(12, 875);
            this.btngeneratereport.Name = "btngeneratereport";
            this.btngeneratereport.Size = new System.Drawing.Size(207, 75);
            this.btngeneratereport.TabIndex = 26;
            this.btngeneratereport.Text = "Back to Reports";
            this.btngeneratereport.UseVisualStyleBackColor = false;
            this.btngeneratereport.Click += new System.EventHandler(this.btngeneratereport_Click);
            // 
            // ReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 950);
            this.Controls.Add(this.btngeneratereport);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportViewerForm";
            this.Text = "ReportViewerForm";
            this.Load += new System.EventHandler(this.ReportViewerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btngeneratereport;
    }
}
namespace SmartFarmManagementSystem.AllForms
{
    partial class AllReports
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtptodate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpfromdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbreport = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btngeneratereport = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.dtptodate);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpfromdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbreport);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(248, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 464);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report Generation";
            // 
            // dtptodate
            // 
            this.dtptodate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtptodate.Location = new System.Drawing.Point(426, 306);
            this.dtptodate.Name = "dtptodate";
            this.dtptodate.Size = new System.Drawing.Size(200, 29);
            this.dtptodate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "To Date";
            // 
            // dtpfromdate
            // 
            this.dtpfromdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfromdate.Location = new System.Drawing.Point(36, 306);
            this.dtpfromdate.Name = "dtpfromdate";
            this.dtpfromdate.Size = new System.Drawing.Size(200, 29);
            this.dtpfromdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "From Date";
            // 
            // cmbreport
            // 
            this.cmbreport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbreport.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbreport.FormattingEnabled = true;
            this.cmbreport.Location = new System.Drawing.Point(226, 134);
            this.cmbreport.Name = "cmbreport";
            this.cmbreport.Size = new System.Drawing.Size(199, 29);
            this.cmbreport.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select Report";
            // 
            // btngeneratereport
            // 
            this.btngeneratereport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btngeneratereport.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratereport.ForeColor = System.Drawing.Color.White;
            this.btngeneratereport.Location = new System.Drawing.Point(762, 658);
            this.btngeneratereport.Name = "btngeneratereport";
            this.btngeneratereport.Size = new System.Drawing.Size(207, 75);
            this.btngeneratereport.TabIndex = 25;
            this.btngeneratereport.Text = "Generate Report";
            this.btngeneratereport.UseVisualStyleBackColor = false;
            this.btngeneratereport.Click += new System.EventHandler(this.btngeneratereport_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.White;
            this.btnclear.Location = new System.Drawing.Point(508, 658);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(207, 75);
            this.btnclear.TabIndex = 26;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1225, 905);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btngeneratereport);
            this.Controls.Add(this.groupBox2);
            this.Name = "AllReports";
            this.Text = "AllReports";
            this.Load += new System.EventHandler(this.AllReports_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpfromdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbreport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtptodate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngeneratereport;
        private System.Windows.Forms.Button btnclear;
    }
}
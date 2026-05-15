namespace SmartFarmManagementSystem.AllForms
{
    partial class Plantation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblexpecteddate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpplantationdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcrops = new System.Windows.Forms.ComboBox();
            this.cmbfields = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvplantations = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplantations)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.lblexpecteddate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpplantationdate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbcrops);
            this.groupBox1.Controls.Add(this.cmbfields);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(275, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Let\'s Plant it";
            // 
            // lblexpecteddate
            // 
            this.lblexpecteddate.AutoSize = true;
            this.lblexpecteddate.BackColor = System.Drawing.SystemColors.Window;
            this.lblexpecteddate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblexpecteddate.Location = new System.Drawing.Point(385, 322);
            this.lblexpecteddate.Name = "lblexpecteddate";
            this.lblexpecteddate.Size = new System.Drawing.Size(173, 28);
            this.lblexpecteddate.TabIndex = 7;
            this.lblexpecteddate.Text = "\"Auto Calculated\"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Expected Harvest Date";
            // 
            // dtpplantationdate
            // 
            this.dtpplantationdate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpplantationdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpplantationdate.Location = new System.Drawing.Point(32, 321);
            this.dtpplantationdate.Name = "dtpplantationdate";
            this.dtpplantationdate.Size = new System.Drawing.Size(200, 29);
            this.dtpplantationdate.TabIndex = 5;
            this.dtpplantationdate.ValueChanged += new System.EventHandler(this.dtpplantationdate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Plantation Date";
            // 
            // cmbcrops
            // 
            this.cmbcrops.FormattingEnabled = true;
            this.cmbcrops.Location = new System.Drawing.Point(32, 205);
            this.cmbcrops.MaxDropDownItems = 100;
            this.cmbcrops.Name = "cmbcrops";
            this.cmbcrops.Size = new System.Drawing.Size(167, 36);
            this.cmbcrops.TabIndex = 3;
            // 
            // cmbfields
            // 
            this.cmbfields.FormattingEnabled = true;
            this.cmbfields.Location = new System.Drawing.Point(32, 89);
            this.cmbfields.MaxDropDownItems = 100;
            this.cmbfields.Name = "cmbfields";
            this.cmbfields.Size = new System.Drawing.Size(167, 36);
            this.cmbfields.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Crop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Your Field";
            // 
            // dgvplantations
            // 
            this.dgvplantations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvplantations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplantations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvplantations.Location = new System.Drawing.Point(0, 738);
            this.dgvplantations.Name = "dgvplantations";
            this.dgvplantations.RowHeadersWidth = 62;
            this.dgvplantations.RowTemplate.Height = 28;
            this.dgvplantations.Size = new System.Drawing.Size(1225, 166);
            this.dgvplantations.TabIndex = 11;
            this.dgvplantations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplantations_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(549, 598);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 71);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(764, 596);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 75);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(1000, 596);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(182, 75);
            this.btnsave.TabIndex = 8;
            this.btnsave.Text = "Save / Update";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Plantation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1225, 904);
            this.Controls.Add(this.dgvplantations);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox1);
            this.Name = "Plantation";
            this.Text = "Plantation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Plantation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplantations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbfields;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcrops;
        private System.Windows.Forms.DateTimePicker dtpplantationdate;
        private System.Windows.Forms.DataGridView dgvplantations;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblexpecteddate;
        private System.Windows.Forms.Label label4;
    }
}
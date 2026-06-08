namespace SmartFarmManagementSystem.AllForms
{
    partial class FarmField
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvfarm = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbfarmer = new System.Windows.Forms.ComboBox();
            this.lblfarmer = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtfarmname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvfields = new System.Windows.Forms.DataGridView();
            this.bttndelete = new System.Windows.Forms.Button();
            this.bttnClear = new System.Windows.Forms.Button();
            this.btnsaveupdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbsoiltypes = new System.Windows.Forms.ComboBox();
            this.cmbfarms = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfieldname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfarm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfields)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 961);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dgvfarm);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.btnclear);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1238, 916);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Farm ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvfarm
            // 
            this.dgvfarm.AllowUserToAddRows = false;
            this.dgvfarm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfarm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfarm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvfarm.Location = new System.Drawing.Point(3, 704);
            this.dgvfarm.Name = "dgvfarm";
            this.dgvfarm.RowHeadersWidth = 62;
            this.dgvfarm.RowTemplate.Height = 28;
            this.dgvfarm.Size = new System.Drawing.Size(1230, 207);
            this.dgvfarm.TabIndex = 7;
            this.dgvfarm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfarm_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(539, 585);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 71);
            this.btndelete.TabIndex = 6;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(754, 581);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 75);
            this.btnclear.TabIndex = 5;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(983, 581);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(182, 75);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save / Update";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cmbfarmer);
            this.groupBox1.Controls.Add(this.lblfarmer);
            this.groupBox1.Controls.Add(this.cmbstatus);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtfarmname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(275, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 464);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farm Details";
            // 
            // cmbfarmer
            // 
            this.cmbfarmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfarmer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbfarmer.FormattingEnabled = true;
            this.cmbfarmer.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbfarmer.Location = new System.Drawing.Point(427, 104);
            this.cmbfarmer.Name = "cmbfarmer";
            this.cmbfarmer.Size = new System.Drawing.Size(236, 33);
            this.cmbfarmer.TabIndex = 7;
            // 
            // lblfarmer
            // 
            this.lblfarmer.AutoSize = true;
            this.lblfarmer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfarmer.Location = new System.Drawing.Point(422, 54);
            this.lblfarmer.Name = "lblfarmer";
            this.lblfarmer.Size = new System.Drawing.Size(153, 25);
            this.lblfarmer.TabIndex = 6;
            this.lblfarmer.Text = "Assign To Farmer";
            this.lblfarmer.UseMnemonic = false;
            // 
            // cmbstatus
            // 
            this.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbstatus.Location = new System.Drawing.Point(40, 334);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(236, 33);
            this.cmbstatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            this.label3.UseMnemonic = false;
            // 
            // txtlocation
            // 
            this.txtlocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtlocation.Location = new System.Drawing.Point(40, 212);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(236, 31);
            this.txtlocation.TabIndex = 3;
            this.txtlocation.TextChanged += new System.EventHandler(this.txtlocation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Location";
            this.label2.UseMnemonic = false;
            // 
            // txtfarmname
            // 
            this.txtfarmname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfarmname.Location = new System.Drawing.Point(40, 104);
            this.txtfarmname.Name = "txtfarmname";
            this.txtfarmname.Size = new System.Drawing.Size(236, 31);
            this.txtfarmname.TabIndex = 1;
            this.txtfarmname.TextChanged += new System.EventHandler(this.txtfarmname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Farm Name";
            this.label1.UseMnemonic = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.dgvfields);
            this.tabPage2.Controls.Add(this.bttndelete);
            this.tabPage2.Controls.Add(this.bttnClear);
            this.tabPage2.Controls.Add(this.btnsaveupdate);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1238, 916);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Field";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvfields
            // 
            this.dgvfields.AllowUserToAddRows = false;
            this.dgvfields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfields.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvfields.Location = new System.Drawing.Point(3, 728);
            this.dgvfields.Name = "dgvfields";
            this.dgvfields.RowHeadersWidth = 62;
            this.dgvfields.RowTemplate.Height = 28;
            this.dgvfields.Size = new System.Drawing.Size(1230, 183);
            this.dgvfields.TabIndex = 10;
            this.dgvfields.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfields_CellClick);
            // 
            // bttndelete
            // 
            this.bttndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttndelete.Location = new System.Drawing.Point(509, 613);
            this.bttndelete.Name = "bttndelete";
            this.bttndelete.Size = new System.Drawing.Size(142, 71);
            this.bttndelete.TabIndex = 9;
            this.bttndelete.Text = "Delete";
            this.bttndelete.UseVisualStyleBackColor = false;
            this.bttndelete.Click += new System.EventHandler(this.bttndelete_Click);
            // 
            // bttnClear
            // 
            this.bttnClear.BackColor = System.Drawing.Color.Plum;
            this.bttnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnClear.Location = new System.Drawing.Point(726, 611);
            this.bttnClear.Name = "bttnClear";
            this.bttnClear.Size = new System.Drawing.Size(162, 75);
            this.bttnClear.TabIndex = 8;
            this.bttnClear.Text = "Clear";
            this.bttnClear.UseVisualStyleBackColor = false;
            this.bttnClear.Click += new System.EventHandler(this.bttnClear_Click);
            // 
            // btnsaveupdate
            // 
            this.btnsaveupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsaveupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsaveupdate.Location = new System.Drawing.Point(945, 611);
            this.btnsaveupdate.Name = "btnsaveupdate";
            this.btnsaveupdate.Size = new System.Drawing.Size(182, 75);
            this.btnsaveupdate.TabIndex = 7;
            this.btnsaveupdate.Text = "Save / Update";
            this.btnsaveupdate.UseVisualStyleBackColor = false;
            this.btnsaveupdate.Click += new System.EventHandler(this.btnsaveupdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.cmbsoiltypes);
            this.groupBox2.Controls.Add(this.cmbfarms);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtarea);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtfieldname);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(275, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 464);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Field Details";
            // 
            // cmbsoiltypes
            // 
            this.cmbsoiltypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsoiltypes.FormattingEnabled = true;
            this.cmbsoiltypes.Location = new System.Drawing.Point(308, 325);
            this.cmbsoiltypes.Name = "cmbsoiltypes";
            this.cmbsoiltypes.Size = new System.Drawing.Size(189, 33);
            this.cmbsoiltypes.TabIndex = 8;
            // 
            // cmbfarms
            // 
            this.cmbfarms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfarms.FormattingEnabled = true;
            this.cmbfarms.Location = new System.Drawing.Point(32, 325);
            this.cmbfarms.Name = "cmbfarms";
            this.cmbfarms.Size = new System.Drawing.Size(200, 33);
            this.cmbfarms.TabIndex = 7;
            this.cmbfarms.SelectedIndexChanged += new System.EventHandler(this.cmbfarms_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Soil Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Associated Farm";
            // 
            // txtarea
            // 
            this.txtarea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtarea.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarea.Location = new System.Drawing.Point(32, 200);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(268, 31);
            this.txtarea.TabIndex = 3;
            this.txtarea.TextChanged += new System.EventHandler(this.txtarea_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Area (in Acre)";
            // 
            // txtfieldname
            // 
            this.txtfieldname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfieldname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfieldname.Location = new System.Drawing.Point(32, 90);
            this.txtfieldname.Name = "txtfieldname";
            this.txtfieldname.Size = new System.Drawing.Size(268, 31);
            this.txtfieldname.TabIndex = 1;
            this.txtfieldname.TextChanged += new System.EventHandler(this.txtfieldname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Field Name";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FarmField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1246, 961);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FarmField";
            this.Text = "FarmField";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfarm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfields)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfarmname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dgvfarm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtfieldname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.ComboBox cmbsoiltypes;
        private System.Windows.Forms.ComboBox cmbfarms;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bttndelete;
        private System.Windows.Forms.Button bttnClear;
        private System.Windows.Forms.Button btnsaveupdate;
        private System.Windows.Forms.DataGridView dgvfields;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbfarmer;
        private System.Windows.Forms.Label lblfarmer;
    }
}
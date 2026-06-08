namespace SmartFarmManagementSystem.AllForms
{
    partial class FertilizerManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Fertilizer = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvfertilizers = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.butdelete = new System.Windows.Forms.Button();
            this.butclear = new System.Windows.Forms.Button();
            this.butsave = new System.Windows.Forms.Button();
            this.dgvfertilizerstock = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpstockdate = new System.Windows.Forms.DateTimePicker();
            this.txtquantityadded = new System.Windows.Forms.TextBox();
            this.cmbfertilizer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttdelete = new System.Windows.Forms.Button();
            this.buttclear = new System.Windows.Forms.Button();
            this.buttsave = new System.Windows.Forms.Button();
            this.dgvapplication = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtquantityused = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbworker = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbfertilizername = new System.Windows.Forms.ComboBox();
            this.dtpapplicationstart = new System.Windows.Forms.DateTimePicker();
            this.cmbfieldname = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Fertilizer.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfertilizers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfertilizerstock)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvapplication)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fertilizer
            // 
            this.Fertilizer.Controls.Add(this.tabPage1);
            this.Fertilizer.Controls.Add(this.tabPage2);
            this.Fertilizer.Controls.Add(this.tabPage3);
            this.Fertilizer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Fertilizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fertilizer.Location = new System.Drawing.Point(0, 0);
            this.Fertilizer.Name = "Fertilizer";
            this.Fertilizer.SelectedIndex = 0;
            this.Fertilizer.Size = new System.Drawing.Size(1225, 905);
            this.Fertilizer.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvfertilizers);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnclear);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1217, 870);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fertilizer";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dgvfertilizers
            // 
            this.dgvfertilizers.AllowUserToAddRows = false;
            this.dgvfertilizers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfertilizers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvfertilizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvfertilizers.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvfertilizers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvfertilizers.Location = new System.Drawing.Point(3, 698);
            this.dgvfertilizers.Name = "dgvfertilizers";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvfertilizers.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvfertilizers.RowHeadersWidth = 62;
            this.dgvfertilizers.RowTemplate.Height = 28;
            this.dgvfertilizers.Size = new System.Drawing.Size(1211, 169);
            this.dgvfertilizers.TabIndex = 22;
            this.dgvfertilizers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfertilizers_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(525, 581);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 75);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.cmbtype);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(254, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 439);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fertilizers";
            // 
            // cmbtype
            // 
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Location = new System.Drawing.Point(36, 279);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(195, 29);
            this.cmbtype.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // txtfname
            // 
            this.txtfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfname.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(36, 135);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(195, 29);
            this.txtfname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(731, 579);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 79);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(950, 579);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(182, 79);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save / Update";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.butdelete);
            this.tabPage2.Controls.Add(this.butclear);
            this.tabPage2.Controls.Add(this.butsave);
            this.tabPage2.Controls.Add(this.dgvfertilizerstock);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1217, 870);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // butdelete
            // 
            this.butdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.butdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.Location = new System.Drawing.Point(488, 554);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(142, 75);
            this.butdelete.TabIndex = 23;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = false;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butclear
            // 
            this.butclear.BackColor = System.Drawing.Color.Plum;
            this.butclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclear.Location = new System.Drawing.Point(695, 550);
            this.butclear.Name = "butclear";
            this.butclear.Size = new System.Drawing.Size(162, 79);
            this.butclear.TabIndex = 22;
            this.butclear.Text = "Clear";
            this.butclear.UseVisualStyleBackColor = false;
            this.butclear.Click += new System.EventHandler(this.butclear_Click);
            // 
            // butsave
            // 
            this.butsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butsave.Location = new System.Drawing.Point(922, 550);
            this.butsave.Name = "butsave";
            this.butsave.Size = new System.Drawing.Size(182, 79);
            this.butsave.TabIndex = 21;
            this.butsave.Text = "Save / Update";
            this.butsave.UseVisualStyleBackColor = false;
            this.butsave.Click += new System.EventHandler(this.butsave_Click);
            // 
            // dgvfertilizerstock
            // 
            this.dgvfertilizerstock.AllowUserToAddRows = false;
            this.dgvfertilizerstock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvfertilizerstock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfertilizerstock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvfertilizerstock.Location = new System.Drawing.Point(3, 695);
            this.dgvfertilizerstock.Name = "dgvfertilizerstock";
            this.dgvfertilizerstock.RowHeadersWidth = 62;
            this.dgvfertilizerstock.RowTemplate.Height = 28;
            this.dgvfertilizerstock.Size = new System.Drawing.Size(1211, 172);
            this.dgvfertilizerstock.TabIndex = 20;
            this.dgvfertilizerstock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfertilizerstock_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.dtpstockdate);
            this.groupBox2.Controls.Add(this.txtquantityadded);
            this.groupBox2.Controls.Add(this.cmbfertilizer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(242, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(655, 418);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Details";
            // 
            // dtpstockdate
            // 
            this.dtpstockdate.CalendarFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstockdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstockdate.Location = new System.Drawing.Point(31, 312);
            this.dtpstockdate.Name = "dtpstockdate";
            this.dtpstockdate.Size = new System.Drawing.Size(200, 29);
            this.dtpstockdate.TabIndex = 7;
            // 
            // txtquantityadded
            // 
            this.txtquantityadded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantityadded.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantityadded.Location = new System.Drawing.Point(36, 207);
            this.txtquantityadded.Name = "txtquantityadded";
            this.txtquantityadded.Size = new System.Drawing.Size(195, 29);
            this.txtquantityadded.TabIndex = 6;
            // 
            // cmbfertilizer
            // 
            this.cmbfertilizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfertilizer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfertilizer.FormattingEnabled = true;
            this.cmbfertilizer.Location = new System.Drawing.Point(36, 91);
            this.cmbfertilizer.Name = "cmbfertilizer";
            this.cmbfertilizer.Size = new System.Drawing.Size(195, 29);
            this.cmbfertilizer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stock Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quantity To Add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fertilizer Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttdelete);
            this.tabPage3.Controls.Add(this.buttclear);
            this.tabPage3.Controls.Add(this.buttsave);
            this.tabPage3.Controls.Add(this.dgvapplication);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1217, 870);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fertliizer Application";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttdelete
            // 
            this.buttdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttdelete.Location = new System.Drawing.Point(522, 572);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(142, 75);
            this.buttdelete.TabIndex = 28;
            this.buttdelete.Text = "Delete";
            this.buttdelete.UseVisualStyleBackColor = false;
            this.buttdelete.Click += new System.EventHandler(this.buttdelete_Click);
            // 
            // buttclear
            // 
            this.buttclear.BackColor = System.Drawing.Color.Plum;
            this.buttclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttclear.Location = new System.Drawing.Point(735, 568);
            this.buttclear.Name = "buttclear";
            this.buttclear.Size = new System.Drawing.Size(162, 79);
            this.buttclear.TabIndex = 27;
            this.buttclear.Text = "Clear";
            this.buttclear.UseVisualStyleBackColor = false;
            this.buttclear.Click += new System.EventHandler(this.buttclear_Click);
            // 
            // buttsave
            // 
            this.buttsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttsave.Location = new System.Drawing.Point(950, 568);
            this.buttsave.Name = "buttsave";
            this.buttsave.Size = new System.Drawing.Size(182, 79);
            this.buttsave.TabIndex = 26;
            this.buttsave.Text = "Save / Update";
            this.buttsave.UseVisualStyleBackColor = false;
            this.buttsave.Click += new System.EventHandler(this.buttsave_Click);
            // 
            // dgvapplication
            // 
            this.dgvapplication.AllowUserToAddRows = false;
            this.dgvapplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvapplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvapplication.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvapplication.Location = new System.Drawing.Point(3, 695);
            this.dgvapplication.Name = "dgvapplication";
            this.dgvapplication.RowHeadersWidth = 62;
            this.dgvapplication.RowTemplate.Height = 28;
            this.dgvapplication.Size = new System.Drawing.Size(1211, 172);
            this.dgvapplication.TabIndex = 25;
            this.dgvapplication.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvapplication_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.txtquantityused);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbworker);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cmbfertilizername);
            this.groupBox3.Controls.Add(this.dtpapplicationstart);
            this.groupBox3.Controls.Add(this.cmbfieldname);
            this.groupBox3.Controls.Add(this.label);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(247, 87);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(694, 433);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Details";
            // 
            // txtquantityused
            // 
            this.txtquantityused.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantityused.Location = new System.Drawing.Point(415, 209);
            this.txtquantityused.Name = "txtquantityused";
            this.txtquantityused.Size = new System.Drawing.Size(211, 34);
            this.txtquantityused.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(421, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Quantity Used";
            // 
            // cmbworker
            // 
            this.cmbworker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbworker.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbworker.FormattingEnabled = true;
            this.cmbworker.Location = new System.Drawing.Point(31, 324);
            this.cmbworker.Name = "cmbworker";
            this.cmbworker.Size = new System.Drawing.Size(200, 29);
            this.cmbworker.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(31, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Worker Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fertilizer Name";
            // 
            // cmbfertilizername
            // 
            this.cmbfertilizername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfertilizername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfertilizername.FormattingEnabled = true;
            this.cmbfertilizername.Location = new System.Drawing.Point(31, 207);
            this.cmbfertilizername.Name = "cmbfertilizername";
            this.cmbfertilizername.Size = new System.Drawing.Size(200, 29);
            this.cmbfertilizername.TabIndex = 8;
            // 
            // dtpapplicationstart
            // 
            this.dtpapplicationstart.CalendarFont = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpapplicationstart.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpapplicationstart.Location = new System.Drawing.Point(426, 324);
            this.dtpapplicationstart.Name = "dtpapplicationstart";
            this.dtpapplicationstart.Size = new System.Drawing.Size(200, 29);
            this.dtpapplicationstart.TabIndex = 7;
            // 
            // cmbfieldname
            // 
            this.cmbfieldname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfieldname.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfieldname.FormattingEnabled = true;
            this.cmbfieldname.Location = new System.Drawing.Point(36, 91);
            this.cmbfieldname.Name = "cmbfieldname";
            this.cmbfieldname.Size = new System.Drawing.Size(195, 29);
            this.cmbfieldname.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(421, 272);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(196, 25);
            this.label.TabIndex = 4;
            this.label.Text = "Application Start Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Field Name";
            // 
            // FertilizerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 905);
            this.Controls.Add(this.Fertilizer);
            this.Name = "FertilizerManagement";
            this.Text = "FertilizerManagement";
            this.Load += new System.EventHandler(this.FertilizerManagement_Load);
            this.Fertilizer.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfertilizers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfertilizerstock)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvapplication)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Fertilizer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvfertilizers;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butclear;
        private System.Windows.Forms.Button butsave;
        private System.Windows.Forms.DataGridView dgvfertilizerstock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpstockdate;
        private System.Windows.Forms.TextBox txtquantityadded;
        private System.Windows.Forms.ComboBox cmbfertilizer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttdelete;
        private System.Windows.Forms.Button buttclear;
        private System.Windows.Forms.Button buttsave;
        private System.Windows.Forms.DataGridView dgvapplication;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtquantityused;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbworker;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbfertilizername;
        private System.Windows.Forms.DateTimePicker dtpapplicationstart;
        private System.Windows.Forms.ComboBox cmbfieldname;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
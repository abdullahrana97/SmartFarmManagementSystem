namespace SmartFarmManagementSystem.AllForms
{
    partial class Harvest___Sales
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvharvest = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpharvestdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbplantation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtquantityharvested = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.TabPage();
            this.dgvsales = new System.Windows.Forms.DataGridView();
            this.buttdelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbbuyer = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbharvest = new System.Windows.Forms.ComboBox();
            this.dtpsaledate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsplantation = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttclear = new System.Windows.Forms.Button();
            this.buttsave = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvharvest)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.Sales);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1225, 905);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvharvest);
            this.tabPage1.Controls.Add(this.btndelete);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnclear);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1217, 864);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Harvest";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvharvest
            // 
            this.dgvharvest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvharvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvharvest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvharvest.Location = new System.Drawing.Point(3, 697);
            this.dgvharvest.Name = "dgvharvest";
            this.dgvharvest.RowHeadersWidth = 62;
            this.dgvharvest.RowTemplate.Height = 28;
            this.dgvharvest.Size = new System.Drawing.Size(1211, 164);
            this.dgvharvest.TabIndex = 22;
            this.dgvharvest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvharvest_CellClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(511, 556);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(142, 71);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.dtpharvestdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbplantation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtquantityharvested);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(232, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(721, 464);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Harvest";
            // 
            // dtpharvestdate
            // 
            this.dtpharvestdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpharvestdate.Location = new System.Drawing.Point(36, 367);
            this.dtpharvestdate.Name = "dtpharvestdate";
            this.dtpharvestdate.Size = new System.Drawing.Size(200, 29);
            this.dtpharvestdate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Harvest Date";
            // 
            // cmbplantation
            // 
            this.cmbplantation.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbplantation.FormattingEnabled = true;
            this.cmbplantation.Location = new System.Drawing.Point(36, 125);
            this.cmbplantation.Name = "cmbplantation";
            this.cmbplantation.Size = new System.Drawing.Size(195, 29);
            this.cmbplantation.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity Harvested";
            // 
            // txtquantityharvested
            // 
            this.txtquantityharvested.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantityharvested.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantityharvested.Location = new System.Drawing.Point(36, 248);
            this.txtquantityharvested.Name = "txtquantityharvested";
            this.txtquantityharvested.Size = new System.Drawing.Size(195, 29);
            this.txtquantityharvested.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plantation";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(725, 554);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 75);
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
            this.btnsave.Location = new System.Drawing.Point(945, 554);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(182, 75);
            this.btnsave.TabIndex = 19;
            this.btnsave.Text = "Save / Update";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Sales
            // 
            this.Sales.Controls.Add(this.lbltotal);
            this.Sales.Controls.Add(this.dgvsales);
            this.Sales.Controls.Add(this.buttdelete);
            this.Sales.Controls.Add(this.groupBox2);
            this.Sales.Controls.Add(this.buttclear);
            this.Sales.Controls.Add(this.buttsave);
            this.Sales.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.Location = new System.Drawing.Point(4, 37);
            this.Sales.Name = "Sales";
            this.Sales.Padding = new System.Windows.Forms.Padding(3);
            this.Sales.Size = new System.Drawing.Size(1217, 864);
            this.Sales.TabIndex = 1;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // dgvsales
            // 
            this.dgvsales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvsales.Location = new System.Drawing.Point(3, 697);
            this.dgvsales.Name = "dgvsales";
            this.dgvsales.RowHeadersWidth = 62;
            this.dgvsales.RowTemplate.Height = 28;
            this.dgvsales.Size = new System.Drawing.Size(1211, 164);
            this.dgvsales.TabIndex = 27;
            this.dgvsales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsales_CellClick);
            // 
            // buttdelete
            // 
            this.buttdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttdelete.Location = new System.Drawing.Point(521, 585);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(142, 71);
            this.buttdelete.TabIndex = 26;
            this.buttdelete.Text = "Delete";
            this.buttdelete.UseVisualStyleBackColor = false;
            this.buttdelete.Click += new System.EventHandler(this.buttdelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtquantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmbbuyer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbharvest);
            this.groupBox2.Controls.Add(this.dtpsaledate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbsplantation);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(242, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 464);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale Information";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(465, 306);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(190, 34);
            this.txtprice.TabIndex = 14;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtquantity
            // 
            this.txtquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtquantity.Location = new System.Drawing.Point(465, 207);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(190, 34);
            this.txtquantity.TabIndex = 13;
            this.txtquantity.TextChanged += new System.EventHandler(this.txtquantity_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(460, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Price";
            // 
            // cmbbuyer
            // 
            this.cmbbuyer.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbuyer.FormattingEnabled = true;
            this.cmbbuyer.Location = new System.Drawing.Point(36, 312);
            this.cmbbuyer.Name = "cmbbuyer";
            this.cmbbuyer.Size = new System.Drawing.Size(195, 29);
            this.cmbbuyer.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Buyer";
            // 
            // cmbharvest
            // 
            this.cmbharvest.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbharvest.FormattingEnabled = true;
            this.cmbharvest.Location = new System.Drawing.Point(36, 207);
            this.cmbharvest.Name = "cmbharvest";
            this.cmbharvest.Size = new System.Drawing.Size(195, 29);
            this.cmbharvest.TabIndex = 8;
            // 
            // dtpsaledate
            // 
            this.dtpsaledate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpsaledate.Location = new System.Drawing.Point(279, 415);
            this.dtpsaledate.Name = "dtpsaledate";
            this.dtpsaledate.Size = new System.Drawing.Size(200, 29);
            this.dtpsaledate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sale Date";
            // 
            // cmbsplantation
            // 
            this.cmbsplantation.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsplantation.FormattingEnabled = true;
            this.cmbsplantation.Location = new System.Drawing.Point(36, 95);
            this.cmbsplantation.Name = "cmbsplantation";
            this.cmbsplantation.Size = new System.Drawing.Size(195, 29);
            this.cmbsplantation.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = " Harvest";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Plantation";
            // 
            // buttclear
            // 
            this.buttclear.BackColor = System.Drawing.Color.Plum;
            this.buttclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttclear.Location = new System.Drawing.Point(735, 583);
            this.buttclear.Name = "buttclear";
            this.buttclear.Size = new System.Drawing.Size(162, 75);
            this.buttclear.TabIndex = 25;
            this.buttclear.Text = "Clear";
            this.buttclear.UseVisualStyleBackColor = false;
            this.buttclear.Click += new System.EventHandler(this.buttclear_Click);
            // 
            // buttsave
            // 
            this.buttsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttsave.Location = new System.Drawing.Point(955, 583);
            this.buttsave.Name = "buttsave";
            this.buttsave.Size = new System.Drawing.Size(182, 75);
            this.buttsave.TabIndex = 24;
            this.buttsave.Text = "Save / Update";
            this.buttsave.UseVisualStyleBackColor = false;
            this.buttsave.Click += new System.EventHandler(this.buttsave_Click_1);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(237, 609);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(153, 30);
            this.lbltotal.TabIndex = 15;
            this.lbltotal.Text = "Total Amount";
            // 
            // Harvest___Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1225, 905);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Harvest___Sales";
            this.Text = "Harvest___Sales";
            this.Load += new System.EventHandler(this.Harvest___Sales_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvharvest)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Sales.ResumeLayout(false);
            this.Sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Sales;
        private System.Windows.Forms.DataGridView dgvharvest;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbplantation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtquantityharvested;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DateTimePicker dtpharvestdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvsales;
        private System.Windows.Forms.Button buttdelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbharvest;
        private System.Windows.Forms.DateTimePicker dtpsaledate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsplantation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttclear;
        private System.Windows.Forms.Button buttsave;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbbuyer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltotal;
    }
}
namespace SmartFarmManagementSystem.AllForms
{
    partial class Payment
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
            this.dgvpayments = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbmethods = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtppaymentdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsales = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.lblpaymentstatus = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayments)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpayments
            // 
            this.dgvpayments.AllowUserToAddRows = false;
            this.dgvpayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvpayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvpayments.Location = new System.Drawing.Point(0, 741);
            this.dgvpayments.Name = "dgvpayments";
            this.dgvpayments.RowHeadersWidth = 62;
            this.dgvpayments.RowTemplate.Height = 28;
            this.dgvpayments.Size = new System.Drawing.Size(1225, 164);
            this.dgvpayments.TabIndex = 32;
            this.dgvpayments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpayments_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.txtamount);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbmethods);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtppaymentdate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbsales);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(237, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 464);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Information";
            // 
            // txtamount
            // 
            this.txtamount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtamount.Location = new System.Drawing.Point(36, 202);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(190, 34);
            this.txtamount.TabIndex = 13;
            this.txtamount.TextChanged += new System.EventHandler(this.txtamount_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Paying Amount";
            // 
            // cmbmethods
            // 
            this.cmbmethods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmethods.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbmethods.FormattingEnabled = true;
            this.cmbmethods.Location = new System.Drawing.Point(36, 312);
            this.cmbmethods.Name = "cmbmethods";
            this.cmbmethods.Size = new System.Drawing.Size(195, 29);
            this.cmbmethods.TabIndex = 10;
            this.cmbmethods.SelectedIndexChanged += new System.EventHandler(this.cmbmethods_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Payment Method";
            // 
            // dtppaymentdate
            // 
            this.dtppaymentdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtppaymentdate.Location = new System.Drawing.Point(455, 309);
            this.dtppaymentdate.Name = "dtppaymentdate";
            this.dtppaymentdate.Size = new System.Drawing.Size(200, 29);
            this.dtppaymentdate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Payment Date";
            // 
            // cmbsales
            // 
            this.cmbsales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsales.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsales.FormattingEnabled = true;
            this.cmbsales.Location = new System.Drawing.Point(36, 95);
            this.cmbsales.Name = "cmbsales";
            this.cmbsales.Size = new System.Drawing.Size(195, 29);
            this.cmbsales.TabIndex = 5;
            this.cmbsales.SelectedIndexChanged += new System.EventHandler(this.cmbsales_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sale";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Plum;
            this.btnclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(730, 618);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 75);
            this.btnclear.TabIndex = 30;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsave.Location = new System.Drawing.Point(950, 618);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(182, 75);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save / Update";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
            // 
            // lblpaymentstatus
            // 
            this.lblpaymentstatus.AutoSize = true;
            this.lblpaymentstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaymentstatus.Location = new System.Drawing.Point(90, 644);
            this.lblpaymentstatus.Name = "lblpaymentstatus";
            this.lblpaymentstatus.Size = new System.Drawing.Size(140, 25);
            this.lblpaymentstatus.TabIndex = 14;
            this.lblpaymentstatus.Text = "Payment Status";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 905);
            this.Controls.Add(this.lblpaymentstatus);
            this.Controls.Add(this.dgvpayments);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayments)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpayments;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbmethods;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtppaymentdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label lblpaymentstatus;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
namespace SmartFarmManagementSystem.AllForms
{
    partial class Buyer
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
            this.dgvbuyers = new System.Windows.Forms.DataGridView();
            this.buttdelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtphone = new System.Windows.Forms.MaskedTextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttclear = new System.Windows.Forms.Button();
            this.buttsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvbuyers
            // 
            this.dgvbuyers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvbuyers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuyers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvbuyers.Location = new System.Drawing.Point(0, 741);
            this.dgvbuyers.Name = "dgvbuyers";
            this.dgvbuyers.RowHeadersWidth = 62;
            this.dgvbuyers.RowTemplate.Height = 28;
            this.dgvbuyers.Size = new System.Drawing.Size(1225, 164);
            this.dgvbuyers.TabIndex = 32;
            this.dgvbuyers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuyers_CellClick);
            // 
            // buttdelete
            // 
            this.buttdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttdelete.Location = new System.Drawing.Point(526, 623);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(142, 71);
            this.buttdelete.TabIndex = 31;
            this.buttdelete.Text = "Delete";
            this.buttdelete.UseVisualStyleBackColor = false;
            this.buttdelete.Click += new System.EventHandler(this.buttdelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.txtname);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(247, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(721, 464);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buyer Information";
            // 
            // txtphone
            // 
            this.txtphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtphone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(36, 288);
            this.txtphone.Mask = "0000-0000000";
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(195, 31);
            this.txtphone.TabIndex = 14;
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(36, 153);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 34);
            this.txtname.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // buttclear
            // 
            this.buttclear.BackColor = System.Drawing.Color.Plum;
            this.buttclear.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttclear.Location = new System.Drawing.Point(740, 621);
            this.buttclear.Name = "buttclear";
            this.buttclear.Size = new System.Drawing.Size(162, 75);
            this.buttclear.TabIndex = 30;
            this.buttclear.Text = "Clear";
            this.buttclear.UseVisualStyleBackColor = false;
            this.buttclear.Click += new System.EventHandler(this.buttclear_Click);
            // 
            // buttsave
            // 
            this.buttsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttsave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttsave.Location = new System.Drawing.Point(960, 621);
            this.buttsave.Name = "buttsave";
            this.buttsave.Size = new System.Drawing.Size(182, 75);
            this.buttsave.TabIndex = 29;
            this.buttsave.Text = "Save / Update";
            this.buttsave.UseVisualStyleBackColor = false;
            this.buttsave.Click += new System.EventHandler(this.buttsave_Click);
            // 
            // Buyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1225, 905);
            this.Controls.Add(this.dgvbuyers);
            this.Controls.Add(this.buttdelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttclear);
            this.Controls.Add(this.buttsave);
            this.Name = "Buyer";
            this.Text = "Buyer";
            this.Load += new System.EventHandler(this.Buyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvbuyers;
        private System.Windows.Forms.Button buttdelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttclear;
        private System.Windows.Forms.Button buttsave;
        private System.Windows.Forms.MaskedTextBox txtphone;
    }
}
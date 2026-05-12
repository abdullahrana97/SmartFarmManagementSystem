namespace SmartFarmManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnreports = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnfertilizer = new System.Windows.Forms.Button();
            this.btnworkers = new System.Windows.Forms.Button();
            this.btnPlantation = new System.Windows.Forms.Button();
            this.btnfarmandfields = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 71);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Smart Farm Management";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(964, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 12, 15, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(236, 71);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(133, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(52, 15);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.btnreports);
            this.panel2.Controls.Add(this.btnpayment);
            this.panel2.Controls.Add(this.btnsales);
            this.panel2.Controls.Add(this.btnfertilizer);
            this.panel2.Controls.Add(this.btnworkers);
            this.panel2.Controls.Add(this.btnPlantation);
            this.panel2.Controls.Add(this.btnfarmandfields);
            this.panel2.Controls.Add(this.btndashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 677);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 590);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(238, 70);
            this.button3.TabIndex = 8;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnreports
            // 
            this.btnreports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnreports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreports.FlatAppearance.BorderSize = 0;
            this.btnreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreports.ForeColor = System.Drawing.Color.White;
            this.btnreports.Location = new System.Drawing.Point(0, 520);
            this.btnreports.Name = "btnreports";
            this.btnreports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnreports.Size = new System.Drawing.Size(238, 70);
            this.btnreports.TabIndex = 7;
            this.btnreports.Text = "📈 Reports";
            this.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreports.UseVisualStyleBackColor = true;
            this.btnreports.Click += new System.EventHandler(this.btnreports_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpayment.FlatAppearance.BorderSize = 0;
            this.btnpayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.ForeColor = System.Drawing.Color.White;
            this.btnpayment.Location = new System.Drawing.Point(0, 450);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnpayment.Size = new System.Drawing.Size(238, 70);
            this.btnpayment.TabIndex = 6;
            this.btnpayment.Text = "💳 Payments";
            this.btnpayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpayment.UseVisualStyleBackColor = true;
            this.btnpayment.Click += new System.EventHandler(this.btnpayment_Click);
            // 
            // btnsales
            // 
            this.btnsales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsales.ForeColor = System.Drawing.Color.White;
            this.btnsales.Location = new System.Drawing.Point(0, 380);
            this.btnsales.Name = "btnsales";
            this.btnsales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnsales.Size = new System.Drawing.Size(238, 70);
            this.btnsales.TabIndex = 5;
            this.btnsales.Text = "💰 Sales";
            this.btnsales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.UseVisualStyleBackColor = true;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnfertilizer
            // 
            this.btnfertilizer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfertilizer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfertilizer.FlatAppearance.BorderSize = 0;
            this.btnfertilizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfertilizer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfertilizer.ForeColor = System.Drawing.Color.White;
            this.btnfertilizer.Location = new System.Drawing.Point(0, 310);
            this.btnfertilizer.Name = "btnfertilizer";
            this.btnfertilizer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnfertilizer.Size = new System.Drawing.Size(238, 70);
            this.btnfertilizer.TabIndex = 4;
            this.btnfertilizer.Text = "🧪 Fertilizers";
            this.btnfertilizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfertilizer.UseVisualStyleBackColor = true;
            this.btnfertilizer.Click += new System.EventHandler(this.btnfertilizer_Click);
            // 
            // btnworkers
            // 
            this.btnworkers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnworkers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnworkers.FlatAppearance.BorderSize = 0;
            this.btnworkers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnworkers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnworkers.ForeColor = System.Drawing.Color.White;
            this.btnworkers.Location = new System.Drawing.Point(0, 240);
            this.btnworkers.Name = "btnworkers";
            this.btnworkers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnworkers.Size = new System.Drawing.Size(238, 70);
            this.btnworkers.TabIndex = 3;
            this.btnworkers.Text = "👨‍🌾  Workers && Tasks";
            this.btnworkers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnworkers.UseVisualStyleBackColor = true;
            this.btnworkers.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPlantation
            // 
            this.btnPlantation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlantation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlantation.FlatAppearance.BorderSize = 0;
            this.btnPlantation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlantation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlantation.ForeColor = System.Drawing.Color.White;
            this.btnPlantation.Location = new System.Drawing.Point(0, 170);
            this.btnPlantation.Name = "btnPlantation";
            this.btnPlantation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPlantation.Size = new System.Drawing.Size(238, 70);
            this.btnPlantation.TabIndex = 2;
            this.btnPlantation.Text = "🌱  Plantation";
            this.btnPlantation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlantation.UseVisualStyleBackColor = true;
            this.btnPlantation.Click += new System.EventHandler(this.btnPlantation_Click);
            // 
            // btnfarmandfields
            // 
            this.btnfarmandfields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfarmandfields.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnfarmandfields.FlatAppearance.BorderSize = 0;
            this.btnfarmandfields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfarmandfields.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfarmandfields.ForeColor = System.Drawing.Color.White;
            this.btnfarmandfields.Location = new System.Drawing.Point(0, 100);
            this.btnfarmandfields.Name = "btnfarmandfields";
            this.btnfarmandfields.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnfarmandfields.Size = new System.Drawing.Size(238, 70);
            this.btnfarmandfields.TabIndex = 1;
            this.btnfarmandfields.Text = "🌾  Farm & Fields";
            this.btnfarmandfields.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnfarmandfields.UseVisualStyleBackColor = true;
            this.btnfarmandfields.Click += new System.EventHandler(this.button4_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(0, 0);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btndashboard.Size = new System.Drawing.Size(238, 100);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "📊  Dashboard";
            this.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.UseVisualStyleBackColor = true;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(238, 71);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(962, 677);
            this.mainpanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 748);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Smart Farm Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnfarmandfields;
        private System.Windows.Forms.Button btnPlantation;
        private System.Windows.Forms.Button btnworkers;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Button btnfertilizer;
        private System.Windows.Forms.Button btnreports;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel mainpanel;
    }
}


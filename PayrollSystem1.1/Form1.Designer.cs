namespace PayrollSystem1._1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblActive_home = new System.Windows.Forms.Label();
            this.lblActive_report = new System.Windows.Forms.Label();
            this.lblActive_user = new System.Windows.Forms.Label();
            this.lblActive_payroll = new System.Windows.Forms.Label();
            this.lblActive_employee = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPayrioll = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tsClose = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblActive_home);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.lblActive_report);
            this.panel1.Controls.Add(this.lblActive_user);
            this.panel1.Controls.Add(this.lblActive_payroll);
            this.panel1.Controls.Add(this.lblActive_employee);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnPayrioll);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 772);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblActive_home
            // 
            this.lblActive_home.BackColor = System.Drawing.Color.Green;
            this.lblActive_home.Location = new System.Drawing.Point(1, 274);
            this.lblActive_home.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive_home.Name = "lblActive_home";
            this.lblActive_home.Size = new System.Drawing.Size(22, 57);
            this.lblActive_home.TabIndex = 10;
            // 
            // lblActive_report
            // 
            this.lblActive_report.BackColor = System.Drawing.Color.Green;
            this.lblActive_report.Location = new System.Drawing.Point(1, 500);
            this.lblActive_report.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive_report.Name = "lblActive_report";
            this.lblActive_report.Size = new System.Drawing.Size(22, 57);
            this.lblActive_report.TabIndex = 9;
            this.lblActive_report.Visible = false;
            // 
            // lblActive_user
            // 
            this.lblActive_user.BackColor = System.Drawing.Color.Green;
            this.lblActive_user.Location = new System.Drawing.Point(1, 444);
            this.lblActive_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive_user.Name = "lblActive_user";
            this.lblActive_user.Size = new System.Drawing.Size(22, 57);
            this.lblActive_user.TabIndex = 8;
            this.lblActive_user.Visible = false;
            // 
            // lblActive_payroll
            // 
            this.lblActive_payroll.BackColor = System.Drawing.Color.Green;
            this.lblActive_payroll.Location = new System.Drawing.Point(1, 387);
            this.lblActive_payroll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive_payroll.Name = "lblActive_payroll";
            this.lblActive_payroll.Size = new System.Drawing.Size(22, 57);
            this.lblActive_payroll.TabIndex = 7;
            this.lblActive_payroll.Visible = false;
            // 
            // lblActive_employee
            // 
            this.lblActive_employee.BackColor = System.Drawing.Color.Green;
            this.lblActive_employee.Location = new System.Drawing.Point(1, 331);
            this.lblActive_employee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActive_employee.Name = "lblActive_employee";
            this.lblActive_employee.Size = new System.Drawing.Size(22, 57);
            this.lblActive_employee.TabIndex = 3;
            this.lblActive_employee.Visible = false;
            // 
            // btnReports
            // 
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(16, 500);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(287, 57);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Generate Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            this.btnReports.MouseLeave += new System.EventHandler(this.btnReports_leave_MouseLeave);
            this.btnReports.MouseHover += new System.EventHandler(this.btnReports_MouseHover);
            // 
            // btnUser
            // 
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(16, 444);
            this.btnUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(287, 57);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Manage Users";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            this.btnUser.MouseLeave += new System.EventHandler(this.btnUser_leave_MouseLeave);
            this.btnUser.MouseHover += new System.EventHandler(this.btnUser_MouseHover);
            // 
            // btnPayrioll
            // 
            this.btnPayrioll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayrioll.FlatAppearance.BorderSize = 0;
            this.btnPayrioll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayrioll.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayrioll.ForeColor = System.Drawing.Color.White;
            this.btnPayrioll.Location = new System.Drawing.Point(16, 387);
            this.btnPayrioll.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayrioll.Name = "btnPayrioll";
            this.btnPayrioll.Size = new System.Drawing.Size(287, 57);
            this.btnPayrioll.TabIndex = 2;
            this.btnPayrioll.Text = "Manage Payroll";
            this.btnPayrioll.UseVisualStyleBackColor = true;
            this.btnPayrioll.Click += new System.EventHandler(this.btnPayrioll_Click);
            this.btnPayrioll.MouseLeave += new System.EventHandler(this.btnPayrioll_leave_MouseLeave);
            this.btnPayrioll.MouseHover += new System.EventHandler(this.btnPayrioll_MouseHover);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(16, 331);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(287, 57);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Manage Employees";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            this.btnEmployee.MouseLeave += new System.EventHandler(this.btnemployee_leave_MouseLeave);
            this.btnEmployee.MouseHover += new System.EventHandler(this.btnEmployee_MouseHover);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClose});
            this.toolStrip1.Location = new System.Drawing.Point(1351, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(116, 63);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Sitka Text", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(421, 46);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(831, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(80, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Sitka Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(16, 274);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(287, 57);
            this.btnHome.TabIndex = 11;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnhome_leave_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // pnlContent
            // 
            this.pnlContent.BackgroundImage = global::PayrollSystem1._1.Properties.Resources._3d2083fa_2cf4_4c66_9856_00861a95f3d7;
            this.pnlContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlContent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContent.Location = new System.Drawing.Point(311, 110);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1080, 694);
            this.pnlContent.TabIndex = 4;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // tsClose
            // 
            this.tsClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsClose.Image = ((System.Drawing.Image)(resources.GetObject("tsClose.Image")));
            this.tsClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClose.Name = "tsClose";
            this.tsClose.Size = new System.Drawing.Size(29, 60);
            this.tsClose.Text = "Logout";
            this.tsClose.Click += new System.EventHandler(this.tsClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(79, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1392, 772);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblActive_employee;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsClose;
        private System.Windows.Forms.Label lblActive_report;
        private System.Windows.Forms.Label lblActive_user;
        private System.Windows.Forms.Label lblActive_payroll;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnPayrioll;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label lblActive_home;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


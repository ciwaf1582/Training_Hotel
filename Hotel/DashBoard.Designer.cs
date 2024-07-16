namespace Hotel
{
    partial class DashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerDetails = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustmoerRegistration = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Employee1 = new Hotel.All_User_Controls.UC_Employee();
            this.uC_CustomerDetails1 = new Hotel.All_User_Controls.UC_CustomerDetails();
            this.uC_CustomerCheckOut1 = new Hotel.All_User_Controls.UC_CustomerCheckOut();
            this.uC_CustomerRegistration1 = new Hotel.All_User_Controls.UC_CustomerRegistration();
            this.uC_AddRoom1 = new Hotel.All_User_Controls.UC_AddRoom();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnCustomerDetails);
            this.panel1.Controls.Add(this.btnCheckOut);
            this.panel1.Controls.Add(this.btnCustmoerRegistration);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1761, 130);
            this.panel1.TabIndex = 0;
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.Aqua;
            this.MovingPanel.Location = new System.Drawing.Point(143, 123);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(200, 5);
            this.MovingPanel.TabIndex = 1;
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.CheckedState.Image = global::Hotel.Properties.Resources.icons8_employee_100__1_;
            this.btnEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployee.Enabled = false;
            this.btnEmployee.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Image = global::Hotel.Properties.Resources.icons8_employee_100;
            this.btnEmployee.ImageSize = new System.Drawing.Size(47, 47);
            this.btnEmployee.Location = new System.Drawing.Point(1347, 7);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(257, 111);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "직원";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.BorderRadius = 26;
            this.btnCustomerDetails.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerDetails.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerDetails.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerDetails.CheckedState.Image = global::Hotel.Properties.Resources.icons8_more_info_100__1_;
            this.btnCustomerDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.btnCustomerDetails.Image = global::Hotel.Properties.Resources.icons8_more_info_100;
            this.btnCustomerDetails.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomerDetails.Location = new System.Drawing.Point(1039, 7);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(257, 111);
            this.btnCustomerDetails.TabIndex = 0;
            this.btnCustomerDetails.Text = "고객 정보";
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BorderRadius = 26;
            this.btnCheckOut.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCheckOut.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCheckOut.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckOut.CheckedState.Image = global::Hotel.Properties.Resources.icons8_check_out_96__1_;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Image = global::Hotel.Properties.Resources.icons8_check_out_96;
            this.btnCheckOut.ImageSize = new System.Drawing.Size(37, 37);
            this.btnCheckOut.Location = new System.Drawing.Point(731, 7);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(257, 111);
            this.btnCheckOut.TabIndex = 0;
            this.btnCheckOut.Text = "체크 아웃";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCustmoerRegistration
            // 
            this.btnCustmoerRegistration.BorderRadius = 26;
            this.btnCustmoerRegistration.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustmoerRegistration.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustmoerRegistration.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustmoerRegistration.CheckedState.Image = global::Hotel.Properties.Resources.icons8_registration_64__1_;
            this.btnCustmoerRegistration.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustmoerRegistration.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustmoerRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustmoerRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustmoerRegistration.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnCustmoerRegistration.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustmoerRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCustmoerRegistration.Image = global::Hotel.Properties.Resources.icons8_registration_64;
            this.btnCustmoerRegistration.ImageSize = new System.Drawing.Size(37, 37);
            this.btnCustmoerRegistration.Location = new System.Drawing.Point(423, 7);
            this.btnCustmoerRegistration.Name = "btnCustmoerRegistration";
            this.btnCustmoerRegistration.Size = new System.Drawing.Size(257, 111);
            this.btnCustmoerRegistration.TabIndex = 0;
            this.btnCustmoerRegistration.Text = "고객 등록";
            this.btnCustmoerRegistration.Click += new System.EventHandler(this.btnCustmoerRegistration_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 26;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAdd.CheckedState.Image = global::Hotel.Properties.Resources.icons8_key_100__1_;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::Hotel.Properties.Resources.icons8_key_100;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(115, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(257, 111);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "방 추가";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1748, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "관리자용";
            this.label1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.uC_Employee1);
            this.panel2.Controls.Add(this.uC_CustomerDetails1);
            this.panel2.Controls.Add(this.uC_CustomerCheckOut1);
            this.panel2.Controls.Add(this.uC_CustomerRegistration1);
            this.panel2.Controls.Add(this.uC_AddRoom1);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(28, 167);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1833, 756);
            this.panel2.TabIndex = 0;
            // 
            // uC_Employee1
            // 
            this.uC_Employee1.BackColor = System.Drawing.Color.White;
            this.uC_Employee1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Employee1.Location = new System.Drawing.Point(0, 0);
            this.uC_Employee1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_Employee1.Name = "uC_Employee1";
            this.uC_Employee1.Size = new System.Drawing.Size(1853, 870);
            this.uC_Employee1.TabIndex = 4;
            // 
            // uC_CustomerDetails1
            // 
            this.uC_CustomerDetails1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerDetails1.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uC_CustomerDetails1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerDetails1.Name = "uC_CustomerDetails1";
            this.uC_CustomerDetails1.Size = new System.Drawing.Size(1853, 870);
            this.uC_CustomerDetails1.TabIndex = 3;
            // 
            // uC_CustomerCheckOut1
            // 
            this.uC_CustomerCheckOut1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerCheckOut1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CustomerCheckOut1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerCheckOut1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_CustomerCheckOut1.Name = "uC_CustomerCheckOut1";
            this.uC_CustomerCheckOut1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uC_CustomerCheckOut1.Size = new System.Drawing.Size(1848, 870);
            this.uC_CustomerCheckOut1.TabIndex = 2;
            // 
            // uC_CustomerRegistration1
            // 
            this.uC_CustomerRegistration1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRegistration1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CustomerRegistration1.Location = new System.Drawing.Point(0, 0);
            this.uC_CustomerRegistration1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uC_CustomerRegistration1.Name = "uC_CustomerRegistration1";
            this.uC_CustomerRegistration1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uC_CustomerRegistration1.Size = new System.Drawing.Size(1853, 870);
            this.uC_CustomerRegistration1.TabIndex = 1;
            // 
            // uC_AddRoom1
            // 
            this.uC_AddRoom1.BackColor = System.Drawing.Color.White;
            this.uC_AddRoom1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_AddRoom1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddRoom1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uC_AddRoom1.Name = "uC_AddRoom1";
            this.uC_AddRoom1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uC_AddRoom1.Size = new System.Drawing.Size(1853, 870);
            this.uC_AddRoom1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.White;
            this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.Image = global::Hotel.Properties.Resources.icons8_minimize_100;
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMinimize.Location = new System.Drawing.Point(1779, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Image = global::Hotel.Properties.Resources.icons8_exit_961;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(1815, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1857, 946);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2ImageButton btnExit;
        public Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
        public System.Windows.Forms.Panel MovingPanel;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        public All_User_Controls.UC_AddRoom uC_AddRoom1;
        public All_User_Controls.UC_CustomerRegistration uC_CustomerRegistration1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        public All_User_Controls.UC_CustomerCheckOut uC_CustomerCheckOut1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        public All_User_Controls.UC_CustomerDetails uC_CustomerDetails1;
        public Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        public All_User_Controls.UC_Employee uC_Employee1;
        public Guna.UI2.WinForms.Guna2Button btnAdd;
        public Guna.UI2.WinForms.Guna2Button btnCustomerDetails;
        public Guna.UI2.WinForms.Guna2Button btnCheckOut;
        public Guna.UI2.WinForms.Guna2Button btnCustmoerRegistration;
        public Guna.UI2.WinForms.Guna2Button btnEmployee;
        public System.Windows.Forms.Label label1;
    }
}
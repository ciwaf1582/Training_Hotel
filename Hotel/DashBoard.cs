using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // 최소화
        }
        public void btnCustmoerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustmoerRegistration.Left + 28;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
        }

        public void btnAdd_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnAdd.Left + 28;
            uC_AddRoom1.Visible = true;
            uC_AddRoom1.BringToFront();
        }

        public void btnCheckOut_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCheckOut.Left + 28;
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront();
        }

        public void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerDetails.Left + 28;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }
        public void btnEmployee_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnEmployee.Left + 28; // 클릭시 패널 무브
            uC_Employee1.Visible = true;
            uC_Employee1.BringToFront();
        }

        public void DashBoard_Load(object sender, EventArgs e)
        {
            uC_Employee1.Visible = false;
            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnAdd.PerformClick();

            //=========================관리자 전용=====================//
            label1.Visible = true;
            btnEmployee.Enabled = true;
        }

    }
}

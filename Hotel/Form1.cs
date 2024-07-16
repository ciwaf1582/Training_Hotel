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
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username, pass from employee where username = '" + txtUsername.Text + "' and pass = '" + txtPassword.Text + "' ";
            DataSet ds = fn.getData(query);

            if ( txtUsername.Text == "admin" && txtPassword.Text == "123" /*관리자*/)
            {
                lblError.Visible = false;
                DashBoard dash = new DashBoard();
                this.Hide(); // 이 창은 숨기고
                dash.Show(); // ds창이 오픈
            }
            else if ( ds.Tables[0].Rows.Count != 0)
            {
                lblError.Visible = false;
                DashBoard2 dash2 = new DashBoard2();
                this.Hide(); // 이 창은 숨기고
                dash2.Show(); // ds창이 오픈
            }
            else
            {
                lblError.Visible = true; // Username, password가 일치하지 않을 경우 에러 창 true
                txtPassword.Clear();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}

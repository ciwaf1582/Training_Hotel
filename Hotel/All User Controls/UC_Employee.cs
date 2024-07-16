using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.All_User_Controls
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        String query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPass.Text != "")
            {
                String name = txtName.Text; Int64 mobile = Int64.Parse(txtMobile.Text); String gender = txtGender.Text;
                String email = txtEmail.Text; String username = txtUsername.Text; String pass = txtPass.Text;

                // 위 항목을 저장하는 쿼리
                query = "insert into employee (ename, mobile, gender, emailid, username, pass) " +
                    " values('" + name + "', " + mobile + ", '" + gender + "','" + email + "','" + username + "', '" + pass + "')";
                fn.setData(query, "등록이 완료되었습니다.");

                clearAll();
                getMaxID(); // 직원 추가한 후 새롭게 ID++
            }
            else
            {
                MessageBox.Show("모든 항목을 채워주세요.", "경고...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clearAll();
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1) // 세부 탭
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabControl1.SelectedIndex == 2) // 삭제 탭
            {
                setEmployee(guna2DataGridView2);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("위 직원의 정보를 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "직원의 정보가 삭제되었습니다.");
                    tabControl1_SelectedIndexChanged(this, null);
                }
                else
                {
                    // NO 선택시 return
                }
            }

        }
        private void tabControl1_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        /*********************************************함수*********************************************/
        public void getMaxID()
        {
            query = "select max(eid) from employee"; // id리스트 중 맥스값
            DataSet ds = fn.getData(query); //인수값 하나를 리턴하기 때문에 getData함수를 사용

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                lblToSet.Text = (num + 1).ToString(); // id값 증가한 뒤 문자열로 변환
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPass.Clear();
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0]; // dgv == 그리드뷰 네임은 각각 다르기 때문에 변수로 지정
        }


    }
}

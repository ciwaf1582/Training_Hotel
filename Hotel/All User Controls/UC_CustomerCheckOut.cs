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
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }
        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner Join rooms on customer.roomid = rooms.roomid where chekout = 'NO'";
            // fn.getData(query); // 데이터를 호출했지만 반환 메소드는 미지정
            DataSet ds = fn.getData(query); // DataSet ds 에 반환 지정
            guna2DataGridView1.DataSource = ds.Tables[0]; // 테이플 형태로 저장 및 출력 
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, rooms.roomNo, rooms.roomType, rooms.bed, rooms.price from customer inner Join rooms on customer.roomid = rooms.roomid where cname like '" + txtName.Text + "%' and chekout = 'NO'"; // like == 식별, % == 이하 출력
            DataSet ds = fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0]; 
                    
        }
        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString(); // 한 행의 항목 갯수
            }
            else
            {

            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("위 항목이 확실합니까?", "확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update customer set chekout = 'YES', checkout = '" + cdate + "' where cid = " + id + " update rooms set booked = 'NO' where roomNo = '" + txtRoom.Text + "' ";
                    fn.setData(query, "체크 아웃되었습니다.");
                    UC_CustomerCheckOut_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("고객 정보가 들어있지 않습니다.", "메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            clearAll(); // 체크아웃란을 떠났을 때 초기화
        }
    }
}

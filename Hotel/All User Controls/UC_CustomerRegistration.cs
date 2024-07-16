using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.All_User_Controls
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }
        public void setComboBox(String query, ComboBox combo) //메소드 호출 시 쿼리와 콤보박스의 이름을 전달
        {
            SqlDataReader sdr = fn.getForCombo(query); // set과 동시에 get으로 추가 전달
            while (sdr.Read()) // 행을 순차적으로 읽으며 마지막 행에선 읽을 행이 없어 루프는 중지
            {
                for (int i = 0; i < sdr.FieldCount; i++) // 0부터 sdr의 파일 갯수까지 실행
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "'and roomType = '" + txtRoom.Text + "' and booked = 'NO'";
            setComboBox(query, txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1; // 첫 항목을 수정하면 2번째 항목 초기화
            txtRoomNo.Items.Clear(); //3번째 항목 초기화
            txtPrice.Clear();
        }
        int rid; // 방 id
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 호실이 정해졌을 때 price 불러오기
            query = "select price, roomid from rooms where roomNo = '" + txtRoomNo.Text + "' ";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString(); // 행
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }
        
        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" &&
                    txtDob.Text != "" && txtIdproof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" &&
                    txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                String national = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDob.Text;
                String idproof = txtIdproof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckIn.Text;

                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, addres, checkin, roomid) values ('" + name + "', " + mobile + ",'" + national + "', '" + gender + "', '" + dob + "', '" + idproof + "', '"+address+"', '"+checkin+"', "+rid+") update rooms set booked = 'YES' where roomNo = '" + txtRoomNo.Text + "' "; // 체크인, 아웃 상태 출력
                fn.setData(query, "Room No" + txtRoomNo.Text + "방 예약이 완료되었습니다.");
                clearAll();
            }

            else
            {
                MessageBox.Show("모든 항목을 채워주세요.", "경고...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll() // 모든 항복 초기화
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDob.ResetText();
            txtIdproof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

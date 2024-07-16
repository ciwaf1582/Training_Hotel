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
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query); //getData는 return(반환)형식 이기에 ds에 저장(?)
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            // 각 항목별 빈칸을 확인하는 최단 코드
            if (txtRoomNo.Text != "" && txtType.Text != "" && txtBed.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String type = txtType.Text;
                String bed = txtBed.Text;
                Int64 price = Convert.ToInt64(txtPrice.Text); // 단순한 int는 용량이 크기 때문에 stirng을 먼저 받고 int로 변환

                query = "insert into rooms (roomNo, roomType, bed, price) values ('" + roomno + "', '" + type + "', '" + bed + "', " + price + " )"; // price는 인수이기에 ''생략
                fn.setData(query, "새로운 방이 추가됐습니다."); // 이것만으로는 gridView1에 표시가 안됨

                UC_AddRoom_Load(this, null); // 그래서 이 코드를 작성하여 표시
                clearAll();
            }
            else // 항목이 비어있다면...
            {
                MessageBox.Show("모든 항목을 채워주세요.", "경고...!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void clearAll() // 모든 항목 빈칸으로 만드는 메소드
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex = -1;
            txtBed.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            // AddRoom을 떠날 때 이벤트 발생
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }
}

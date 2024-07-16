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
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        String query;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                //     테이블 customer 고객 정보
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality," +
                    " customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, customer.checkout," +
                    // 체크아웃 후 방 정보
                    " rooms.roomNo, rooms.roomType, rooms.bed, rooms.price" +
                    " from customer inner Join rooms on customer.roomid = rooms.roomid"; // roomid == 외부 키
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality," +
                    " customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, customer.checkout," +
                    " rooms.roomNo, rooms.roomType, rooms.bed, rooms.price" +
                    " from customer inner Join rooms on customer.roomid = rooms.roomid " +
                    "where checkout is null"; // 체크아웃이 안된 고객은 null 
                getRecord(query);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select customer.cid, customer.cname, customer.mobile, customer.nationality," +
                    " customer.gender, customer.dob, customer.idproof, customer.addres, customer.checkin, customer.checkout," +
                    " rooms.roomNo, rooms.roomType, rooms.bed, rooms.price" +
                    " from customer inner Join rooms on customer.roomid = rooms.roomid " +
                    "where checkout is not null"; // 체크아웃이 된 고객은 null
                getRecord(query);
            }
        }
        private void getRecord(string query)
        {
            DataSet ds = fn.getData(query);
            gunaGridView1.DataSource = ds.Tables[0];
        }
    }
}

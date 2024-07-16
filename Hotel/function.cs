using System;
using System.Collections.Generic;
using System.Data; // DataSet 사용 네임스페이스
using System.Data.SqlClient; // sql 사용 네임스페이스
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    internal class function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = PC; database = myHotel; integrated security = True";
            return con;
        }
        public DataSet getData(string query) // 데이터베이스를 가져오는 코드
        {
            SqlConnection con = getConnection(); // SqlConnection객체는 'getConnection'데이터베이스에 연결
            SqlCommand cmd = new SqlCommand(); // SqlCommand 객체는 SQL 쿼리를 설정
            cmd.Connection = con;
            cmd.CommandText = query; // 텍스트로 나온 후 쿼리로 전달
            SqlDataAdapter da = new SqlDataAdapter(cmd); // SqlDataAdapter객체는 DataSet으로 데이터로 채움
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query, string message) //삽입 삭제 업데이트
        {
            SqlConnection con = getConnection(); // 연결
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con; // 연결 전달
            con.Open(); // 실행
            cmd.CommandText = query; //실행 후 쿼리를 전달
            cmd.ExecuteNonQuery(); // 쿼리를 실행
            con.Close(); // 연결을 닫음
            MessageBox.Show("'" + message + "'", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getForCombo(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyThuVien.DAO
{
   public class DataProvider
    {
        static string provider = @"Data Source=MANHTUAN\TUAN_MANH;Initial Catalog=Quan_Ly_Thu_Vien;Persist Security Info=True;User ID=TuanQuanLy;Password=123456";
        SqlConnection connect = new SqlConnection(provider);

        public DataTable GetData(string sql)
        {
  
            DataTable rs = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, provider);
            adapter.Fill(rs);
            return rs;
        }
        public void Excute(string sql)
        {
            connect.Open();
            SqlCommand command = new SqlCommand(sql, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}

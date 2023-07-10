using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyThuVien.DAO
{
   public class ThanhVien_DAO: DataProvider
    {
        public bool login(string _tk, string _mk)
        {
            Program.mlogin = _tk;
            Program.password = _mk;
            if (Program.Connect() == 0) return false; // Bắt đầu kết nối tới database
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.serverNameHT = Program.serverName;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlDataReader myReader;

            String strleng = "EXEC SP_DANGNHAP '" + Program.mloginDN +"','"+Program.passwordDN+ "'";
            myReader = Program.ExecSqlDataReader(strleng);
            if (myReader == null) return false;
            myReader.Read();

            
            if (myReader.GetInt32(0)== 1)
            {
                MessageBox.Show("Đăng nhập thất bại", "", MessageBoxButtons.OK);
                return false;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            myReader.Close();
            return true;
        }
        public bool signup(ThanhVien _tv)
        {

            Program.connstr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                  Program.database + ";User ID=" +
                  Program.mlogin + ";password=" + Program.password;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlCommand cmd = new SqlCommand("SP_TAOLOGIN", Program.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@LGNAME", _tv.TenDangNhap));
            cmd.Parameters.Add(new SqlParameter("@PASS", _tv.MatKhau));
            cmd.Parameters.Add(new SqlParameter("@USERNAME", _tv.TenDangNhap));
            cmd.Parameters.Add(new SqlParameter("@ROLE", "Nhanvien"));
            SqlDataReader myReader = null;
            //String strleng = "EXEC SP_TAOTAIKHOAN '" + login + "','"+password+"','"+username+"','"+role+"'";
            try
            {
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        //{
        //    if (GetData("select* from ACCOUNT where TenDangNhap = '" + _tv.TenDangNhap + "'").Rows.Count > 0)
        //        return false;
        //    Random rdm = new Random();
        //    _tv.MaDocGia = rdm.Next(0, 1000).ToString();
        //    while(GetData("select* from ACCOUNT where MaDocGia = '" + _tv.TenDangNhap + "'").Rows.Count > 0)
        //    {
        //        _tv.MaDocGia = rdm.Next(0, 1000).ToString();
        //    }
        //    string sql = string.Format("Insert Into ACCOUNT values('{0}','{1}','{2}','{3}')",
        //         _tv.MaDocGia, _tv.TenDangNhap, _tv.MatKhau, 1);
        //    Excute(sql);
        //    sql = string.Format("Insert Into DOCGIA(MaDocGia) values('{0}')", _tv.MaDocGia);
        //    Excute(sql);
        //    return true;
        //}
        public void Update(DocGia _dg)
        {
            string sql = string.Format("update DOCGIA set HoTen = N'{0}', GioiTinh = N'{1}', NamSinh = '{2}', DiaChi = N'{3}' where MaDocGia = '{4}'",
                _dg.HoTen, _dg.GioiTinh, _dg.NamSinh, _dg.DiaChi, _dg.MaDocGia);
            Excute(sql);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DTO;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.CodeParser;

namespace QuanLyThuVien.DAO
{
    class PhieuMuon_DAO : DataProvider
    {
        public DataTable loadPhieuMuon(int mdg)
        {
            string sqlString = "exec BORROWING "+ mdg;
            return GetData(sqlString);
        }
        public bool CheckExist(string _table, string _str)
        {
            if (_table == "DOCGIA")
                if (GetData("select* from DOCGIA where MaDocGia = '" + _str + "'").Rows.Count > 0)
                    return true;
            if (_table == "SACH")
                if (GetData("select* from SACH where MaSach = '" + _str + "'").Rows.Count > 0)
                    return true;
            return false;
        }

        public int Insert(int _pm )
        {
            if (Program.Connect() == 0) return -1; // Bắt đầu kết nối tới database
            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;
            Program.serverNameHT = Program.serverName;
            Program.conn = new SqlConnection(Program.connstr);
            Program.conn.Open();
            SqlDataReader myReader;

            String strleng = "exec CREATE_BORROWING " + _pm; 
            myReader = Program.ExecSqlDataReader(strleng);
            if (myReader == null) return -1;
            myReader.Read();
            int mp = myReader.GetInt32(0);
            myReader.Close();
            return mp;



            //string sql = "exec CREATE_BORROWING " + _pm;

            //GetData(sql);
            //return true;
        }
        public void Delete(string _pm)
        {
            Excute("delete from PHIEUMUON where MaPhieu = '" + _pm + "'");
        }

        public void Update(PhieuMuon _pm)
        {
            string sql = string.Format("update PHIEUMUON set MaDocGia = N'{0}', MaSach = N'{1}', NgayMuon = '{2}', NgayPhaiTra = '{3}' where MaPhieu = '{4}'",
                 _pm.MaDocGia, _pm.MaSach, _pm.NgayMuon, _pm.MaPhieu, _pm.NgayPhaiTra);
            Excute(sql);
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = string.Format("select PM.MaPhieu, PM.MaDocGia, DG.HoTen, PM.MaSach, S.TenSach, PM.NgayMuon, PM.NgayPhaiTra from DOCGIA DG, PHIEUMUON PM, SACH S where PM.MaDocGia = DG.MaDocGia and PM.MaSach = S.MaSach and PM.{0} like N'%{1}%'", _loaitk, _timkiem);
            return GetData(sqlString);
        }

    }
}

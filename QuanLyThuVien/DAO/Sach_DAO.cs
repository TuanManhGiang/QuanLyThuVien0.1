using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyThuVien.DTO;
using System.Windows.Forms;
using DevExpress.CodeParser;

namespace QuanLyThuVien.DAO
{
    class Sach_DAO : DataProvider
    {
        public DataTable loadSach()
        {
            string sqlString = "select * from VIEW_BOOKS ";
            DataTable dataTable = GetData(sqlString);
            int rowCount = dataTable.Rows.Count;
            int columnCount = dataTable.Columns.Count;
            if(rowCount==0|| columnCount == 0)
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu. " , "", MessageBoxButtons.OK);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (DataColumn column in dataTable.Columns)
            //    {
            //        Console.WriteLine(row[column]);
            //    }
            //}

            return GetData(sqlString);
        }
        public bool Insert(Sach _s)
        {
            string sql = "EXEC add_book '"+
                 _s.TenSach+"','"+_s.LanXuatBan + "'," + _s.NamXuatBan + ",'" + _s.KhoGiay + "'," + _s.SoTrang + ",'" + _s.NhaXuatBan + "'," + _s.GiaSach + "," + _s.cd + "," + _s.SoLuong;
            try{
                Excute(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm Sách Lỗi " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        public void Delete(string mS)
        {
            Excute("delete from SACH where MaSach = '" + mS + "'");
        }

        public void Update(Sach _s)
        {
            string sql = "EXEC update_book "
                + _s.MaSach + ",'" + _s.TenSach + "','" + _s.KhoGiay + "'," + _s.NamXuatBan + ",'" + _s.NhaXuatBan
                + "','" + _s.LanXuatBan + "'," + _s.GiaSach+","+_s.cd;

            try
            {
                Excute(sql);
            }
            catch (Exception e)
            {
                MessageBox.Show("Sửa Sách Lỗi " + e.Message, "", MessageBoxButtons.OK);
                
            }
           
        }
        public DataTable Search(string _timkiem, string _loaitk)
        {
            string sqlString = "exec SearchBooks '" + _timkiem + "','" + _loaitk + "'";
            return GetData(sqlString);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyThuVien.DTO;
using System.Windows.Forms;
using static DevExpress.XtraBars.Docking2010.Views.BaseRegistrator;

namespace QuanLyThuVien.DAO
{
    class DocGia_DAO : DataProvider
    {
        public DataTable loadDocGia()
        {
            string sqlString = @"select * from Readers";
            return GetData(sqlString);
        }
        public bool Insert(DocGia dg)
        {

            string sql = "exec AddReader '" + dg.NamSinh + "','" + dg.HoTen + "','" + dg.DiaChi + "','" + dg.GioiTinh + "'";
            try
            {
                Excute(sql);
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Them Doc Gia Loi " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }
        public void Delete(string mDG)
        {
            Excute("delete from DOCGIA where MaDocGia = '" + mDG + "'");
        }

        public void Update(DocGia dg)
        {

            string sql = "exec UpdateReader "+dg.MaDocGia+",'" + dg.NamSinh + "','" + dg.HoTen + "','" + dg.DiaChi + "','" + dg.GioiTinh + "'";
            try
            {
                Excute(sql);
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Them Doc Gia Loi " + e.Message, "", MessageBoxButtons.OK);
               
            }
        }
        public DataTable Search(string _timkiem)
        {
            string sqlString = string.Format("select * from DOCGIA where MaDocGia like N'%{0}%'", _timkiem);
            return GetData(sqlString);
        }
        
    }
}

using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuVien.BUS
{
    class Muon_BUS
    {
        Muon_DAO muonDAO = new Muon_DAO();
        public DataTable GetList(string _tdn)
        {
            return muonDAO.loadSach(_tdn);
        }
        public DataTable TimKiem(string _ts, string _tdn)
        {
            return muonDAO.Search(_ts, _tdn);
        }
    }
}

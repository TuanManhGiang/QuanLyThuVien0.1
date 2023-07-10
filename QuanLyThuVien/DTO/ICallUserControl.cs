using QuanLyThuVien.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.DTO
{
    public abstract class ICallUserControl
    {
        public ThanhVien_DAO DocGia { get; set; }
        public abstract ucFrmQLPhieuMuon callUserControl();
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;

namespace QuanLyThuVien
{
    public partial class ucFrmTimKiemSach : UserControl
    {
        Sach_BUS sachBUS = new Sach_BUS();
        public ucFrmTimKiemSach()
        {
            InitializeComponent();
        }

        private void ucFrmTimKiemSach_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = sachBUS.GetList();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "")
            {
                gridControl1.DataSource = sachBUS.GetList();

            }
            else
            {
                if (rdoBtnMaSach.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "book_id");
                
                
                else if (rdoBtnTenSach.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "book_title");
               
                else if(rdoBtnTinhTrang.Checked == true)
                    gridControl1.DataSource = sachBUS.TimKiem(txtTimKiem.Text, "status");
            }
        }
    }
}

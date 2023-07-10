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
using DevExpress.XtraRichEdit.Model;

namespace QuanLyThuVien
{
    public partial class ucFrmQLThanhVien : UserControl
    {
        DevExpress.XtraEditors.PanelControl panelCha;
        DocGia_BUS docGiaBUS = new DocGia_BUS();

        PhieuMuon_BUS pmBUS = new PhieuMuon_BUS();
        public ucFrmQLThanhVien(DevExpress.XtraEditors.PanelControl panelCha)
        {
            this.panelCha = panelCha;
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;

            DocGia dg = new DocGia();

            Random rdm = new Random();
            dg.MaDocGia = rdm.Next(0, 1000).ToString();

            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rdoBtnNam.Checked == true)
                dg.GioiTinh = "Male";
            else if (rdoBtnNu.Checked == true)
                dg.GioiTinh = "Female";

            if (dateNamSinh.Text == "")
                dg.NamSinh = DateTime.Now;
            else
                dg.NamSinh = dateNamSinh.DateTime;
            //kiem tra loi madocgia
            int check = docGiaBUS.Them(dg);
            if (check == 0)
                lb_MDG.Visible = true;
            else if (check == -1)
                lb_Trung.Visible = true;
            //load lai
            ucFrmQLThanhVien_Load(sender, e);
            ResetGridview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
            DocGia dg = new DocGia();
            dg.MaDocGia = txtMaDocGia.Text;
            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rdoBtnNam.Checked == true)
                dg.GioiTinh = "Male";
            else if (rdoBtnNu.Checked == true)
                dg.GioiTinh = "Female";
            dg.NamSinh = dateNamSinh.DateTime;
            //kiem tra loi madocgia
            if (!docGiaBUS.Sua(dg))
                lb_MDG.Visible = true;

            //load lai
            ucFrmQLThanhVien_Load(sender, e);
            ResetGridview();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDocGia.Text != "")
            {
                docGiaBUS.Xoa(txtMaDocGia.Text);
                ResetGridview();
                ucFrmQLThanhVien_Load(sender, e);
            }
        }

        private void gridView1_CustomRowCellEditForEditing(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e)
        {
            txtMaDocGia.Text = gridView1.GetRowCellValue(e.RowHandle, "reader_id").ToString();
            txtHoTen.Text = gridView1.GetRowCellValue(e.RowHandle, "reader_name").ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(e.RowHandle, "address").ToString();
            string a = gridView1.GetRowCellValue(e.RowHandle, "gender").ToString();
            if (a == "Male")
                rdoBtnNam.Checked = true;
            else if (a == "Female")
                rdoBtnNu.Checked = true;
            dateNamSinh.Text = gridView1.GetRowCellDisplayText(e.RowHandle, "birth_date");


        }

        private void ucFrmQLThanhVien_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = docGiaBUS.GetList();
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;
        }

        private void ResetGridview()
        {
            txtMaDocGia.ResetText();
            txtHoTen.ResetText();
            txtDiaChi.ResetText();
            rdoBtnNu.Checked = false;
            rdoBtnNam.Checked = false;
            dateNamSinh.ResetText();
        }

        private void txtTimDocGia_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTimDocGia.Text == "")
            {
                gridControl1.DataSource = docGiaBUS.GetList();
            }
            else
                gridControl1.DataSource = docGiaBUS.TimKiem(txtTimDocGia.Text);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btt_TaoPhieuMuon_Click(object sender, EventArgs e)
        {
            lb_MDG.Visible = false;
            lb_Trung.Visible = false;

            DocGia dg = new DocGia();

            Random rdm = new Random();
            dg.MaDocGia = txtMaDocGia.Text;

            dg.HoTen = txtHoTen.Text;
            dg.DiaChi = txtDiaChi.Text;
            if (rdoBtnNam.Checked == true)
                dg.GioiTinh = "Male";
            else if (rdoBtnNu.Checked == true)
                dg.GioiTinh = "Female";

            if (dateNamSinh.Text == "")
                dg.NamSinh = DateTime.Now;
            else
                dg.NamSinh = dateNamSinh.DateTime;
            //kiem tra loi madocgia
            panelCha.Controls.Clear();

            dg.MaP=pmBUS.Them(int.Parse(dg.MaDocGia));
            ucFrmQLPhieuMuon frm = new ucFrmQLPhieuMuon(dg);
            frm.Dock = System.Windows.Forms.DockStyle.Fill;

            panelCha.Controls.Add(frm);


        }
    }
}

namespace QuanLyThuVien
{
    partial class ucFrmTimKiemSach
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rdoBtnTinhTrang = new System.Windows.Forms.RadioButton();
            this.rdoBtnTenSach = new System.Windows.Forms.RadioButton();
            this.rdoBtnMaSach = new System.Windows.Forms.RadioButton();
            this.txtTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MaSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenSach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LanXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NamXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KhoGiay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTrang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NhaXB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupControl1);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 262);
            this.panel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rdoBtnTinhTrang);
            this.groupControl1.Controls.Add(this.rdoBtnTenSach);
            this.groupControl1.Controls.Add(this.rdoBtnMaSach);
            this.groupControl1.Location = new System.Drawing.Point(39, 51);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1063, 191);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "Tìm Kiếm Theo:";
            // 
            // rdoBtnTinhTrang
            // 
            this.rdoBtnTinhTrang.AutoSize = true;
            this.rdoBtnTinhTrang.Location = new System.Drawing.Point(105, 96);
            this.rdoBtnTinhTrang.Name = "rdoBtnTinhTrang";
            this.rdoBtnTinhTrang.Size = new System.Drawing.Size(113, 23);
            this.rdoBtnTinhTrang.TabIndex = 10;
            this.rdoBtnTinhTrang.Text = "Tình Trạng";
            this.rdoBtnTinhTrang.UseVisualStyleBackColor = true;
            // 
            // rdoBtnTenSach
            // 
            this.rdoBtnTenSach.AutoSize = true;
            this.rdoBtnTenSach.Location = new System.Drawing.Point(106, 151);
            this.rdoBtnTenSach.Name = "rdoBtnTenSach";
            this.rdoBtnTenSach.Size = new System.Drawing.Size(99, 23);
            this.rdoBtnTenSach.TabIndex = 9;
            this.rdoBtnTenSach.Text = "Tên Sách";
            this.rdoBtnTenSach.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMaSach
            // 
            this.rdoBtnMaSach.AutoSize = true;
            this.rdoBtnMaSach.Checked = true;
            this.rdoBtnMaSach.Location = new System.Drawing.Point(105, 35);
            this.rdoBtnMaSach.Name = "rdoBtnMaSach";
            this.rdoBtnMaSach.Size = new System.Drawing.Size(92, 23);
            this.rdoBtnMaSach.TabIndex = 9;
            this.rdoBtnMaSach.TabStop = true;
            this.rdoBtnMaSach.Text = "Mã Sách";
            this.rdoBtnMaSach.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(145, 14);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(958, 26);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(39, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 23);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Tìm Kiếm:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 443);
            this.panel2.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1143, 443);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MaSach,
            this.TenSach,
            this.LanXB,
            this.STT,
            this.NamXB,
            this.KhoGiay,
            this.SoTrang,
            this.NhaXB,
            this.Gia,
            this.CD,
            this.TrangThai});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // MaSach
            // 
            this.MaSach.Caption = "Mã Sách";
            this.MaSach.FieldName = "book_id";
            this.MaSach.MinWidth = 30;
            this.MaSach.Name = "MaSach";
            this.MaSach.Visible = true;
            this.MaSach.VisibleIndex = 0;
            this.MaSach.Width = 112;
            // 
            // TenSach
            // 
            this.TenSach.Caption = "Tên Sách";
            this.TenSach.FieldName = "book_title";
            this.TenSach.MinWidth = 30;
            this.TenSach.Name = "TenSach";
            this.TenSach.Visible = true;
            this.TenSach.VisibleIndex = 1;
            this.TenSach.Width = 112;
            // 
            // LanXB
            // 
            this.LanXB.Caption = "Lần Xuất Bản";
            this.LanXB.FieldName = "publication_number";
            this.LanXB.MinWidth = 30;
            this.LanXB.Name = "LanXB";
            this.LanXB.Visible = true;
            this.LanXB.VisibleIndex = 3;
            this.LanXB.Width = 112;
            // 
            // STT
            // 
            this.STT.Caption = "STT";
            this.STT.FieldName = "copy_number";
            this.STT.MinWidth = 30;
            this.STT.Name = "STT";
            this.STT.Visible = true;
            this.STT.VisibleIndex = 2;
            this.STT.Width = 112;
            // 
            // NamXB
            // 
            this.NamXB.Caption = "Năm Xuất Bản";
            this.NamXB.FieldName = "publication_year";
            this.NamXB.MinWidth = 30;
            this.NamXB.Name = "NamXB";
            this.NamXB.Visible = true;
            this.NamXB.VisibleIndex = 5;
            this.NamXB.Width = 112;
            // 
            // KhoGiay
            // 
            this.KhoGiay.Caption = "Khổ Giấy";
            this.KhoGiay.FieldName = "paper_size";
            this.KhoGiay.MinWidth = 30;
            this.KhoGiay.Name = "KhoGiay";
            this.KhoGiay.Visible = true;
            this.KhoGiay.VisibleIndex = 7;
            this.KhoGiay.Width = 112;
            // 
            // SoTrang
            // 
            this.SoTrang.Caption = "Số Trang";
            this.SoTrang.FieldName = "page_count";
            this.SoTrang.MinWidth = 30;
            this.SoTrang.Name = "SoTrang";
            this.SoTrang.Visible = true;
            this.SoTrang.VisibleIndex = 6;
            this.SoTrang.Width = 112;
            // 
            // NhaXB
            // 
            this.NhaXB.Caption = "Nhà Xuất Bản";
            this.NhaXB.FieldName = "publisher";
            this.NhaXB.MinWidth = 30;
            this.NhaXB.Name = "NhaXB";
            this.NhaXB.Visible = true;
            this.NhaXB.VisibleIndex = 4;
            this.NhaXB.Width = 112;
            // 
            // Gia
            // 
            this.Gia.Caption = "Giá";
            this.Gia.FieldName = "price";
            this.Gia.MinWidth = 30;
            this.Gia.Name = "Gia";
            this.Gia.Visible = true;
            this.Gia.VisibleIndex = 9;
            this.Gia.Width = 112;
            // 
            // CD
            // 
            this.CD.Caption = "CD";
            this.CD.FieldName = "has_cd";
            this.CD.MinWidth = 30;
            this.CD.Name = "CD";
            this.CD.Visible = true;
            this.CD.VisibleIndex = 8;
            this.CD.Width = 112;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng Thái";
            this.TrangThai.FieldName = "status";
            this.TrangThai.MinWidth = 30;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 10;
            this.TrangThai.Width = 112;
            // 
            // ucFrmTimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucFrmTimKiemSach";
            this.Size = new System.Drawing.Size(1143, 705);
            this.Load += new System.EventHandler(this.ucFrmTimKiemSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RadioButton rdoBtnTenSach;
        private System.Windows.Forms.RadioButton rdoBtnMaSach;
        private DevExpress.XtraEditors.TextEdit txtTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.RadioButton rdoBtnTinhTrang;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MaSach;
        private DevExpress.XtraGrid.Columns.GridColumn TenSach;
        private DevExpress.XtraGrid.Columns.GridColumn LanXB;
        private DevExpress.XtraGrid.Columns.GridColumn STT;
        private DevExpress.XtraGrid.Columns.GridColumn NamXB;
        private DevExpress.XtraGrid.Columns.GridColumn KhoGiay;
        private DevExpress.XtraGrid.Columns.GridColumn SoTrang;
        private DevExpress.XtraGrid.Columns.GridColumn NhaXB;
        private DevExpress.XtraGrid.Columns.GridColumn Gia;
        private DevExpress.XtraGrid.Columns.GridColumn CD;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
    }
}

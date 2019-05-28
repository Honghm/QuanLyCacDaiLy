namespace QL_DaiLyXeMay
{
    partial class ucPhieuNhapHang
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
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.txbTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.txbNguoiLapPhieu = new System.Windows.Forms.TextBox();
            this.txbMaPhieu = new System.Windows.Forms.TextBox();
            this.lbChiTietNhapHang = new System.Windows.Forms.Label();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.TenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbDanhSachPhieuNhap = new System.Windows.Forms.Label();
            this.NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDanhSachPhieuXuat = new System.Windows.Forms.DataGridView();
            this.lbNguoiLapPhieu = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbNgayLapPhieu = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.lbPhieuNhapHang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapPhieu.Location = new System.Drawing.Point(363, 552);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(147, 35);
            this.btnLapPhieu.TabIndex = 44;
            this.btnLapPhieu.Text = "Lập phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // txbTongTien
            // 
            this.txbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongTien.Location = new System.Drawing.Point(786, 477);
            this.txbTongTien.Name = "txbTongTien";
            this.txbTongTien.Size = new System.Drawing.Size(181, 26);
            this.txbTongTien.TabIndex = 41;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(495, 117);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(231, 22);
            this.dtpNgayLapPhieu.TabIndex = 39;
            this.dtpNgayLapPhieu.Value = new System.DateTime(2019, 5, 27, 0, 0, 0, 0);
            // 
            // txbNguoiLapPhieu
            // 
            this.txbNguoiLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNguoiLapPhieu.Location = new System.Drawing.Point(495, 154);
            this.txbNguoiLapPhieu.Name = "txbNguoiLapPhieu";
            this.txbNguoiLapPhieu.Size = new System.Drawing.Size(231, 26);
            this.txbNguoiLapPhieu.TabIndex = 38;
            this.txbNguoiLapPhieu.TextChanged += new System.EventHandler(this.txbNguoiLapPhieu_TextChanged);
            // 
            // txbMaPhieu
            // 
            this.txbMaPhieu.Location = new System.Drawing.Point(794, 64);
            this.txbMaPhieu.Name = "txbMaPhieu";
            this.txbMaPhieu.Size = new System.Drawing.Size(145, 22);
            this.txbMaPhieu.TabIndex = 37;
            // 
            // lbChiTietNhapHang
            // 
            this.lbChiTietNhapHang.AutoSize = true;
            this.lbChiTietNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietNhapHang.ForeColor = System.Drawing.Color.Transparent;
            this.lbChiTietNhapHang.Location = new System.Drawing.Point(330, 195);
            this.lbChiTietNhapHang.Name = "lbChiTietNhapHang";
            this.lbChiTietNhapHang.Size = new System.Drawing.Size(168, 20);
            this.lbChiTietNhapHang.TabIndex = 36;
            this.lbChiTietNhapHang.Text = "Chi tiết nhập hàng:";
            // 
            // ThanhTien
            // 
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(754, 552);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 35);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            // 
            // MaMatHang
            // 
            this.MaMatHang.HeaderText = "Mã mặt hàng";
            this.MaMatHang.Name = "MaMatHang";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // dtgvChiTietDonHang
            // 
            this.dtgvChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietDonHang.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaMatHang,
            this.TenMatHang,
            this.DonViTinh,
            this.SoLuong,
            this.DonGia,
            this.ThanhTien});
            this.dtgvChiTietDonHang.Location = new System.Drawing.Point(332, 224);
            this.dtgvChiTietDonHang.Name = "dtgvChiTietDonHang";
            this.dtgvChiTietDonHang.RowTemplate.Height = 24;
            this.dtgvChiTietDonHang.Size = new System.Drawing.Size(639, 240);
            this.dtgvChiTietDonHang.TabIndex = 35;
            // 
            // TenMatHang
            // 
            this.TenMatHang.HeaderText = "Tên mặt hàng";
            this.TenMatHang.Name = "TenMatHang";
            // 
            // lbDanhSachPhieuNhap
            // 
            this.lbDanhSachPhieuNhap.AutoSize = true;
            this.lbDanhSachPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachPhieuNhap.ForeColor = System.Drawing.Color.Transparent;
            this.lbDanhSachPhieuNhap.Location = new System.Drawing.Point(3, 79);
            this.lbDanhSachPhieuNhap.Name = "lbDanhSachPhieuNhap";
            this.lbDanhSachPhieuNhap.Size = new System.Drawing.Size(188, 17);
            this.lbDanhSachPhieuNhap.TabIndex = 34;
            this.lbDanhSachPhieuNhap.Text = "Danh sách phiếu đã xuất";
            // 
            // NgayLap
            // 
            this.NgayLap.HeaderText = "Ngày lập";
            this.NgayLap.Name = "NgayLap";
            // 
            // MaPhieu
            // 
            this.MaPhieu.HeaderText = "Mã phiếu";
            this.MaPhieu.Name = "MaPhieu";
            // 
            // dtgvDanhSachPhieuXuat
            // 
            this.dtgvDanhSachPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieu,
            this.NgayLap});
            this.dtgvDanhSachPhieuXuat.Location = new System.Drawing.Point(3, 99);
            this.dtgvDanhSachPhieuXuat.Name = "dtgvDanhSachPhieuXuat";
            this.dtgvDanhSachPhieuXuat.RowTemplate.Height = 24;
            this.dtgvDanhSachPhieuXuat.Size = new System.Drawing.Size(291, 533);
            this.dtgvDanhSachPhieuXuat.TabIndex = 33;
            // 
            // lbNguoiLapPhieu
            // 
            this.lbNguoiLapPhieu.AutoSize = true;
            this.lbNguoiLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLapPhieu.ForeColor = System.Drawing.Color.Transparent;
            this.lbNguoiLapPhieu.Location = new System.Drawing.Point(330, 157);
            this.lbNguoiLapPhieu.Name = "lbNguoiLapPhieu";
            this.lbNguoiLapPhieu.Size = new System.Drawing.Size(145, 20);
            this.lbNguoiLapPhieu.TabIndex = 32;
            this.lbNguoiLapPhieu.Text = "Người lập phiếu:";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.Transparent;
            this.lbTongTien.Location = new System.Drawing.Point(684, 480);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(93, 20);
            this.lbTongTien.TabIndex = 29;
            this.lbTongTien.Text = "Tổng tiền:";
            // 
            // lbNgayLapPhieu
            // 
            this.lbNgayLapPhieu.AutoSize = true;
            this.lbNgayLapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLapPhieu.ForeColor = System.Drawing.Color.Transparent;
            this.lbNgayLapPhieu.Location = new System.Drawing.Point(330, 119);
            this.lbNgayLapPhieu.Name = "lbNgayLapPhieu";
            this.lbNgayLapPhieu.Size = new System.Drawing.Size(139, 20);
            this.lbNgayLapPhieu.TabIndex = 27;
            this.lbNgayLapPhieu.Text = "Ngày lập phiếu:";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPhieu.ForeColor = System.Drawing.Color.Transparent;
            this.lbMaPhieu.Location = new System.Drawing.Point(720, 67);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(79, 17);
            this.lbMaPhieu.TabIndex = 26;
            this.lbMaPhieu.Text = "Mã phiếu:";
            // 
            // lbPhieuNhapHang
            // 
            this.lbPhieuNhapHang.AutoSize = true;
            this.lbPhieuNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuNhapHang.ForeColor = System.Drawing.Color.Transparent;
            this.lbPhieuNhapHang.Location = new System.Drawing.Point(293, 9);
            this.lbPhieuNhapHang.Name = "lbPhieuNhapHang";
            this.lbPhieuNhapHang.Size = new System.Drawing.Size(500, 58);
            this.lbPhieuNhapHang.TabIndex = 25;
            this.lbPhieuNhapHang.Text = "PHIẾU NHẬP HÀNG";
            // 
            // ucPhieuNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.txbTongTien);
            this.Controls.Add(this.dtpNgayLapPhieu);
            this.Controls.Add(this.txbNguoiLapPhieu);
            this.Controls.Add(this.txbMaPhieu);
            this.Controls.Add(this.lbChiTietNhapHang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtgvChiTietDonHang);
            this.Controls.Add(this.lbDanhSachPhieuNhap);
            this.Controls.Add(this.dtgvDanhSachPhieuXuat);
            this.Controls.Add(this.lbNguoiLapPhieu);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbNgayLapPhieu);
            this.Controls.Add(this.lbMaPhieu);
            this.Controls.Add(this.lbPhieuNhapHang);
            this.Name = "ucPhieuNhapHang";
            this.Size = new System.Drawing.Size(975, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietDonHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.TextBox txbTongTien;
        private System.Windows.Forms.DateTimePicker dtpNgayLapPhieu;
        private System.Windows.Forms.TextBox txbNguoiLapPhieu;
        private System.Windows.Forms.TextBox txbMaPhieu;
        private System.Windows.Forms.Label lbChiTietNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridView dtgvChiTietDonHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMatHang;
        private System.Windows.Forms.Label lbDanhSachPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieu;
        private System.Windows.Forms.DataGridView dtgvDanhSachPhieuXuat;
        private System.Windows.Forms.Label lbNguoiLapPhieu;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label lbNgayLapPhieu;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.Label lbPhieuNhapHang;
    }
}

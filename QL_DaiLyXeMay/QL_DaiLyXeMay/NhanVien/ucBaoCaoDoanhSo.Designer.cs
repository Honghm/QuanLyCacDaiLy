namespace QL_DaiLyXeMay.NhanVien
{
    partial class ucBaoCaoDoanhSo
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
            this.lbBaoCaoDoanhSo = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbNguoiLap = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbChiTietBaoCao = new System.Windows.Forms.Label();
            this.dtgvChiTietBaoCao = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongPhieuDaXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.txbNguoiLap = new System.Windows.Forms.TextBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // lbBaoCaoDoanhSo
            // 
            this.lbBaoCaoDoanhSo.AutoSize = true;
            this.lbBaoCaoDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCaoDoanhSo.ForeColor = System.Drawing.Color.Transparent;
            this.lbBaoCaoDoanhSo.Location = new System.Drawing.Point(189, 14);
            this.lbBaoCaoDoanhSo.Name = "lbBaoCaoDoanhSo";
            this.lbBaoCaoDoanhSo.Size = new System.Drawing.Size(529, 58);
            this.lbBaoCaoDoanhSo.TabIndex = 0;
            this.lbBaoCaoDoanhSo.Text = "BÁO CÁO DOANH SỐ";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.ForeColor = System.Drawing.Color.Transparent;
            this.lbThang.Location = new System.Drawing.Point(331, 86);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 1;
            this.lbThang.Text = "Tháng:";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.AutoSize = true;
            this.lbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.ForeColor = System.Drawing.Color.Transparent;
            this.lbNguoiLap.Location = new System.Drawing.Point(102, 138);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Size = new System.Drawing.Size(84, 20);
            this.lbNguoiLap.TabIndex = 2;
            this.lbNguoiLap.Text = "Người lập:";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.ForeColor = System.Drawing.Color.Transparent;
            this.lbNgayLap.Location = new System.Drawing.Point(559, 138);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(79, 20);
            this.lbNgayLap.TabIndex = 3;
            this.lbNgayLap.Text = "Ngày lập:";
            // 
            // lbChiTietBaoCao
            // 
            this.lbChiTietBaoCao.AutoSize = true;
            this.lbChiTietBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietBaoCao.ForeColor = System.Drawing.Color.Transparent;
            this.lbChiTietBaoCao.Location = new System.Drawing.Point(102, 182);
            this.lbChiTietBaoCao.Name = "lbChiTietBaoCao";
            this.lbChiTietBaoCao.Size = new System.Drawing.Size(131, 20);
            this.lbChiTietBaoCao.TabIndex = 4;
            this.lbChiTietBaoCao.Text = "Chi tiết báo cáo:";
            // 
            // dtgvChiTietBaoCao
            // 
            this.dtgvChiTietBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDaiLy,
            this.SoLuongPhieuDaXuat,
            this.TongGiaTri,
            this.TiLe,
            this.GhiChu});
            this.dtgvChiTietBaoCao.Location = new System.Drawing.Point(106, 205);
            this.dtgvChiTietBaoCao.Name = "dtgvChiTietBaoCao";
            this.dtgvChiTietBaoCao.RowTemplate.Height = 24;
            this.dtgvChiTietBaoCao.Size = new System.Drawing.Size(773, 284);
            this.dtgvChiTietBaoCao.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaDaiLy
            // 
            this.MaDaiLy.HeaderText = "Mã đại lý";
            this.MaDaiLy.Name = "MaDaiLy";
            // 
            // SoLuongPhieuDaXuat
            // 
            this.SoLuongPhieuDaXuat.HeaderText = "Số lượng phiếu đã xuất";
            this.SoLuongPhieuDaXuat.Name = "SoLuongPhieuDaXuat";
            // 
            // TongGiaTri
            // 
            this.TongGiaTri.HeaderText = "Tổng giá trị";
            this.TongGiaTri.Name = "TongGiaTri";
            // 
            // TiLe
            // 
            this.TiLe.HeaderText = "Tỉ lệ";
            this.TiLe.Name = "TiLe";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // txbThang
            // 
            this.txbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThang.Location = new System.Drawing.Point(397, 86);
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(116, 26);
            this.txbThang.TabIndex = 6;
            // 
            // txbNguoiLap
            // 
            this.txbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNguoiLap.Location = new System.Drawing.Point(195, 136);
            this.txbNguoiLap.Name = "txbNguoiLap";
            this.txbNguoiLap.Size = new System.Drawing.Size(228, 26);
            this.txbNguoiLap.TabIndex = 7;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(647, 136);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(232, 22);
            this.dtpNgayLap.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(106, 520);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(151, 45);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(315, 520);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(151, 45);
            this.btnChinhSua.TabIndex = 10;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(526, 520);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 45);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(728, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 45);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ucBaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txbNguoiLap);
            this.Controls.Add(this.txbThang);
            this.Controls.Add(this.dtgvChiTietBaoCao);
            this.Controls.Add(this.lbChiTietBaoCao);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbNguoiLap);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbBaoCaoDoanhSo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucBaoCaoDoanhSo";
            this.Size = new System.Drawing.Size(975, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBaoCaoDoanhSo;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbNguoiLap;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbChiTietBaoCao;
        private System.Windows.Forms.DataGridView dtgvChiTietBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongPhieuDaXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.TextBox txbNguoiLap;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

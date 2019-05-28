namespace QL_DaiLyXeMay.NhanVien
{
    partial class ucBaoCaoNoCong
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txbNguoiLap = new System.Windows.Forms.TextBox();
            this.txbThang = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgvChiTietBaoCao = new System.Windows.Forms.DataGridView();
            this.lbChiTietBaoCao = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbNguoiLap = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.lbBaoCaoNoCong = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhatSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoCuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(725, 551);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(151, 45);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(312, 551);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(151, 45);
            this.btnChinhSua.TabIndex = 23;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(103, 551);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(151, 45);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Location = new System.Drawing.Point(644, 167);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(232, 22);
            this.dtpNgayLap.TabIndex = 21;
            // 
            // txbNguoiLap
            // 
            this.txbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNguoiLap.Location = new System.Drawing.Point(189, 167);
            this.txbNguoiLap.Name = "txbNguoiLap";
            this.txbNguoiLap.Size = new System.Drawing.Size(228, 26);
            this.txbNguoiLap.TabIndex = 20;
            // 
            // txbThang
            // 
            this.txbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThang.Location = new System.Drawing.Point(394, 117);
            this.txbThang.Name = "txbThang";
            this.txbThang.Size = new System.Drawing.Size(116, 26);
            this.txbThang.TabIndex = 19;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(523, 551);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 45);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtgvChiTietBaoCao
            // 
            this.dtgvChiTietBaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChiTietBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietBaoCao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaDaiLy,
            this.NoDau,
            this.PhatSinh,
            this.NoCuoi,
            this.GhiChu});
            this.dtgvChiTietBaoCao.Location = new System.Drawing.Point(103, 236);
            this.dtgvChiTietBaoCao.Name = "dtgvChiTietBaoCao";
            this.dtgvChiTietBaoCao.RowTemplate.Height = 24;
            this.dtgvChiTietBaoCao.Size = new System.Drawing.Size(773, 284);
            this.dtgvChiTietBaoCao.TabIndex = 18;
            // 
            // lbChiTietBaoCao
            // 
            this.lbChiTietBaoCao.AutoSize = true;
            this.lbChiTietBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.lbChiTietBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChiTietBaoCao.ForeColor = System.Drawing.Color.Transparent;
            this.lbChiTietBaoCao.Location = new System.Drawing.Point(99, 213);
            this.lbChiTietBaoCao.Name = "lbChiTietBaoCao";
            this.lbChiTietBaoCao.Size = new System.Drawing.Size(131, 20);
            this.lbChiTietBaoCao.TabIndex = 17;
            this.lbChiTietBaoCao.Text = "Chi tiết báo cáo:";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.BackColor = System.Drawing.Color.Transparent;
            this.lbNgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayLap.ForeColor = System.Drawing.Color.Transparent;
            this.lbNgayLap.Location = new System.Drawing.Point(559, 169);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(79, 20);
            this.lbNgayLap.TabIndex = 16;
            this.lbNgayLap.Text = "Ngày lập:";
            // 
            // lbNguoiLap
            // 
            this.lbNguoiLap.AutoSize = true;
            this.lbNguoiLap.BackColor = System.Drawing.Color.Transparent;
            this.lbNguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNguoiLap.ForeColor = System.Drawing.Color.Transparent;
            this.lbNguoiLap.Location = new System.Drawing.Point(99, 169);
            this.lbNguoiLap.Name = "lbNguoiLap";
            this.lbNguoiLap.Size = new System.Drawing.Size(84, 20);
            this.lbNguoiLap.TabIndex = 15;
            this.lbNguoiLap.Text = "Người lập:";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.BackColor = System.Drawing.Color.Transparent;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.ForeColor = System.Drawing.Color.Transparent;
            this.lbThang.Location = new System.Drawing.Point(328, 117);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 14;
            this.lbThang.Text = "Tháng:";
            // 
            // lbBaoCaoNoCong
            // 
            this.lbBaoCaoNoCong.AutoSize = true;
            this.lbBaoCaoNoCong.BackColor = System.Drawing.Color.Transparent;
            this.lbBaoCaoNoCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCaoNoCong.ForeColor = System.Drawing.Color.Transparent;
            this.lbBaoCaoNoCong.Location = new System.Drawing.Point(186, 45);
            this.lbBaoCaoNoCong.Name = "lbBaoCaoNoCong";
            this.lbBaoCaoNoCong.Size = new System.Drawing.Size(502, 58);
            this.lbBaoCaoNoCong.TabIndex = 13;
            this.lbBaoCaoNoCong.Text = "BÁO CÁO NỢ CÔNG";
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
            // NoDau
            // 
            this.NoDau.HeaderText = "Nợ đầu";
            this.NoDau.Name = "NoDau";
            // 
            // PhatSinh
            // 
            this.PhatSinh.HeaderText = "Phát sinh";
            this.PhatSinh.Name = "PhatSinh";
            // 
            // NoCuoi
            // 
            this.NoCuoi.HeaderText = "Nợ cuối";
            this.NoCuoi.Name = "NoCuoi";
            // 
            // GhiChu
            // 
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // ucBaoCaoNoCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.txbNguoiLap);
            this.Controls.Add(this.txbThang);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgvChiTietBaoCao);
            this.Controls.Add(this.lbChiTietBaoCao);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbNguoiLap);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbBaoCaoNoCong);
            this.Name = "ucBaoCaoNoCong";
            this.Size = new System.Drawing.Size(975, 640);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txbNguoiLap;
        private System.Windows.Forms.TextBox txbThang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvChiTietBaoCao;
        private System.Windows.Forms.Label lbChiTietBaoCao;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbNguoiLap;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Label lbBaoCaoNoCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhatSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoCuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

namespace QL_DaiLyXeMay.QuanTriVien
{
    partial class ucQuanTriVien
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
            this.lbCapQuyenTruyCap = new System.Windows.Forms.Label();
            this.dtgvDanhSachCapQuyen = new System.Windows.Forms.DataGridView();
            this.lbDanhSachCapQuyen = new System.Windows.Forms.Label();
            this.lbMaNhanVien = new System.Windows.Forms.Label();
            this.lbChucVu = new System.Windows.Forms.Label();
            this.txbMaNhanVien = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.txbTenNhanVien = new System.Windows.Forms.TextBox();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btnCapMatKhau = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtgvTempData = new System.Windows.Forms.DataGridView();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCapQuyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTempData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCapQuyenTruyCap
            // 
            this.lbCapQuyenTruyCap.AutoSize = true;
            this.lbCapQuyenTruyCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapQuyenTruyCap.ForeColor = System.Drawing.Color.Transparent;
            this.lbCapQuyenTruyCap.Location = new System.Drawing.Point(248, 20);
            this.lbCapQuyenTruyCap.Name = "lbCapQuyenTruyCap";
            this.lbCapQuyenTruyCap.Size = new System.Drawing.Size(581, 58);
            this.lbCapQuyenTruyCap.TabIndex = 1;
            this.lbCapQuyenTruyCap.Text = "CẤP QUYỀN TRUY CẬP";
            // 
            // dtgvDanhSachCapQuyen
            // 
            this.dtgvDanhSachCapQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachCapQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachCapQuyen.Location = new System.Drawing.Point(141, 118);
            this.dtgvDanhSachCapQuyen.Name = "dtgvDanhSachCapQuyen";
            this.dtgvDanhSachCapQuyen.ReadOnly = true;
            this.dtgvDanhSachCapQuyen.RowTemplate.Height = 24;
            this.dtgvDanhSachCapQuyen.Size = new System.Drawing.Size(422, 523);
            this.dtgvDanhSachCapQuyen.TabIndex = 2;
            this.dtgvDanhSachCapQuyen.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvDanhSachCapQuyen_CellMouseClick);
            // 
            // lbDanhSachCapQuyen
            // 
            this.lbDanhSachCapQuyen.AutoSize = true;
            this.lbDanhSachCapQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCapQuyen.ForeColor = System.Drawing.Color.Transparent;
            this.lbDanhSachCapQuyen.Location = new System.Drawing.Point(151, 89);
            this.lbDanhSachCapQuyen.Name = "lbDanhSachCapQuyen";
            this.lbDanhSachCapQuyen.Size = new System.Drawing.Size(222, 26);
            this.lbDanhSachCapQuyen.TabIndex = 3;
            this.lbDanhSachCapQuyen.Text = "Danh sách cấp quyền";
            // 
            // lbMaNhanVien
            // 
            this.lbMaNhanVien.AutoSize = true;
            this.lbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.lbMaNhanVien.Location = new System.Drawing.Point(579, 190);
            this.lbMaNhanVien.Name = "lbMaNhanVien";
            this.lbMaNhanVien.Size = new System.Drawing.Size(113, 20);
            this.lbMaNhanVien.TabIndex = 4;
            this.lbMaNhanVien.Text = "Mã nhân viên:";
            // 
            // lbChucVu
            // 
            this.lbChucVu.AutoSize = true;
            this.lbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChucVu.ForeColor = System.Drawing.Color.Transparent;
            this.lbChucVu.Location = new System.Drawing.Point(579, 305);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(75, 20);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "Chức vụ:";
            // 
            // txbMaNhanVien
            // 
            this.txbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNhanVien.Location = new System.Drawing.Point(713, 187);
            this.txbMaNhanVien.Name = "txbMaNhanVien";
            this.txbMaNhanVien.Size = new System.Drawing.Size(243, 26);
            this.txbMaNhanVien.TabIndex = 6;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChucVu.Location = new System.Drawing.Point(713, 299);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.Size = new System.Drawing.Size(243, 26);
            this.txbChucVu.TabIndex = 7;
            // 
            // txbTenNhanVien
            // 
            this.txbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNhanVien.Location = new System.Drawing.Point(713, 242);
            this.txbTenNhanVien.Name = "txbTenNhanVien";
            this.txbTenNhanVien.Size = new System.Drawing.Size(243, 26);
            this.txbTenNhanVien.TabIndex = 9;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.lbTenNhanVien.Location = new System.Drawing.Point(579, 245);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(118, 20);
            this.lbTenNhanVien.TabIndex = 8;
            this.lbTenNhanVien.Text = "Tên nhân viên:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(713, 363);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(243, 26);
            this.txbMatKhau.TabIndex = 11;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.Transparent;
            this.lbMatKhau.Location = new System.Drawing.Point(579, 369);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(82, 20);
            this.lbMatKhau.TabIndex = 10;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // btnCapMatKhau
            // 
            this.btnCapMatKhau.Location = new System.Drawing.Point(962, 354);
            this.btnCapMatKhau.Name = "btnCapMatKhau";
            this.btnCapMatKhau.Size = new System.Drawing.Size(75, 47);
            this.btnCapMatKhau.TabIndex = 12;
            this.btnCapMatKhau.Text = "Cấp mật khẩu";
            this.btnCapMatKhau.UseVisualStyleBackColor = true;
            this.btnCapMatKhau.Click += new System.EventHandler(this.btnCapMatKhau_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(588, 470);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(167, 29);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(808, 470);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(139, 29);
            this.btnChinhSua.TabIndex = 14;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(588, 530);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(167, 29);
            this.btnXoaTaiKhoan.TabIndex = 15;
            this.btnXoaTaiKhoan.Text = "Xóa tài khoản";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(808, 530);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(139, 29);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dtgvTempData
            // 
            this.dtgvTempData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTempData.Location = new System.Drawing.Point(762, 680);
            this.dtgvTempData.Name = "dtgvTempData";
            this.dtgvTempData.RowTemplate.Height = 24;
            this.dtgvTempData.Size = new System.Drawing.Size(240, 131);
            this.dtgvTempData.TabIndex = 18;
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(703, 420);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(154, 29);
            this.btnTaoTaiKhoan.TabIndex = 19;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // ucQuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.dtgvTempData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTaiKhoan);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCapMatKhau);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.txbTenNhanVien);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.txbChucVu);
            this.Controls.Add(this.txbMaNhanVien);
            this.Controls.Add(this.lbChucVu);
            this.Controls.Add(this.lbMaNhanVien);
            this.Controls.Add(this.lbDanhSachCapQuyen);
            this.Controls.Add(this.dtgvDanhSachCapQuyen);
            this.Controls.Add(this.lbCapQuyenTruyCap);
            this.Name = "ucQuanTriVien";
            this.Size = new System.Drawing.Size(1193, 644);
            this.Load += new System.EventHandler(this.ucQuanTriVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCapQuyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTempData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCapQuyenTruyCap;
        private System.Windows.Forms.DataGridView dtgvDanhSachCapQuyen;
        private System.Windows.Forms.Label lbDanhSachCapQuyen;
        private System.Windows.Forms.Label lbMaNhanVien;
        private System.Windows.Forms.Label lbChucVu;
        private System.Windows.Forms.TextBox txbMaNhanVien;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.TextBox txbTenNhanVien;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Button btnCapMatKhau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dtgvTempData;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
    }
}

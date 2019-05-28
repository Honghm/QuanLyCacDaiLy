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
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachCapQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCapQuyenTruyCap
            // 
            this.lbCapQuyenTruyCap.AutoSize = true;
            this.lbCapQuyenTruyCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCapQuyenTruyCap.ForeColor = System.Drawing.Color.Transparent;
            this.lbCapQuyenTruyCap.Location = new System.Drawing.Point(248, 23);
            this.lbCapQuyenTruyCap.Name = "lbCapQuyenTruyCap";
            this.lbCapQuyenTruyCap.Size = new System.Drawing.Size(581, 58);
            this.lbCapQuyenTruyCap.TabIndex = 1;
            this.lbCapQuyenTruyCap.Text = "CẤP QUYỀN TRUY CẬP";
            // 
            // dtgvDanhSachCapQuyen
            // 
            this.dtgvDanhSachCapQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDanhSachCapQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachCapQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNhanVien,
            this.MatKhau});
            this.dtgvDanhSachCapQuyen.Location = new System.Drawing.Point(141, 133);
            this.dtgvDanhSachCapQuyen.Name = "dtgvDanhSachCapQuyen";
            this.dtgvDanhSachCapQuyen.RowTemplate.Height = 24;
            this.dtgvDanhSachCapQuyen.Size = new System.Drawing.Size(422, 538);
            this.dtgvDanhSachCapQuyen.TabIndex = 2;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaNhanVien
            // 
            this.MaNhanVien.HeaderText = "Mã nhân viên";
            this.MaNhanVien.Name = "MaNhanVien";
            // 
            // MatKhau
            // 
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // lbDanhSachCapQuyen
            // 
            this.lbDanhSachCapQuyen.AutoSize = true;
            this.lbDanhSachCapQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachCapQuyen.ForeColor = System.Drawing.Color.Transparent;
            this.lbDanhSachCapQuyen.Location = new System.Drawing.Point(151, 104);
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
            this.lbMaNhanVien.Location = new System.Drawing.Point(579, 205);
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
            this.lbChucVu.Location = new System.Drawing.Point(579, 320);
            this.lbChucVu.Name = "lbChucVu";
            this.lbChucVu.Size = new System.Drawing.Size(75, 20);
            this.lbChucVu.TabIndex = 5;
            this.lbChucVu.Text = "Chức vụ:";
            // 
            // txbMaNhanVien
            // 
            this.txbMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaNhanVien.Location = new System.Drawing.Point(704, 202);
            this.txbMaNhanVien.Name = "txbMaNhanVien";
            this.txbMaNhanVien.Size = new System.Drawing.Size(243, 26);
            this.txbMaNhanVien.TabIndex = 6;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbChucVu.Location = new System.Drawing.Point(704, 314);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.Size = new System.Drawing.Size(243, 26);
            this.txbChucVu.TabIndex = 7;
            
            // 
            // txbTenNhanVien
            // 
            this.txbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenNhanVien.Location = new System.Drawing.Point(704, 257);
            this.txbTenNhanVien.Name = "txbTenNhanVien";
            this.txbTenNhanVien.Size = new System.Drawing.Size(243, 26);
            this.txbTenNhanVien.TabIndex = 9;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.lbTenNhanVien.Location = new System.Drawing.Point(579, 260);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(118, 20);
            this.lbTenNhanVien.TabIndex = 8;
            this.lbTenNhanVien.Text = "Tên nhân viên:";
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(704, 378);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(243, 26);
            this.txbMatKhau.TabIndex = 11;
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.ForeColor = System.Drawing.Color.Transparent;
            this.lbMatKhau.Location = new System.Drawing.Point(579, 384);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(82, 20);
            this.lbMatKhau.TabIndex = 10;
            this.lbMatKhau.Text = "Mật khẩu:";
            // 
            // btnCapMatKhau
            // 
            this.btnCapMatKhau.Location = new System.Drawing.Point(953, 369);
            this.btnCapMatKhau.Name = "btnCapMatKhau";
            this.btnCapMatKhau.Size = new System.Drawing.Size(75, 47);
            this.btnCapMatKhau.TabIndex = 12;
            this.btnCapMatKhau.Text = "Cấp mật khẩu";
            this.btnCapMatKhau.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(588, 457);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 29);
            this.btnLuu.TabIndex = 13;
            this.btnLuu.Text = "Lưu thông tin";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(832, 457);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(115, 29);
            this.btnChinhSua.TabIndex = 14;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(588, 517);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(143, 29);
            this.btnXoaTaiKhoan.TabIndex = 15;
            this.btnXoaTaiKhoan.Text = "Xóa tài khoản";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(832, 517);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 29);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ucQuanTriVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
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
            this.Size = new System.Drawing.Size(1193, 674);
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCapQuyenTruyCap;
        private System.Windows.Forms.DataGridView dtgvDanhSachCapQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
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
    }
}

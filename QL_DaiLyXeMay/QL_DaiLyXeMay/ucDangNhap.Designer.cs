namespace QL_DaiLyXeMay
{
    partial class ucDangNhap
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
            this.llbDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // llbDoiMatKhau
            // 
            this.llbDoiMatKhau.AutoSize = true;
            this.llbDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.llbDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbDoiMatKhau.Location = new System.Drawing.Point(825, 445);
            this.llbDoiMatKhau.Name = "llbDoiMatKhau";
            this.llbDoiMatKhau.Size = new System.Drawing.Size(141, 26);
            this.llbDoiMatKhau.TabIndex = 8;
            this.llbDoiMatKhau.TabStop = true;
            this.llbDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(810, 513);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(199, 39);
            this.lbDangNhap.TabIndex = 5;
            this.lbDangNhap.Text = "Đăng Nhập";
            this.lbDangNhap.Click += new System.EventHandler(this.lbDangNhap_Click);
            this.lbDangNhap.MouseLeave += new System.EventHandler(this.lbDangNhap_MouseLeave);
            this.lbDangNhap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbDangNhap_MouseMove);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txbMatKhau.Location = new System.Drawing.Point(794, 380);
            this.txbMatKhau.Multiline = true;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.ReadOnly = true;
            this.txbMatKhau.Size = new System.Drawing.Size(267, 57);
            this.txbMatKhau.TabIndex = 7;
            this.txbMatKhau.Text = "Nhập mật khẩu";
            this.txbMatKhau.Click += new System.EventHandler(this.txbMatKhau_Click);
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txbTaiKhoan.Location = new System.Drawing.Point(794, 272);
            this.txbTaiKhoan.Multiline = true;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.ReadOnly = true;
            this.txbTaiKhoan.Size = new System.Drawing.Size(267, 57);
            this.txbTaiKhoan.TabIndex = 6;
            this.txbTaiKhoan.Text = "Nhập tài khoản";
            this.txbTaiKhoan.Click += new System.EventHandler(this.txbTaiKhoan_Click);
            // 
            // ucDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::QL_DaiLyXeMay.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.llbDoiMatKhau);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Name = "ucDangNhap";
            this.Size = new System.Drawing.Size(1193, 674);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llbDoiMatKhau;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbTaiKhoan;
    }
}

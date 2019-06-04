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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDangNhap));
            this.llbDoiMatKhau = new System.Windows.Forms.LinkLabel();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTaiKhoan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // llbDoiMatKhau
            // 
            this.llbDoiMatKhau.AutoSize = true;
            this.llbDoiMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(95)))), ((int)(((byte)(93)))));
            this.llbDoiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbDoiMatKhau.Location = new System.Drawing.Point(791, 441);
            this.llbDoiMatKhau.Name = "llbDoiMatKhau";
            this.llbDoiMatKhau.Size = new System.Drawing.Size(141, 26);
            this.llbDoiMatKhau.TabIndex = 12;
            this.llbDoiMatKhau.TabStop = true;
            this.llbDoiMatKhau.Text = "Đổi mật khẩu";
            this.llbDoiMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbDoiMatKhau_LinkClicked);
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.BackColor = System.Drawing.Color.Turquoise;
            this.lbDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(807, 514);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(199, 39);
            this.lbDangNhap.TabIndex = 3;
            this.lbDangNhap.Text = "Đăng Nhập";
            this.lbDangNhap.Click += new System.EventHandler(this.lbDangNhap_Click);
            this.lbDangNhap.MouseLeave += new System.EventHandler(this.lbDangNhap_MouseLeave);
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txbMatKhau.Location = new System.Drawing.Point(796, 379);
            this.txbMatKhau.Multiline = true;
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.ReadOnly = true;
            this.txbMatKhau.Size = new System.Drawing.Size(267, 57);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.Text = "Nhập mật khẩu";
            this.txbMatKhau.UseSystemPasswordChar = true;
            this.txbMatKhau.Click += new System.EventHandler(this.txbMatKhau_Click);
            // 
            // txbTaiKhoan
            // 
            this.txbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txbTaiKhoan.Location = new System.Drawing.Point(796, 272);
            this.txbTaiKhoan.Multiline = true;
            this.txbTaiKhoan.Name = "txbTaiKhoan";
            this.txbTaiKhoan.Size = new System.Drawing.Size(267, 57);
            this.txbTaiKhoan.TabIndex = 1;
            this.txbTaiKhoan.Text = "Nhập tài khoản";
            this.txbTaiKhoan.Click += new System.EventHandler(this.txbTaiKhoan_Click);
            this.txbTaiKhoan.TextChanged += new System.EventHandler(this.txbTaiKhoan_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1193, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ucDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.llbDoiMatKhau);
            this.Controls.Add(this.lbDangNhap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTaiKhoan);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucDangNhap";
            this.Size = new System.Drawing.Size(1193, 674);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel llbDoiMatKhau;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.TextBox txbMatKhau;
        public System.Windows.Forms.TextBox txbTaiKhoan;

    }
}

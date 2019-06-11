namespace QL_DaiLyXeMay
{
    partial class frmTrangChu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnTrangChu = new System.Windows.Forms.Panel();
            this.msNhanVien = new System.Windows.Forms.MenuStrip();
            this.tsmiTuyChon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDangNhapLai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.msNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTrangChu
            // 
            this.pnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.pnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTrangChu.Location = new System.Drawing.Point(-1, 31);
            this.pnTrangChu.Name = "pnTrangChu";
            this.pnTrangChu.Size = new System.Drawing.Size(1193, 644);
            this.pnTrangChu.TabIndex = 0;
            // 
            // msNhanVien
            // 
            this.msNhanVien.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msNhanVien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTuyChon,
            this.tsmiTroGiup,
            this.tsmiLienHe});
            this.msNhanVien.Location = new System.Drawing.Point(0, 0);
            this.msNhanVien.Name = "msNhanVien";
            this.msNhanVien.Size = new System.Drawing.Size(1192, 28);
            this.msNhanVien.TabIndex = 2;
            this.msNhanVien.Text = "menuStrip1";
            // 
            // tsmiTuyChon
            // 
            this.tsmiTuyChon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDangNhapLai,
            this.tsmiThoat});
            this.tsmiTuyChon.Name = "tsmiTuyChon";
            this.tsmiTuyChon.Size = new System.Drawing.Size(80, 24);
            this.tsmiTuyChon.Text = "Tùy chọn";
            // 
            // tsmiDangNhapLai
            // 
            this.tsmiDangNhapLai.Name = "tsmiDangNhapLai";
            this.tsmiDangNhapLai.Size = new System.Drawing.Size(213, 26);
            this.tsmiDangNhapLai.Text = "Quay lại đăng nhập";
            this.tsmiDangNhapLai.Click += new System.EventHandler(this.tsmiDangNhapLai_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(213, 26);
            this.tsmiThoat.Text = "Thoát";
            // 
            // tsmiTroGiup
            // 
            this.tsmiTroGiup.Name = "tsmiTroGiup";
            this.tsmiTroGiup.Size = new System.Drawing.Size(76, 24);
            this.tsmiTroGiup.Text = "Trợ giúp";
            // 
            // tsmiLienHe
            // 
            this.tsmiLienHe.Name = "tsmiLienHe";
            this.tsmiLienHe.Size = new System.Drawing.Size(68, 24);
            this.tsmiLienHe.Text = "Liên hệ";
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1192, 676);
            this.Controls.Add(this.msNhanVien);
            this.Controls.Add(this.pnTrangChu);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.msNhanVien.ResumeLayout(false);
            this.msNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnTrangChu;
        private System.Windows.Forms.MenuStrip msNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiTuyChon;
        private System.Windows.Forms.ToolStripMenuItem tsmiDangNhapLai;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.ToolStripMenuItem tsmiTroGiup;
        private System.Windows.Forms.ToolStripMenuItem tsmiLienHe;
    }
}
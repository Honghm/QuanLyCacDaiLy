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
            this.lbBaoCaoNoCong = new System.Windows.Forms.Label();
            this.lbThang = new System.Windows.Forms.Label();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.grbChiTietBaoCao = new System.Windows.Forms.GroupBox();
            this.rpvBaoCaoCongNo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grbChiTietBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBaoCaoNoCong
            // 
            this.lbBaoCaoNoCong.AutoSize = true;
            this.lbBaoCaoNoCong.BackColor = System.Drawing.Color.Transparent;
            this.lbBaoCaoNoCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCaoNoCong.ForeColor = System.Drawing.Color.Transparent;
            this.lbBaoCaoNoCong.Location = new System.Drawing.Point(250, 21);
            this.lbBaoCaoNoCong.Name = "lbBaoCaoNoCong";
            this.lbBaoCaoNoCong.Size = new System.Drawing.Size(502, 58);
            this.lbBaoCaoNoCong.TabIndex = 13;
            this.lbBaoCaoNoCong.Text = "BÁO CÁO NỢ CÔNG";
            // 
            // lbThang
            // 
            this.lbThang.AutoSize = true;
            this.lbThang.BackColor = System.Drawing.Color.Transparent;
            this.lbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThang.ForeColor = System.Drawing.Color.Transparent;
            this.lbThang.Location = new System.Drawing.Point(345, 90);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 14;
            this.lbThang.Text = "Tháng:";
            // 
            // cbbThang
            // 
            this.cbbThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(411, 90);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 28);
            this.cbbThang.TabIndex = 30;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(567, 82);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(143, 39);
            this.btnTaoBaoCao.TabIndex = 31;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.BtnTaoBaoCao_Click);
            // 
            // grbChiTietBaoCao
            // 
            this.grbChiTietBaoCao.Controls.Add(this.rpvBaoCaoCongNo);
            this.grbChiTietBaoCao.Location = new System.Drawing.Point(3, 127);
            this.grbChiTietBaoCao.Name = "grbChiTietBaoCao";
            this.grbChiTietBaoCao.Size = new System.Drawing.Size(969, 500);
            this.grbChiTietBaoCao.TabIndex = 32;
            this.grbChiTietBaoCao.TabStop = false;
            this.grbChiTietBaoCao.Text = "Chi tiết báo cáo";
            // 
            // rpvBaoCaoCongNo
            // 
            this.rpvBaoCaoCongNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBaoCaoCongNo.Location = new System.Drawing.Point(3, 18);
            this.rpvBaoCaoCongNo.Name = "rpvBaoCaoCongNo";
            this.rpvBaoCaoCongNo.ServerReport.BearerToken = null;
            this.rpvBaoCaoCongNo.Size = new System.Drawing.Size(963, 479);
            this.rpvBaoCaoCongNo.TabIndex = 0;
            // 
            // ucBaoCaoNoCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.grbChiTietBaoCao);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbBaoCaoNoCong);
            this.Name = "ucBaoCaoNoCong";
            this.Size = new System.Drawing.Size(975, 640);
            this.Load += new System.EventHandler(this.ucBaoCaoNoCong_Load);
            this.grbChiTietBaoCao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbBaoCaoNoCong;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.GroupBox grbChiTietBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCaoCongNo;
    }
}

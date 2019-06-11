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
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.grbChiTietBaoCao = new System.Windows.Forms.GroupBox();
            this.rpvBCDSThang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.grbChiTietBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBaoCaoDoanhSo
            // 
            this.lbBaoCaoDoanhSo.AutoSize = true;
            this.lbBaoCaoDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCaoDoanhSo.ForeColor = System.Drawing.Color.Transparent;
            this.lbBaoCaoDoanhSo.Location = new System.Drawing.Point(306, 13);
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
            this.lbThang.Location = new System.Drawing.Point(312, 89);
            this.lbThang.Name = "lbThang";
            this.lbThang.Size = new System.Drawing.Size(60, 20);
            this.lbThang.TabIndex = 1;
            this.lbThang.Text = "Tháng:";
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoBaoCao.Location = new System.Drawing.Point(645, 80);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(171, 34);
            this.btnTaoBaoCao.TabIndex = 11;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            this.btnTaoBaoCao.Click += new System.EventHandler(this.BtnTaoBaoCao_Click);
            // 
            // cbbThang
            // 
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
            this.cbbThang.Location = new System.Drawing.Point(409, 85);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(208, 24);
            this.cbbThang.TabIndex = 18;
            // 
            // grbChiTietBaoCao
            // 
            this.grbChiTietBaoCao.Controls.Add(this.rpvBCDSThang);
            this.grbChiTietBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.grbChiTietBaoCao.Location = new System.Drawing.Point(3, 120);
            this.grbChiTietBaoCao.Name = "grbChiTietBaoCao";
            this.grbChiTietBaoCao.Size = new System.Drawing.Size(969, 520);
            this.grbChiTietBaoCao.TabIndex = 20;
            this.grbChiTietBaoCao.TabStop = false;
            this.grbChiTietBaoCao.Text = "Chi tiết báo cáo";
            // 
            // rpvBCDSThang
            // 
            this.rpvBCDSThang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBCDSThang.Location = new System.Drawing.Point(3, 22);
            this.rpvBCDSThang.Name = "rpvBCDSThang";
            this.rpvBCDSThang.ServerReport.BearerToken = null;
            this.rpvBCDSThang.Size = new System.Drawing.Size(963, 495);
            this.rpvBCDSThang.TabIndex = 18;
            // 
            // ucBaoCaoDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.grbChiTietBaoCao);
            this.Controls.Add(this.cbbThang);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.lbThang);
            this.Controls.Add(this.lbBaoCaoDoanhSo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ucBaoCaoDoanhSo";
            this.Size = new System.Drawing.Size(975, 640);
            this.grbChiTietBaoCao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBaoCaoDoanhSo;
        private System.Windows.Forms.Label lbThang;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.GroupBox grbChiTietBaoCao;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBCDSThang;
    }
}

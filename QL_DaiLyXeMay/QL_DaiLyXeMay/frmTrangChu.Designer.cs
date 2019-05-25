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
            this.SuspendLayout();
            // 
            // pnTrangChu
            // 
            this.pnTrangChu.BackColor = System.Drawing.Color.Transparent;
            this.pnTrangChu.BackgroundImage = global::QL_DaiLyXeMay.Properties.Resources.ViewMain;
            this.pnTrangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnTrangChu.Location = new System.Drawing.Point(-1, 1);
            this.pnTrangChu.Name = "pnTrangChu";
            this.pnTrangChu.Size = new System.Drawing.Size(1193, 674);
            this.pnTrangChu.TabIndex = 0;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 676);
            this.Controls.Add(this.pnTrangChu);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.Load += new System.EventHandler(this.frmTrangChu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnTrangChu;
    }
}
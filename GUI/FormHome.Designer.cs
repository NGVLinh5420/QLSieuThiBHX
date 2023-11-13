namespace QLSieuThiBHX
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.msQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.msiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.msiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.msiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.msiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.msThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.msXuatFile = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBHX = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msQuanLy,
            this.msThongKe,
            this.msXuatFile});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // msQuanLy
            // 
            this.msQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiNhanVien,
            this.msiKhachHang,
            this.msiSanPham,
            this.msiHoaDon});
            this.msQuanLy.Name = "msQuanLy";
            resources.ApplyResources(this.msQuanLy, "msQuanLy");
            // 
            // msiNhanVien
            // 
            this.msiNhanVien.Name = "msiNhanVien";
            resources.ApplyResources(this.msiNhanVien, "msiNhanVien");
            this.msiNhanVien.Click += new System.EventHandler(this.msiNhanVien_Click);
            // 
            // msiKhachHang
            // 
            this.msiKhachHang.Name = "msiKhachHang";
            resources.ApplyResources(this.msiKhachHang, "msiKhachHang");
            this.msiKhachHang.Click += new System.EventHandler(this.msiKhachHang_Click);
            // 
            // msiSanPham
            // 
            this.msiSanPham.Name = "msiSanPham";
            resources.ApplyResources(this.msiSanPham, "msiSanPham");
            this.msiSanPham.Click += new System.EventHandler(this.msiSanPham_Click);
            // 
            // msiHoaDon
            // 
            this.msiHoaDon.Name = "msiHoaDon";
            resources.ApplyResources(this.msiHoaDon, "msiHoaDon");
            this.msiHoaDon.Click += new System.EventHandler(this.msiHoaDon_Click);
            // 
            // msThongKe
            // 
            this.msThongKe.Name = "msThongKe";
            resources.ApplyResources(this.msThongKe, "msThongKe");
            // 
            // msXuatFile
            // 
            this.msXuatFile.Name = "msXuatFile";
            resources.ApplyResources(this.msXuatFile, "msXuatFile");
            // 
            // labelBHX
            // 
            resources.ApplyResources(this.labelBHX, "labelBHX");
            this.labelBHX.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelBHX.Name = "labelBHX";
            // 
            // FormHome
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.labelBHX);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem msQuanLy;
        private System.Windows.Forms.ToolStripMenuItem msiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem msiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem msiSanPham;
        private System.Windows.Forms.ToolStripMenuItem msiHoaDon;
        private System.Windows.Forms.ToolStripMenuItem msThongKe;
        private System.Windows.Forms.ToolStripMenuItem msXuatFile;
        private System.Windows.Forms.Label labelBHX;
    }
}


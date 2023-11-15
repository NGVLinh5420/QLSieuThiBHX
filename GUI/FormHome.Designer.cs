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
            this.msThongKe_TK = new System.Windows.Forms.ToolStripMenuItem();
            this.msXuatFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDSNV = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDSKH = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDSSP = new System.Windows.Forms.ToolStripMenuItem();
            this.msiDSHD = new System.Windows.Forms.ToolStripMenuItem();
            this.labelBHX = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msQuanLy,
            this.msThongKe_TK,
            this.msXuatFile});
            this.menuStrip.Name = "menuStrip";
            // 
            // msQuanLy
            // 
            this.msQuanLy.BackColor = System.Drawing.SystemColors.MenuBar;
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
            // msThongKe_TK
            // 
            this.msThongKe_TK.Name = "msThongKe_TK";
            resources.ApplyResources(this.msThongKe_TK, "msThongKe_TK");
            // 
            // msXuatFile
            // 
            this.msXuatFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msiDSNV,
            this.msiDSKH,
            this.msiDSSP,
            this.msiDSHD});
            this.msXuatFile.Name = "msXuatFile";
            resources.ApplyResources(this.msXuatFile, "msXuatFile");
            // 
            // msiDSNV
            // 
            this.msiDSNV.Name = "msiDSNV";
            resources.ApplyResources(this.msiDSNV, "msiDSNV");
            // 
            // msiDSKH
            // 
            this.msiDSKH.Name = "msiDSKH";
            resources.ApplyResources(this.msiDSKH, "msiDSKH");
            // 
            // msiDSSP
            // 
            this.msiDSSP.Name = "msiDSSP";
            resources.ApplyResources(this.msiDSSP, "msiDSSP");
            // 
            // msiDSHD
            // 
            this.msiDSHD.Name = "msiDSHD";
            resources.ApplyResources(this.msiDSHD, "msiDSHD");
            // 
            // labelBHX
            // 
            resources.ApplyResources(this.labelBHX, "labelBHX");
            this.labelBHX.BackColor = System.Drawing.Color.Transparent;
            this.labelBHX.ForeColor = System.Drawing.Color.Lime;
            this.labelBHX.Name = "labelBHX";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
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
            this.MdiChildActivate += new System.EventHandler(this.FormHome_MdiChildActivate);
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
        private System.Windows.Forms.ToolStripMenuItem msThongKe_TK;
        private System.Windows.Forms.ToolStripMenuItem msXuatFile;
        private System.Windows.Forms.Label labelBHX;
        private System.Windows.Forms.ToolStripMenuItem msiDSNV;
        private System.Windows.Forms.ToolStripMenuItem msiDSKH;
        private System.Windows.Forms.ToolStripMenuItem msiDSSP;
        private System.Windows.Forms.ToolStripMenuItem msiDSHD;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}


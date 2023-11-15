namespace QLSieuThiBHX.GUI
{
    partial class FormThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLamMoiSP = new System.Windows.Forms.Button();
            this.btnLocNgLHD = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.ckbNLHD = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpThongKe = new System.Windows.Forms.DateTimePicker();
            this.ckbKH = new System.Windows.Forms.CheckBox();
            this.ckbNV = new System.Windows.Forms.CheckBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.cobTenKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cobTenNV = new System.Windows.Forms.ComboBox();
            this.lvChiTietHD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1382, 118);
            this.label1.TabIndex = 11;
            this.label1.Text = "THỐNG KÊ CỬA HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLamMoiSP
            // 
            this.btnLamMoiSP.AutoSize = true;
            this.btnLamMoiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoiSP.Location = new System.Drawing.Point(945, 215);
            this.btnLamMoiSP.Name = "btnLamMoiSP";
            this.btnLamMoiSP.Size = new System.Drawing.Size(178, 49);
            this.btnLamMoiSP.TabIndex = 20;
            this.btnLamMoiSP.Text = "LÀM MỚI";
            this.btnLamMoiSP.UseVisualStyleBackColor = true;
            this.btnLamMoiSP.Click += new System.EventHandler(this.btnLamMoiSP_Click);
            // 
            // btnLocNgLHD
            // 
            this.btnLocNgLHD.AutoSize = true;
            this.btnLocNgLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocNgLHD.Location = new System.Drawing.Point(782, 216);
            this.btnLocNgLHD.Name = "btnLocNgLHD";
            this.btnLocNgLHD.Size = new System.Drawing.Size(148, 48);
            this.btnLocNgLHD.TabIndex = 17;
            this.btnLocNgLHD.Text = "LỌC";
            this.btnLocNgLHD.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(108, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nhân Viên";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.ckbNLHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpThongKe);
            this.groupBox1.Controls.Add(this.ckbKH);
            this.groupBox1.Controls.Add(this.ckbNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.cobTenKH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cobTenNV);
            this.groupBox1.Controls.Add(this.btnLamMoiSP);
            this.groupBox1.Controls.Add(this.btnLocNgLHD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1382, 308);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(774, 85);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(138, 45);
            this.txtMaKH.TabIndex = 54;
            this.txtMaKH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbNLHD
            // 
            this.ckbNLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNLHD.Location = new System.Drawing.Point(416, 221);
            this.ckbNLHD.Name = "ckbNLHD";
            this.ckbNLHD.Size = new System.Drawing.Size(125, 43);
            this.ckbNLHD.TabIndex = 53;
            this.ckbNLHD.Text = "Chọn";
            this.ckbNLHD.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 25);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ngày Lập HĐ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpThongKe
            // 
            this.dtpThongKe.CustomFormat = "MM/dd/yyyy";
            this.dtpThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThongKe.Location = new System.Drawing.Point(102, 221);
            this.dtpThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.dtpThongKe.MaxDate = new System.DateTime(2500, 1, 1, 0, 0, 0, 0);
            this.dtpThongKe.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpThongKe.Name = "dtpThongKe";
            this.dtpThongKe.Size = new System.Drawing.Size(298, 45);
            this.dtpThongKe.TabIndex = 51;
            this.dtpThongKe.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // ckbKH
            // 
            this.ckbKH.AutoSize = true;
            this.ckbKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKH.Location = new System.Drawing.Point(918, 136);
            this.ckbKH.Name = "ckbKH";
            this.ckbKH.Size = new System.Drawing.Size(82, 29);
            this.ckbKH.TabIndex = 46;
            this.ckbKH.Text = "Chọn";
            this.ckbKH.UseVisualStyleBackColor = true;
            // 
            // ckbNV
            // 
            this.ckbNV.AutoSize = true;
            this.ckbNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbNV.Location = new System.Drawing.Point(250, 136);
            this.ckbNV.Name = "ckbNV";
            this.ckbNV.Size = new System.Drawing.Size(82, 29);
            this.ckbNV.TabIndex = 45;
            this.ckbNV.Text = "Chọn";
            this.ckbNV.UseVisualStyleBackColor = true;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(106, 85);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(138, 45);
            this.txtMaNV.TabIndex = 44;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cobTenKH
            // 
            this.cobTenKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobTenKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobTenKH.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobTenKH.FormattingEnabled = true;
            this.cobTenKH.Location = new System.Drawing.Point(918, 85);
            this.cobTenKH.Name = "cobTenKH";
            this.cobTenKH.Size = new System.Drawing.Size(367, 45);
            this.cobTenKH.TabIndex = 24;
            this.cobTenKH.SelectedIndexChanged += new System.EventHandler(this.LoadTextBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 37);
            this.label3.TabIndex = 23;
            this.label3.Text = "Khách Hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cobTenNV
            // 
            this.cobTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cobTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cobTenNV.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobTenNV.Location = new System.Drawing.Point(250, 85);
            this.cobTenNV.Name = "cobTenNV";
            this.cobTenNV.Size = new System.Drawing.Size(367, 45);
            this.cobTenNV.TabIndex = 21;
            this.cobTenNV.SelectedIndexChanged += new System.EventHandler(this.LoadTextBox_SelectedIndexChanged);
            // 
            // lvChiTietHD
            // 
            this.lvChiTietHD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvChiTietHD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvChiTietHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvChiTietHD.FullRowSelect = true;
            this.lvChiTietHD.GridLines = true;
            this.lvChiTietHD.HideSelection = false;
            this.lvChiTietHD.Location = new System.Drawing.Point(0, 445);
            this.lvChiTietHD.Name = "lvChiTietHD";
            this.lvChiTietHD.Size = new System.Drawing.Size(737, 298);
            this.lvChiTietHD.TabIndex = 14;
            this.lvChiTietHD.UseCompatibleStateImageBehavior = false;
            this.lvChiTietHD.View = System.Windows.Forms.View.Details;
            this.lvChiTietHD.SelectedIndexChanged += new System.EventHandler(this.lvChiTietHD_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HĐ";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày Lập HĐ";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng Giá Tiền (VND)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 264;
            // 
            // lvSanPham
            // 
            this.lvSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvSanPham.CheckBoxes = true;
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(782, 445);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(600, 298);
            this.lvSanPham.TabIndex = 29;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã SP";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên SP";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số Lượng";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader6.Width = 208;
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1382, 743);
            this.Controls.Add(this.lvSanPham);
            this.Controls.Add(this.lvChiTietHD);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLamMoiSP;
        private System.Windows.Forms.Button btnLocNgLHD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvChiTietHD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.ComboBox cobTenKH;
        private System.Windows.Forms.ComboBox cobTenNV;
        private System.Windows.Forms.CheckBox ckbNV;
        private System.Windows.Forms.CheckBox ckbKH;
        private System.Windows.Forms.CheckBox ckbNLHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpThongKe;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}
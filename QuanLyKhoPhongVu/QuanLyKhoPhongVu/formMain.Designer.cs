namespace QuanLyKhoPhongVu
{
    partial class formMain
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
            this.mn = new System.Windows.Forms.MenuStrip();
            this.mnHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeThong_DangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeThong_HuyDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnHeThong_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mnQLHDBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLapHDBH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn.SuspendLayout();
            this.SuspendLayout();
            // 
            // mn
            // 
            this.mn.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong,
            this.mnQL,
            this.mnLap,
            this.mnTimKiem,
            this.mnBaoCao});
            this.mn.Location = new System.Drawing.Point(0, 0);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(977, 28);
            this.mn.TabIndex = 1;
            this.mn.Text = "menuStrip1";
            // 
            // mnHeThong
            // 
            this.mnHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnHeThong_DangNhap,
            this.mnHeThong_HuyDN,
            this.mnHeThong_Thoat});
            this.mnHeThong.Name = "mnHeThong";
            this.mnHeThong.Size = new System.Drawing.Size(85, 24);
            this.mnHeThong.Text = "Hệ thống";
            // 
            // mnHeThong_DangNhap
            // 
            this.mnHeThong_DangNhap.Name = "mnHeThong_DangNhap";
            this.mnHeThong_DangNhap.Size = new System.Drawing.Size(168, 26);
            this.mnHeThong_DangNhap.Text = "Đăng Nhập";
            this.mnHeThong_DangNhap.Click += new System.EventHandler(this.mnHeThong_DangNhap_Click);
            // 
            // mnHeThong_HuyDN
            // 
            this.mnHeThong_HuyDN.Name = "mnHeThong_HuyDN";
            this.mnHeThong_HuyDN.Size = new System.Drawing.Size(168, 26);
            this.mnHeThong_HuyDN.Text = "Đăng Xuất";
            this.mnHeThong_HuyDN.Click += new System.EventHandler(this.mnHeThong_HuyDN_Click);
            // 
            // mnHeThong_Thoat
            // 
            this.mnHeThong_Thoat.Name = "mnHeThong_Thoat";
            this.mnHeThong_Thoat.Size = new System.Drawing.Size(168, 26);
            this.mnHeThong_Thoat.Text = "Thoát";
            // 
            // mnQL
            // 
            this.mnQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnQLSanPham,
            this.mnQLHDBH});
            this.mnQL.Name = "mnQL";
            this.mnQL.Size = new System.Drawing.Size(73, 24);
            this.mnQL.Text = "Quản lý";
            // 
            // mnQLSanPham
            // 
            this.mnQLSanPham.Name = "mnQLSanPham";
            this.mnQLSanPham.Size = new System.Drawing.Size(216, 26);
            this.mnQLSanPham.Text = "Sản phẩm";
            this.mnQLSanPham.Click += new System.EventHandler(this.mnQLSanPham_Click);
            // 
            // mnQLHDBH
            // 
            this.mnQLHDBH.Name = "mnQLHDBH";
            this.mnQLHDBH.Size = new System.Drawing.Size(216, 26);
            this.mnQLHDBH.Text = "Hóa đơn bán hàng";
            this.mnQLHDBH.Click += new System.EventHandler(this.mnQLHDBH_Click);
            // 
            // mnLap
            // 
            this.mnLap.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnLapHDBH,
            this.hóaĐơnNhậpHàngToolStripMenuItem});
            this.mnLap.Name = "mnLap";
            this.mnLap.Size = new System.Drawing.Size(47, 24);
            this.mnLap.Text = "Lập";
            // 
            // mnLapHDBH
            // 
            this.mnLapHDBH.Name = "mnLapHDBH";
            this.mnLapHDBH.Size = new System.Drawing.Size(224, 26);
            this.mnLapHDBH.Text = "Hóa đơn bán hàng";
            this.mnLapHDBH.Click += new System.EventHandler(this.mnLapHDBH_Click);
            // 
            // mnTimKiem
            // 
            this.mnTimKiem.Name = "mnTimKiem";
            this.mnTimKiem.Size = new System.Drawing.Size(84, 24);
            this.mnTimKiem.Text = "Tìm kiếm";
            // 
            // mnBaoCao
            // 
            this.mnBaoCao.Name = "mnBaoCao";
            this.mnBaoCao.Size = new System.Drawing.Size(77, 24);
            this.mnBaoCao.Text = "Báo cáo";
            // 
            // hóaĐơnNhậpHàngToolStripMenuItem
            // 
            this.hóaĐơnNhậpHàngToolStripMenuItem.Name = "hóaĐơnNhậpHàngToolStripMenuItem";
            this.hóaĐơnNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.hóaĐơnNhậpHàngToolStripMenuItem.Text = "Hóa đơn nhập hàng";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 463);
            this.Controls.Add(this.mn);
            this.Name = "formMain";
            this.Text = "Quản lý kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.formMain_Activated);
            this.mn.ResumeLayout(false);
            this.mn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mn;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong_DangNhap;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong_HuyDN;
        private System.Windows.Forms.ToolStripMenuItem mnHeThong_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnQL;
        private System.Windows.Forms.ToolStripMenuItem mnTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnQLHDBH;
        private System.Windows.Forms.ToolStripMenuItem mnQLSanPham;
        private System.Windows.Forms.ToolStripMenuItem mnLap;
        private System.Windows.Forms.ToolStripMenuItem mnLapHDBH;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnNhậpHàngToolStripMenuItem;
    }
}


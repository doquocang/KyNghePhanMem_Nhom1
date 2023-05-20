namespace QuanLyKhoPhongVu
{
    partial class frmDonDatMuaHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvHDBH = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.btnUpdateSP = new System.Windows.Forms.Button();
            this.btnAddSP = new System.Windows.Forms.Button();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTenSanPham = new System.Windows.Forms.ComboBox();
            this.cmbMaVach = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDeleteSP = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maVach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBH)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(28, 75);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(103, 16);
            this.lblTenKhachHang.TabIndex = 0;
            this.lblTenKhachHang.Text = "Tên khách hàng";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(137, 72);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(296, 22);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(296, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(137, 128);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(296, 22);
            this.txtSDT.TabIndex = 5;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(28, 131);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(35, 16);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "SDT";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 29);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "LẬP HÓA ĐƠN";
            // 
            // dgvHDBH
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHDBH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHDBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maVach,
            this.tenSanPham,
            this.dvt,
            this.soLuong,
            this.gia,
            this.giamGia,
            this.thanhTien,
            this.baoHanh});
            this.dgvHDBH.Location = new System.Drawing.Point(31, 212);
            this.dgvHDBH.Name = "dgvHDBH";
            this.dgvHDBH.RowHeadersWidth = 51;
            this.dgvHDBH.RowTemplate.Height = 24;
            this.dgvHDBH.Size = new System.Drawing.Size(1025, 240);
            this.dgvHDBH.TabIndex = 30;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(862, 484);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(63, 16);
            this.lblTongTien.TabIndex = 33;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(931, 481);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(125, 22);
            this.txtTongTien.TabIndex = 34;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(931, 19);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(125, 22);
            this.txtNgayLap.TabIndex = 36;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(885, 22);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(40, 16);
            this.lblNgayLap.TabIndex = 35;
            this.lblNgayLap.Text = "Ngày";
            // 
            // btnUpdateSP
            // 
            this.btnUpdateSP.Location = new System.Drawing.Point(31, 466);
            this.btnUpdateSP.Name = "btnUpdateSP";
            this.btnUpdateSP.Size = new System.Drawing.Size(59, 37);
            this.btnUpdateSP.TabIndex = 37;
            this.btnUpdateSP.Text = "Sửa";
            this.btnUpdateSP.UseVisualStyleBackColor = true;
            // 
            // btnAddSP
            // 
            this.btnAddSP.Location = new System.Drawing.Point(735, 166);
            this.btnAddSP.Name = "btnAddSP";
            this.btnAddSP.Size = new System.Drawing.Size(75, 40);
            this.btnAddSP.TabIndex = 38;
            this.btnAddSP.Text = "Thêm";
            this.btnAddSP.UseVisualStyleBackColor = true;
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(638, 75);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(93, 16);
            this.lblTenSanPham.TabIndex = 39;
            this.lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã vạch";
            // 
            // cmbTenSanPham
            // 
            this.cmbTenSanPham.FormattingEnabled = true;
            this.cmbTenSanPham.Location = new System.Drawing.Point(735, 72);
            this.cmbTenSanPham.Name = "cmbTenSanPham";
            this.cmbTenSanPham.Size = new System.Drawing.Size(212, 24);
            this.cmbTenSanPham.TabIndex = 41;
            // 
            // cmbMaVach
            // 
            this.cmbMaVach.FormattingEnabled = true;
            this.cmbMaVach.Location = new System.Drawing.Point(735, 103);
            this.cmbMaVach.Name = "cmbMaVach";
            this.cmbMaVach.Size = new System.Drawing.Size(212, 24);
            this.cmbMaVach.TabIndex = 42;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(816, 166);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(131, 40);
            this.btnCheck.TabIndex = 43;
            this.btnCheck.Text = "Kiểm tra tồn kho";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Số lượng";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(735, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 22);
            this.textBox1.TabIndex = 45;
            // 
            // btnDeleteSP
            // 
            this.btnDeleteSP.Location = new System.Drawing.Point(96, 466);
            this.btnDeleteSP.Name = "btnDeleteSP";
            this.btnDeleteSP.Size = new System.Drawing.Size(59, 37);
            this.btnDeleteSP.TabIndex = 46;
            this.btnDeleteSP.Text = "Xóa";
            this.btnDeleteSP.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(161, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 37);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Lập";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 35;
            // 
            // maVach
            // 
            this.maVach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maVach.DataPropertyName = "maVach";
            this.maVach.HeaderText = "Mã sản phẩm";
            this.maVach.MinimumWidth = 6;
            this.maVach.Name = "maVach";
            this.maVach.Width = 117;
            // 
            // tenSanPham
            // 
            this.tenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tenSanPham.DataPropertyName = "tenSanPham";
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.MinimumWidth = 6;
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.Width = 122;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dvt.DataPropertyName = "dvt";
            this.dvt.HeaderText = "ĐVT";
            this.dvt.MinimumWidth = 6;
            this.dvt.Name = "dvt";
            this.dvt.Width = 63;
            // 
            // soLuong
            // 
            this.soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.Width = 89;
            // 
            // gia
            // 
            this.gia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá bán (đã VAT)";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 101;
            // 
            // giamGia
            // 
            this.giamGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.giamGia.DataPropertyName = "giamGia";
            this.giamGia.HeaderText = "Giảm giá";
            this.giamGia.MinimumWidth = 6;
            this.giamGia.Name = "giamGia";
            this.giamGia.Width = 83;
            // 
            // thanhTien
            // 
            this.thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.Width = 91;
            // 
            // baoHanh
            // 
            this.baoHanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.baoHanh.DataPropertyName = "baoHanh";
            this.baoHanh.HeaderText = "B/H (Tháng)";
            this.baoHanh.MinimumWidth = 6;
            this.baoHanh.Name = "baoHanh";
            this.baoHanh.Width = 101;
            // 
            // frmDonDatMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 525);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteSP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.cmbMaVach);
            this.Controls.Add(this.cmbTenSanPham);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.btnAddSP);
            this.Controls.Add(this.btnUpdateSP);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dgvHDBH);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTenKhachHang);
            this.Controls.Add(this.lblTenKhachHang);
            this.Name = "frmDonDatMuaHang";
            this.Text = "Lập hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvHDBH;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label lblNgayLap;
        private System.Windows.Forms.Button btnUpdateSP;
        private System.Windows.Forms.Button btnAddSP;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTenSanPham;
        private System.Windows.Forms.ComboBox cmbMaVach;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDeleteSP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn baoHanh;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoPhongVu
{
    public partial class frmQuanLySanPham : Form
    {
        SanPham model = new SanPham();
        private Size fromOriginalSize;
        private Rectangle recLblTitle;
        private Rectangle recLblMaSanPham;
        private Rectangle recLblTenSanPham;
        private Rectangle recLblGia;
        private Rectangle recLblDVT;
        private Rectangle recLblBaoHanh;
        private Rectangle recTxtMaSanPham;
        private Rectangle recTxtTenSanPham;
        private Rectangle recTxtGia;
        private Rectangle recTxtDVT;
        private Rectangle recTxtBaoHanh;
        private Rectangle recBtnNew;
        private Rectangle recBtnAdd;
        private Rectangle recBtnUpdate;
        private Rectangle recBtnDelete;
        private Rectangle recBtnExit;
        private Rectangle recDgvSanPham;
        public frmQuanLySanPham()
        {
            InitializeComponent();
            lock_unlock(true);
            loadDataToGrv();
            this.Resize += frmQuanLySanPham_Resize;
            fromOriginalSize = this.Size;
            recLblTitle = new Rectangle(lblTitle.Location,lblTitle.Size);
            recLblMaSanPham = new Rectangle(lblMaVach.Location, lblMaVach.Size);
            recLblTenSanPham = new Rectangle(lblTenSanPham.Location, lblTenSanPham.Size);
            recLblGia = new Rectangle(lblGia.Location, lblGia.Size);
            recLblDVT = new Rectangle(lblDVT.Location, lblDVT.Size);
            recLblBaoHanh = new Rectangle(lblBaoHanh.Location, lblBaoHanh.Size);
            recTxtMaSanPham = new Rectangle(txtMaVach.Location, txtMaVach.Size);
            recTxtTenSanPham = new Rectangle(txtTenSanPham.Location, txtTenSanPham.Size);
            recTxtGia = new Rectangle(txtGia.Location, txtGia.Size);
            recTxtDVT = new Rectangle(txtDVT.Location, txtDVT.Size);
            recTxtBaoHanh = new Rectangle(txtBaoHanh.Location, txtBaoHanh.Size);
            recBtnNew = new Rectangle(btnNew.Location, btnNew.Size);
            recBtnAdd = new Rectangle(btnAdd.Location, btnAdd.Size);
            recBtnUpdate = new Rectangle(btnUpdate.Location, btnUpdate.Size);
            recBtnDelete = new Rectangle(btnDelete.Location, btnDelete.Size);
            recBtnExit = new Rectangle(btnExit.Location, btnExit.Size);
            recDgvSanPham = new Rectangle(dgvSanPham.Location, dgvSanPham.Size);
        }
        void loadDataToGrv()
        {
            dgvSanPham.AutoGenerateColumns = false;
            using (kyngheEntities db = new kyngheEntities())
            {
                dgvSanPham.DataSource = Luutru.CreateDataTable<SanPham>(db.SanPhams.ToList<SanPham>());
            }

        }
        private void frmQuanLySanPham_Resize(object sender, EventArgs e)
        {
            resize_Control(lblTitle, recLblTitle);
            resize_Control(lblMaVach, recLblMaSanPham);
            resize_Control(lblTenSanPham, recLblTenSanPham);
            resize_Control(lblGia, recLblGia);
            resize_Control(lblDVT, recLblDVT);
            resize_Control(lblBaoHanh, recLblBaoHanh);
            resize_Control(txtMaVach, recTxtMaSanPham);
            resize_Control(txtTenSanPham, recTxtTenSanPham);
            resize_Control(txtGia, recTxtGia);
            resize_Control(txtDVT, recTxtDVT);
            resize_Control(txtBaoHanh, recTxtBaoHanh);
            resize_Control(btnNew, recBtnNew);
            resize_Control(btnAdd, recBtnAdd);
            resize_Control(btnUpdate, recBtnUpdate);
            resize_Control(btnDelete, recBtnDelete);
            resize_Control(btnExit, recBtnExit);
            resize_Control(dgvSanPham, recDgvSanPham);
        }

        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(fromOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(fromOriginalSize.Height);
            int newX = (int) (r.X * xRatio);
            int newY = (int) (r.Y * yRatio);

            int newWidth = (int) (r.Width * xRatio);
            int newHeight = (int) (r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        void lock_unlock(bool kt)
        {
            btnNew.Enabled = kt;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = !kt;
        }
        void lock_unlock1(bool kt)
        {
            btnAdd.Enabled = kt;
            btnNew.Enabled = btnUpdate.Enabled = btnDelete.Enabled = !kt;
        }
        void lock_unlock2(bool kt)
        {
            btnAdd.Enabled = btnNew.Enabled = !kt;
            btnUpdate.Enabled = btnDelete.Enabled = kt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            model.maVach = txtMaVach.Text;
            model.tenSanPham = txtTenSanPham.Text;
            model.gia = double.Parse(txtGia.Text);
            model.dvt = txtDVT.Text;
            model.baoHanh = int.Parse(txtBaoHanh.Text);
            using (kyngheEntities db = new kyngheEntities())
            {
                db.SanPhams.Add(model);
                db.SaveChanges();
                MessageBox.Show("Chèn thành công!", "Thông báo");
                txtMaVach.Text = "";
                txtTenSanPham.Text = "";
                txtGia.Text = "";
                txtDVT.Text = "";
                txtBaoHanh.Text = "";
                loadDataToGrv();
                lock_unlock(true);
            }
        }
        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSanPham.CurrentRow.Index;
            txtId.Text = dgvSanPham[1, i].Value.ToString();
            txtMaVach.Text = dgvSanPham[2, i].Value.ToString();
            txtTenSanPham.Text = dgvSanPham[3, i].Value.ToString();
            txtGia.Text = dgvSanPham[4, i].Value.ToString();
            txtDVT.Text = dgvSanPham[5, i].Value.ToString();
            txtBaoHanh.Text = dgvSanPham[6, i].Value.ToString();
            lock_unlock2(true);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtMaVach.Focus();
            txtMaVach.Text = "";
            txtTenSanPham.Text = "";
            txtGia.Text = "";
            txtDVT.Text = "";
            txtBaoHanh.Text = "";
            lock_unlock1(true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            model.id = int.Parse(txtId.Text);
            model.maVach = txtMaVach.Text;
            model.tenSanPham = txtTenSanPham.Text;
            model.gia = double.Parse(txtGia.Text);
            model.dvt = txtDVT.Text;
            model.baoHanh = int.Parse(txtBaoHanh.Text);
            using (kyngheEntities db = new kyngheEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                txtMaVach.Text = "";
                txtTenSanPham.Text = "";
                txtGia.Text = "";
                txtDVT.Text = "";
                txtBaoHanh.Text = "";
                loadDataToGrv();
                lock_unlock(true);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            model.id = int.Parse(txtId.Text);
            model.maVach = txtMaVach.Text;
            model.tenSanPham = txtTenSanPham.Text;
            model.gia = double.Parse(txtGia.Text);
            model.dvt = txtDVT.Text;
            model.baoHanh = int.Parse(txtBaoHanh.Text);
            using (kyngheEntities db = new kyngheEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo");
                txtMaVach.Text = "";
                txtTenSanPham.Text = "";
                txtGia.Text = "";
                txtDVT.Text = "";
                txtBaoHanh.Text = "";
                loadDataToGrv();
                lock_unlock(true);
            }
        }
    }
}

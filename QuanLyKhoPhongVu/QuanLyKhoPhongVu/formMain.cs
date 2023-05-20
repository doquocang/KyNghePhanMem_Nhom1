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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
            lock_unlock(Luutru.KT);
        }
        void lock_unlock(bool kt)
        {
            mnHeThong_DangNhap.Enabled = mnHeThong_Thoat.Enabled = kt;
            mnHeThong_HuyDN.Enabled = mnLap.Enabled = mnQL.Enabled = mnTimKiem.Enabled = mnBaoCao.Enabled = !kt;
        }
        private void mnQLHDBH_Click(object sender, EventArgs e)
        {
            frmQuanLyDonHang f = new frmQuanLyDonHang();
            f.Show();
        }

        private void mnHeThong_HuyDN_Click(object sender, EventArgs e)
        {

        }

        private void mnQLSanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham f = new frmQuanLySanPham();
            f.Show();
        }

        private void mnHeThong_DangNhap_Click(object sender, EventArgs e)
        {
            frmDangNhap f = new frmDangNhap();
            f.Show();
        }

        private void mnLapHDBH_Click(object sender, EventArgs e)
        {
            frmDonDatMuaHang f = new frmDonDatMuaHang();
            f.Show();
        }

        private void formMain_Activated(object sender, EventArgs e)
        {
            lock_unlock(Luutru.KT);
        }
    }
}

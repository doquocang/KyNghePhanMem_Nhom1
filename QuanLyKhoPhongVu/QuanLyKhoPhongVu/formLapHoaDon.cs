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
    public partial class frmDonDatMuaHang : Form
    {
        private Size fromOriginalSize;
        private Rectangle recLblTitle;
        public frmDonDatMuaHang()
        {
            InitializeComponent();
            this.dgvHDBH.Rows.Add("1", "221101658", "Laptop MSI Gaming GF63 Thin 11SC", "cái", "10", "16990000", "0", "169900000", "12");
        }
    }
}

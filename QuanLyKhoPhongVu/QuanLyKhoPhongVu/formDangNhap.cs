using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoPhongVu
{
    public partial class frmDangNhap : Form
    {
        SqlCommand cmd;
        private Size fromOriginalSize;
        private Rectangle recLblUser;
        private Rectangle recTxtUser;
        private Rectangle recLblPass;
        private Rectangle recTxtPass;
        private Rectangle recBtnLogin;
        private Rectangle recBtnClose;
        public frmDangNhap()
        {
            InitializeComponent();
            this.Resize += frmDangNhap_Resize;
            fromOriginalSize = this.Size;
            recLblUser = new Rectangle(lblUser.Location, lblUser.Size);
            recTxtUser = new Rectangle(txtUser.Location, txtUser.Size);
            recLblPass = new Rectangle(lblPass.Location, lblPass.Size);
            recTxtPass = new Rectangle(txtPass.Location, txtPass.Size);
            recBtnLogin = new Rectangle(btnLogin.Location, btnLogin.Size);
            recBtnClose = new Rectangle(btnClose.Location, btnClose.Size);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (kyngheEntities db = new kyngheEntities())
            {
                //string s = "select * from _User where convert(varchar(100),DecryptByPassPhrase('bbb', pass))='123' and username='ndk'";
                string s = "select * from TaiKhoan where convert(varchar(100),DecryptByPassPhrase('bbb', pass))='" + txtPass.Text + "' and username='" + txtUser.Text + "'";
                var list = db.TaiKhoans.SqlQuery(s).ToList();
                if (list.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");
                    Luutru.KT = !Luutru.KT;
                    Close();
                }
                else
                {
                    MessageBox.Show("Username hoặc Password không đúng!", "Thông báo");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmDangNhap_Resize(object sender, EventArgs e)
        {
            resize_Control(lblUser, recLblUser);
            resize_Control(txtUser, recTxtUser);
            resize_Control(lblPass, recLblPass);
            resize_Control(txtPass, recTxtPass);
            resize_Control(btnLogin, recBtnLogin);
            resize_Control(btnClose, recBtnClose);
        }
        private void resize_Control(Control c, Rectangle r)
        {
            float xRatio = (float)(this.Width) / (float)(fromOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(fromOriginalSize.Height);
            int newX = (int)(r.X * xRatio);
            int newY = (int)(r.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio);

            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }
    }
}

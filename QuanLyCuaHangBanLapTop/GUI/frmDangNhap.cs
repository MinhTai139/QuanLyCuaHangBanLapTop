using QuanLyCuaHangBanLapTop.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLapTop.GUI
{
    public partial class frmDangNhap : Form
    {
        FileXml Fxml=new FileXml();
        DangNhap dn=new DangNhap();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Equals("") || txtpass.Text.Equals(""))
            {
                MessageBox.Show("Không được bỏ trống các trường!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtuser.Focus();
            }
            else
            {

                if (dn.kiemtraTTDN("TaiKhoan.xml", txtuser.Text, txtpass.Text) == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Text = "";
                    txtpass.Text = "";
                    txtuser.Focus();
                }
            }
        }
    }
}

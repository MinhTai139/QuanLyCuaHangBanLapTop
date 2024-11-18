using QuanLyCuaHangBanLapTop.GUI.HangHoa;
using QuanLyCuaHangBanLapTop.GUI.HoaDon;
using QuanLyCuaHangBanLapTop.GUI.KhachHang;
using QuanLyCuaHangBanLapTop.GUI.NhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanLapTop.GUI.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        // xử lí mở form con
        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm_AD.Controls.Add(childForm);
            panelChildForm_AD.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // xử lí chuyển màu khi click vào button
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#4169E1");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(12, 83, 114);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void btn_hanghoa_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmHangHoa());
        }

        private void btn_donhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmHoaDon());
        }

        private void btn_khachhang_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmKhachHang());
        }

        private void btn_nhanvien_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmNhanVien());
        }

        private void btn_thongke_AD_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new frmThongKe());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLyCuaHangBanLapTop.Class
{
    internal class DangNhap
    {
        FileXml Fxml = new FileXml();
        public bool kiemtraTTDN(string duongdan, string TenDangNhap, string MatKhau)
        {
            DataTable dt = new DataTable();
            dt = Fxml.HienThi(duongdan);
            dt.DefaultView.RowFilter = "TenDangNhap ='" + TenDangNhap + "' AND MatKhau='" + MatKhau + "'";
            if (dt.DefaultView.Count > 0)
                return true;
            return false;

        }
    }
}

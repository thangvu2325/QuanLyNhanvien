using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm.File_CS
{
    public static class Auth
    {
        public static bool IsLoggedIn { get; set; } = false;
        public static User user { get; set; }
    }
    public static class Global
    {
        public static IList<NhanVien_CongChuc> danh_sach_nhan_vien_cong_chuc = new List<NhanVien_CongChuc>();
        public static IList<NhanVien_HopDong> danh_sach_nhan_vien_hop_dong = new List<NhanVien_HopDong>();
        public static Main_Form mainForm { get; set; }  
    }
}

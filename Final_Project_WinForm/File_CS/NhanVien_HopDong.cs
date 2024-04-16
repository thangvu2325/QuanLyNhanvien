using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm.File_CS
{
    public class NhanVien_HopDong : NhanVien
    {
        public int so_gio_lam_viec { get; set; }
        public int tien_cong_1_gio { get; set; }

        public NhanVien_HopDong(string maSo, string hoTen, string email, int ns, string so_dien_thoai, string chuc_vu, string phong_ban,int so_gio_lam_vien, int tien_Cong_1_gio)
            : base(maSo, hoTen, email, ns, so_dien_thoai, chuc_vu, phong_ban)
        {
            this.so_gio_lam_viec = so_gio_lam_vien;
            this.tien_cong_1_gio = tien_Cong_1_gio;
        }
        public int tinhluong()
        {
            return so_gio_lam_viec * tien_cong_1_gio;
        }
    }
}

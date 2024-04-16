using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm
{
    public class NhanVien
    {
        public string ma_so { get; set; }
        public string ho_ten { get; set; }
        public int nam_sinh { get; set; }
        public string email { get; set; }
        public string so_dien_thoai { get; set; }
        public string chuc_vu { get; set; }
        public string phong_ban { get; set; }
 
        public NhanVien(string maSo, string hoTen,string email, int nam_sinh, string so_dien_thoai, string chuc_vu, string phong_ban)
        {
            this.ma_so = maSo;
            this.ho_ten = hoTen;
            this.email = email;
            this.nam_sinh = nam_sinh;
            this.so_dien_thoai = so_dien_thoai;
            this.chuc_vu = chuc_vu;
            this.phong_ban = phong_ban;
        }
    }
}

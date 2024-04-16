    using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm.File_CS
{
    public class NhanVien_CongChuc : NhanVien
    {
        public int luongCanBan { get; set; }
        public int phuCap { get; set; }
        public int heSoLuong { get; set; }
            

        public NhanVien_CongChuc(string maSo, string hoTen, string email, int ns,string so_dien_thoai, string chuc_vu, string phong_ban,int luongCanBan, int phuCap, int heSoLuong )
            : base(maSo, hoTen, email, ns, so_dien_thoai, chuc_vu, phong_ban) 
        {
            this.luongCanBan = luongCanBan;
            this.phuCap = phuCap;
            this.heSoLuong = heSoLuong;
        }
        public int tinhluong()
        {
            return this.luongCanBan*this.heSoLuong + this.phuCap;
        }
    }
}



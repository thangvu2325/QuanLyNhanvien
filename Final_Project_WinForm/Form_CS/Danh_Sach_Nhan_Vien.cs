using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using Final_Project_WinForm.File_CS;
using Final_Project_WinForm.Form_CS;
using Newtonsoft.Json;

namespace Final_Project_WinForm
{
    public partial class Danh_Sach_Nhan_Vien : Form
    {
        public  Danh_Sach_Nhan_Vien()
        {

            if (Auth.IsLoggedIn)
            {
                InitializeComponent();
                refreshData();
            }
        
       
        }
        public NhanVien_CongChuc nvcc = null;
        public NhanVien_HopDong nvhd = null;
        private async void refreshData()
        {
            try
            {
                string jsonCongChuc = await HttpRequest.GetNhanVien("nhanviencongchuc");
                responeGet<NhanVien_CongChuc> dataCongChuc = JsonConvert.DeserializeObject<responeGet<NhanVien_CongChuc>>(jsonCongChuc);
                string jsonHopDong = await HttpRequest.GetNhanVien("nhanvienhopdong");
                responeGet<NhanVien_HopDong> dataHopDong = JsonConvert.DeserializeObject<responeGet<NhanVien_HopDong>>(jsonHopDong);
                Global.danh_sach_nhan_vien_cong_chuc.danhSachNhanVien = dataCongChuc.Nhanvien;
                Global.danh_sach_nhan_vien_hop_dong.danhSachNhanVien = dataHopDong.Nhanvien;
                setUpData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Select_Click(object sender, EventArgs e)
        {
            listView1.Columns.Add("tên 1");
            ListViewItem item1 = new ListViewItem();
            item1.Text = "test";
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "sub Item" });
        


        }
        private void ReSizeListView(ListView listview) {
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void setListDSNV(ListView listview, List<string> listCol){
            foreach (var item in listCol)
            {
                listview.Columns.Add(item);
            }
            ReSizeListView(listview);
        }
        private void setUpData()
        {
            // Combo Box
            listView1.Hide();
            listView2.Hide();
            listView1.Clear();
            listView2.Clear();
            List<Item> items = new List<Item>();
            items.Clear();
            setListDSNV(listView1, new List<string>() { "Mã Nhân Viên", "Họ và Tên", "Phòng Ban", "Chức Vụ", "Năm Sinh","Lương Cơ Bản","Phụ Cấp", "Hệ Số Lương" });
            setListDSNV(listView2, new List<string>() { "Mã Nhân Viên", "Họ và Tên", "Phòng Ban", "Chức Vụ", "Năm Sinh", "Số Giờ Làm Việc", "Tiền Công 1 Giờ"});
            //items.Add(new Item() { Text = , Value = 0 });
            listView1.FullRowSelect = true;
            listView2.FullRowSelect = true;
            foreach (var item in Global.danh_sach_nhan_vien_cong_chuc.GetAllNhanVien())
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = item.ma_so.ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.ho_ten });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.phong_ban });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.chuc_vu });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.nam_sinh.ToString() });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.luongCanBan.ToString("#,##0") });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.phuCap.ToString("#,##0") });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.heSoLuong.ToString() });
                listView1.Items.Add(item1);
                items.Add(new Item() { Text = item.ma_so, Value = item.ma_so});
            }

            foreach (var item in Global.danh_sach_nhan_vien_hop_dong.GetAllNhanVien()) 
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = item.ma_so.ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.ho_ten });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.phong_ban });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.chuc_vu });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.nam_sinh.ToString() });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.so_gio_lam_viec.ToString() });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.tien_cong_1_gio.ToString("#,##0") });
                listView2.Items.Add(item1);
                items.Add(new Item() { Text = item.ma_so, Value = item.ma_so });
            }
            listView1.Show();
            listView2.Show();
            comboBox1.DataSource = items;
            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

        }
        private void btn_Them_SV_Click(object sender, EventArgs e)
        {

            ModalAdd modal = new ModalAdd();
            modal.Show();
        }

        


        private void listView_DSSV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int replaceFieldVNDToNumber(string data)
        {
            return int.Parse(data.Replace(",", ""));
        }
        private async void btn_Fix_SV_Click(object sender, EventArgs e)
        {
            double hsl;
            if (double.TryParse(txt_hsl.Text.Replace(',', '.'), out hsl))
            {
                if (nvcc != null)
                {
                    // Tạo đối tượng nhân viên mới với thông tin cập nhật
                    NhanVien_CongChuc nhanvienEdit = new NhanVien_CongChuc(nvcc.ma_so, txt_ho_ten.Text, txt_email.Text, replaceFieldVNDToNumber(txt_nam_sinh.Text), txt_sdt.Text, txt_chuc_vu.Text, txt_phong_ban.Text, replaceFieldVNDToNumber(txt_lcb.Text), replaceFieldVNDToNumber(txt_pc.Text), hsl);
                    // Gửi yêu cầu cập nhật thông tin nhân viên
                    string result = await HttpRequest.PutNhanVien<NhanVien_CongChuc>(nvcc.ma_so, nhanvienEdit, "nhanviencongchuc");

                    // Tìm nhân viên cần cập nhật trong danh sách
                    NhanVien_CongChuc NhanvienFound = Global.danh_sach_nhan_vien_cong_chuc.GetNhanVienByMaSo(nvcc.ma_so);

                    if (NhanvienFound != null)
                    {
                        // Cập nhật thông tin của nhân viên trong danh sách
                        NhanvienFound.ho_ten = nhanvienEdit.ho_ten;
                        NhanvienFound.email = nhanvienEdit.email;
                        NhanvienFound.nam_sinh = nhanvienEdit.nam_sinh;
                        NhanvienFound.so_dien_thoai = nhanvienEdit.so_dien_thoai;
                        NhanvienFound.chuc_vu = nhanvienEdit.chuc_vu;
                        NhanvienFound.phong_ban = nhanvienEdit.phong_ban;
                        NhanvienFound.luongCanBan = nhanvienEdit.luongCanBan;
                        NhanvienFound.phuCap = nhanvienEdit.phuCap;
                        NhanvienFound.heSoLuong = nhanvienEdit.heSoLuong;
                    }
                    // Cập nhật giao diện
                    setUpData();
                    // Hiển thị kết quả
                    MessageBox.Show(result);
                }
                else if (nvhd != null)
                {
                    // Tạo đối tượng nhân viên mới với thông tin cập nhật
                    NhanVien_HopDong nhanvienEdit = new NhanVien_HopDong(nvcc.ma_so, txt_ho_ten.Text, txt_email.Text, replaceFieldVNDToNumber(txt_nam_sinh.Text), txt_sdt.Text, txt_chuc_vu.Text, txt_phong_ban.Text, replaceFieldVNDToNumber(txt_so_gio.Text), replaceFieldVNDToNumber(txt_tien_cong_1_gio.Text));

                    // Gửi yêu cầu cập nhật thông tin nhân viên
                    string result = await HttpRequest.PutNhanVien<NhanVien_HopDong>(nvhd.ma_so, nhanvienEdit, "nhanvienhopdong");

                    // Tìm nhân viên cần cập nhật trong danh sách
                    NhanVien_HopDong NhanvienFound = Global.danh_sach_nhan_vien_hop_dong.GetNhanVienByMaSo(nvhd.ma_so);

                    if (NhanvienFound != null)
                    {
                        // Cập nhật thông tin của nhân viên trong danh sách
                        NhanvienFound.ho_ten = nhanvienEdit.ho_ten;
                        NhanvienFound.email = nhanvienEdit.email;
                        NhanvienFound.nam_sinh = nhanvienEdit.nam_sinh;
                        NhanvienFound.so_dien_thoai = nhanvienEdit.so_dien_thoai;
                        NhanvienFound.chuc_vu = nhanvienEdit.chuc_vu;
                        NhanvienFound.phong_ban = nhanvienEdit.phong_ban;
                        NhanvienFound.so_gio_lam_viec = nhanvienEdit.so_gio_lam_viec;
                        NhanvienFound.tien_cong_1_gio = nhanvienEdit.tien_cong_1_gio;

                    }
                    // Cập nhật giao diện
                    setUpData();
                    // Hiển thị kết quả
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn nhân viên để tiến hành chỉnh sửa");
                }
            }
            else
            {
               
            }
          

        }

        private async void btn_Xoa_SV_Click(object sender, EventArgs e)
        {
            if(nvcc != null)
            {
               string result = await HttpRequest.DeleteNhanVien(nvcc.ma_so, "nhanviencongchuc");
                MessageBox.Show(result);
                NhanVien_CongChuc nhanVienToRemove = Global.danh_sach_nhan_vien_cong_chuc.GetNhanVienByMaSo(nvcc.ma_so);
                if (nhanVienToRemove != null)
                {
                    Global.danh_sach_nhan_vien_cong_chuc.RemoveNhanVien(nhanVienToRemove);
                }
                // Cập nhật giao diện
                setUpData();
            }
            else if(nvhd != null)
            {
                string result = await HttpRequest.DeleteNhanVien(nvhd.ma_so, "nhanvienhopdong");
                MessageBox.Show(result);
                // Tìm nhân viên cần cập nhật trong danh sách
                NhanVien_HopDong nhanVienToRemove = Global.danh_sach_nhan_vien_hop_dong.GetNhanVienByMaSo(nvhd.ma_so);
                if (nhanVienToRemove != null)
                {
                    Global.danh_sach_nhan_vien_hop_dong.RemoveNhanVien(nhanVienToRemove);
                }
                // Cập nhật giao diện
                setUpData();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn  nhân viên");
            }

        }

        private void Nhap_SV_Load(object sender, EventArgs e)
        {
            pannelHD.Hide();
        }

        private void showHD()
        {
            label_lcb.Hide();
            label_pc.Hide();
            label_hsl.Hide();
            txt_lcb.Hide();
            txt_pc.Hide();
            txt_hsl.Hide();
            label_so_gio.Show();
            label_tc1g.Show();
            txt_so_gio.Show();
            txt_tien_cong_1_gio.Show();
        }
        private void showCC()
        {
            label_lcb.Show();
            label_pc.Show();
            label_hsl.Show();
            txt_lcb.Show();
            txt_pc.Show();
            txt_hsl.Show();
            label_so_gio.Hide();
            label_tc1g.Hide();
            txt_so_gio.Hide();
            txt_tien_cong_1_gio.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_action.Show();
            int selectedIndex = comboBox1.SelectedIndex;
            //comboBox1.SelectedItem.ToString();
            Item selectedValue = (Item)comboBox1.Items[selectedIndex];
            int timthay = 0;
            foreach (var item in Global.danh_sach_nhan_vien_hop_dong.GetAllNhanVien())
            {
                if (item.ma_so == selectedValue.Value)
                {
                    timthay = 1;
                    nvhd = item;
                    break;
                }
            }
            if (timthay == 0)
            {
                foreach (var item in Global.danh_sach_nhan_vien_cong_chuc.GetAllNhanVien())
                {
                    if (item.ma_so == selectedValue.Value)
                    {
                        timthay = 2;
                        nvcc = item;
                        break;
                    }
                }
            }
            if (timthay == 0)
            {
                MessageBox.Show("Không Tìm thấy nhân viên này vui lòng, tìm lại");
            }
            switch (timthay)
            {
                case 1:
                    {
                        showHD();
                        nvcc = null;
                        txt_ho_ten.Text = nvhd.ho_ten;
                        txt_nam_sinh.Text = nvhd.nam_sinh.ToString();
                        txt_email.Text = nvhd.email;
                        txt_sdt.Text = nvhd.so_dien_thoai;
                        txt_phong_ban.Text = nvhd.phong_ban;
                        txt_chuc_vu.Text = nvhd.chuc_vu;
                        txt_so_gio.Text = nvhd.so_gio_lam_viec.ToString();
                        txt_tien_cong_1_gio.Text = nvhd.tien_cong_1_gio.ToString("#,##0") ;
                        break;
                    }
                case 2:
                    {
                        showCC();
                        nvhd = null;
                        txt_ho_ten.Text = nvcc.ho_ten;
                        txt_nam_sinh.Text = nvcc.nam_sinh.ToString();
                        txt_email.Text = nvcc.email;
                        txt_sdt.Text = nvcc.so_dien_thoai;
                        txt_phong_ban.Text = nvcc.phong_ban;
                        txt_chuc_vu.Text = nvcc.chuc_vu;
                        txt_lcb.Text = nvcc.luongCanBan.ToString("#,##0");
                        txt_hsl.Text = nvcc.heSoLuong.ToString();
                        txt_pc.Text = nvcc.phuCap.ToString("#,##0");
                        break;
                    }
                default:
                    break;
            }
            pannelHD.Show();
        }

        private void txt_ho_ten_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BangLuong bangLuong = new BangLuong();
            bangLuong.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;  
            if(lsv.SelectedItems.Count > 0 ) {
                ListViewItem item = lsv.SelectedItems[0];
                comboBox1.SelectedIndex = comboBox1.FindStringExact(item.SubItems[0].Text);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count > 0)
            {
                ListViewItem item = lsv.SelectedItems[0];
                comboBox1.SelectedIndex = comboBox1.FindStringExact(item.SubItems[0].Text);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
using Final_Project_WinForm.File_CS;
using Final_Project_WinForm.Form_CS;
using Newtonsoft.Json;


namespace Final_Project_WinForm
{
    public partial class BangLuong : Form
    {
        public BangLuong()
        {
            InitializeComponent();
            setUpData();

        }
        private void ReSizeListView(ListView listview)
        {
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void setListDSNV(ListView listview, List<string> listCol)
        {
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
            setListDSNV(listView1, new List<string>() { "Mã Nhân Viên", "Họ và Tên", "Phòng Ban", "Chức Vụ", "Tiền Lương(VND)"});
            setListDSNV(listView2, new List<string>() { "Mã Nhân Viên", "Họ và Tên", "Phòng Ban", "Chức Vụ", "Tiền Lương(VND)" });
            foreach (var item in Global.danh_sach_nhan_vien_cong_chuc)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = item.ma_so.ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.ho_ten });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.phong_ban });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.chuc_vu });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.tinhluong().ToString("#,##0") });
           
                listView1.Items.Add(item1);
            }

            foreach (var item in Global.danh_sach_nhan_vien_hop_dong)
            {
                ListViewItem item1 = new ListViewItem();
                item1.Text = item.ma_so.ToString();
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.ho_ten });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.phong_ban });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.chuc_vu });
                item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.tinhluong().ToString("#,##0") });
                listView2.Items.Add(item1);
            }
            listView1.Show();
            listView2.Show();
   
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void refreshData()
        {
            try
            {
                string jsonCongChuc = await HttpRequest.GetNhanVien("nhanviencongchuc");
                responeGet<NhanVien_CongChuc> dataCongChuc = JsonConvert.DeserializeObject<responeGet<NhanVien_CongChuc>>(jsonCongChuc);
                string jsonHopDong = await HttpRequest.GetNhanVien("nhanvienhopdong");
                responeGet<NhanVien_HopDong> dataHopDong = JsonConvert.DeserializeObject<responeGet<NhanVien_HopDong>>(jsonHopDong);
                Global.danh_sach_nhan_vien_cong_chuc = dataCongChuc.Nhanvien;
                Global.danh_sach_nhan_vien_hop_dong = dataHopDong.Nhanvien;
                setUpData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}

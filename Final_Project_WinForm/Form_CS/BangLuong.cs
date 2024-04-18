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
using ClosedXML.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;


namespace Final_Project_WinForm
{

    public partial class BangLuong : Form
    {
        public BangLuong()
        {
            InitializeComponent();
            setUpData();

        }
        private void staticDatagrid()
        {
            dataGridView1.Rows.Add("1", "Book 1");
            dataGridView1.Rows.Add("2", "Book 2");
        }
        private void setUpData()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            List<DataGridViewItem> data1 = new List<DataGridViewItem>();
            List<DataGridViewItem> data2 = new List<DataGridViewItem>();
            data1.Clear();
            data2.Clear();
            foreach (var item in Global.danh_sach_nhan_vien_cong_chuc.GetAllNhanVien())
            {
                data1.Add(new DataGridViewItem(item.ma_so, item.ho_ten,  item.chuc_vu, item.phong_ban, item.tinhluong().ToString("#,##0")));
            }
            foreach (var item in Global.danh_sach_nhan_vien_hop_dong.GetAllNhanVien())
            {
                data2.Add(new DataGridViewItem(item.ma_so, item.ho_ten, item.chuc_vu, item.phong_ban, item.tinhluong().ToString("#,##0")));
            }
            dataGridView1.DataSource = data1;
            dataGridView1.Show();
            dataGridView2.DataSource = data2;
            dataGridView2.Show();
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
                Global.danh_sach_nhan_vien_cong_chuc.danhSachNhanVien = dataCongChuc.Nhanvien;
                Global.danh_sach_nhan_vien_hop_dong.danhSachNhanVien = dataHopDong.Nhanvien;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt1.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                dt2.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt1.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt1.Rows[dt1.Rows.Count - 1][cell.ColumnIndex] = cell.Value?.ToString() ?? "";
                }
            }
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                dt2.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt2.Rows[dt2.Rows.Count - 1][cell.ColumnIndex] = cell.Value?.ToString() ?? "";
                }
            }

            // Hiển thị hộp thoại lưu file và yêu cầu tên file từ người dùng
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
            saveDialog.FileName = "BangLuong.xlsx";
            DialogResult result = saveDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filePath = saveDialog.FileName;

                if (File.Exists(filePath))
                {
                    // Hiển thị hộp thoại xác nhận ghi đè
                    DialogResult overwriteResult = MessageBox.Show("File đã tồn tại. Bạn có muốn ghi đè lên file này?", "Xác nhận ghi đè", MessageBoxButtons.YesNo);
                    if (overwriteResult == DialogResult.No)
                        return;
                }

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt1, "Nhân Viên Công Chức");
                    wb.Worksheets.Add(dt2, "Nhân Viên Hợp Đồng");
                    wb.Worksheet(1).Columns().AdjustToContents();
                    wb.SaveAs(filePath);
                }
                MessageBox.Show("Thành công");
            }
        }

    }
    public class DataGridViewItem
    {
        public string ma_so { get; set; }
        public string ho_ten { get; set; }
        public string chuc_vu { get; set; }
        public string phong_ban { get; set; }
        public string tinh_luong { get; set; }
        public DataGridViewItem(string ma_so, string ho_ten, string chuc_vu, string phong_ban, string tinh_luong)
        {
            this.ma_so = ma_so;
            this.ho_ten = ho_ten;
            this.chuc_vu = chuc_vu;
            this.phong_ban = phong_ban;
            this.tinh_luong = tinh_luong;
        }
    }
}


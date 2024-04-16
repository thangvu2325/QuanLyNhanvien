using Final_Project_WinForm.File_CS;
using Final_Project_WinForm.Form_CS;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Drawing.Design;
using Newtonsoft.Json.Bson;

namespace Final_Project_WinForm
{
    public partial class ModalAdd : Form
    {
        public ModalAdd()
        {
            InitializeComponent();
            cb_nvcc.Checked = true;
            setupForm();
            showCC();
        }
        public string type = "nhanviencongchuc";
        public string phong_ban = "";
        public string chuc_vu = "";
        private void resetText()
        {
            txt_ho_ten.Text = "";
            txt_nam_sinh.Text = "";
            txt_email.Text = "";
            txt_sdt.Text = "";
            txt_so_gio.Text = "";
            txt_tien_cong_1_gio.Text = "";
            txt_pc.Text = "";
            txt_lcb.Text = "";
            txt_hsl.Text = "";

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
       
        private void setupForm() {
            List<Item> chuc_vu_items = new List<Item>();
            List<Item> phong_ban_items = new List<Item>();
            List<string> chuc_vu_list = new List<string> { "Nhân viên", "Quản lý", "Giám đốc" };
            List<string> phong_ban_list = new List<string> { "IT", "Kỹ Thuật", "Tài chính - Kế Toán", "Marketing", "Kinh Doanh" };

            foreach (var item in chuc_vu_list)
            {
                chuc_vu_items.Add(new Item() { Text = item, Value = item });
            }
            foreach (var item in phong_ban_list)
            {
                phong_ban_items.Add(new Item() { Text = item, Value = item });
            }
            comboBox_cv.DataSource = chuc_vu_items;
            comboBox_cv.DisplayMember = "Text";
            comboBox_cv.ValueMember = "Value";
            comboBox_pb.DataSource = phong_ban_items;
            comboBox_pb.DisplayMember = "Text";
            comboBox_pb.ValueMember = "Value";
        }
        private void txt_lcb_TextChanged(object sender, EventArgs e)
        {

        }
            public int replaceFieldVNDToNumber(string data)
        {
            return int.Parse(data.Replace(",", ""));
        }
        private async void btn_Them_SV_Click(object sender, EventArgs e)
        {
            if(type == "nhanviencongchuc")
            {
               NhanVien_CongChuc newNhanvien = new NhanVien_CongChuc("", txt_ho_ten.Text, txt_email.Text, replaceFieldVNDToNumber(txt_nam_sinh.Text), txt_sdt.Text, chuc_vu, phong_ban, replaceFieldVNDToNumber(txt_lcb.Text), replaceFieldVNDToNumber(txt_pc.Text), replaceFieldVNDToNumber(txt_hsl.Text));

               string result = await HttpRequest.PostNhanVien<NhanVien_CongChuc>(newNhanvien);

                MessageBox.Show(result);
                resetText();
            }
            else if(type == "nhanvienhopdong")
            {
                NhanVien_HopDong newNhanvien = new NhanVien_HopDong("", txt_ho_ten.Text, txt_email.Text, replaceFieldVNDToNumber(txt_nam_sinh.Text), txt_sdt.Text, chuc_vu, phong_ban, replaceFieldVNDToNumber(txt_so_gio.Text), replaceFieldVNDToNumber(txt_tien_cong_1_gio.Text));

                string result = await HttpRequest.PostNhanVien<NhanVien_HopDong>(newNhanvien, "nhanvienhopdong");

                MessageBox.Show(result);
                resetText();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại nhân viên");
            }

        }

        private void cb_nvcc_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nvcc.Checked) {
                type = "nhanviencongchuc";
                cb_nvhd.Checked = false;
                showCC();
            }
            else if(cb_nvcc.Checked == false && cb_nvhd.Checked == false)
            {
                type = "";
            }
            
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
        private void cb_nvhd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_nvhd.Checked)
            {
                type = "nhanvienhopdong";
                cb_nvcc.Checked = false;
                showHD();
            }
            else if (cb_nvcc.Checked == false && cb_nvhd.Checked == false)
            {
                type = "";
            }
        }

        private void btn_Xoa_SV_Click(object sender, EventArgs e)
        {
        /*    ModalAdd modal = new ModalAdd();
            modal.Hide();*/
            this.Close();
        }

        private void comboBox_pb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_pb.SelectedIndex;
            Item selectedValue = (Item)comboBox_pb.Items[selectedIndex];
            phong_ban = selectedValue.Value;
        }

        private void comboBox_cv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox_cv.SelectedIndex;
            Item selectedValue = (Item)comboBox_cv.Items[selectedIndex];
            chuc_vu = selectedValue.Value;
        }
    }
}

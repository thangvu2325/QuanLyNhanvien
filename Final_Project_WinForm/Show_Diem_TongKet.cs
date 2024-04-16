using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_WinForm
{
    public partial class Show_Diem_TongKet : Form
    {
        public Show_Diem_TongKet()
        {
            InitializeComponent();
        }

        private void Show_Diem_TongKet_Load(object sender, EventArgs e)
        {
            lable_lop.Hide();
            lable_namhoc.Hide();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string MaLop = txt_MaLop.Text;
            Nhap_Lop.DS_Lop.getAverageScoreInClass(listView_ds_Diem_TB_TK, MaLop, Nhap_MonHoc.DS_MonHoc,true);

            lable_lop.Text = Nhap_Lop.DS_Lop.Ten_Lop_from_MaLop(MaLop);
            lable_namhoc.Text = Nhap_Lop.DS_Lop.Nam_Hoc_form_MaLop(MaLop);

            lable_lop.Show();
            lable_namhoc.Show();
        }
    }
}

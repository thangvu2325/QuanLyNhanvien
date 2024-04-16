using Final_Project_WinForm.File_CS;
using Final_Project_WinForm.Form_CS;
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

    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Global.mainForm = this;
        }

        private void btn_Nhap_Lop_Click(object sender, EventArgs e)
        {
        }
        

        private void btn_Nhap_SV_Click(object sender, EventArgs e)
        {
            Danh_Sach_Nhan_Vien nhapSV = new Danh_Sach_Nhan_Vien();
            nhapSV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();

        }
    }
}

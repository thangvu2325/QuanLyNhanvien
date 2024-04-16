using Final_Project_WinForm.File_CS;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_WinForm.Form_CS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void button1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text.Length != 0 | txt_username.Text.Length != 0)
            {
                Login loginData = new Login(txt_username.Text, txt_password.Text);

                string json = await HttpRequest.HandleLogin(loginData);
                respontAuth result = JsonConvert.DeserializeObject<respontAuth>(json);
                if(json != "")
                {
                    if (result.result == "thành công" || json == "")
                    {
                        Auth.IsLoggedIn = true;
                        Auth.user = result.user;
                        MessageBox.Show("Đăng Nhập thành công!");
                        this.Close();
                        Danh_Sach_Nhan_Vien dsnv = new Danh_Sach_Nhan_Vien();
                        dsnv.Show();
                    }
                    else
                    {
                        MessageBox.Show(json);
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.mainForm.Show();

        }
    }
}

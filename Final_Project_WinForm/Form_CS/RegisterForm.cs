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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text.Length == 0 || txt_password.Text.Length == 0 || txt_rePassword.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập đầy đủ thông tin");
            }else  {
                Register registerData = new Register(txt_username.Text, txt_password.Text, txt_rePassword.Text);
                if (registerData.isCheckDuplicatePassword())
                {
                   string json =  await HttpRequest.HandleRegister(registerData);
                    responeResult data = JsonConvert.DeserializeObject<responeResult>(json);
                    if (data.result == "Tên người dùng đã được sử dụng. Vui lòng chọn tên người dùng khác.") {
                        MessageBox.Show(data.result);
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thành công");
                        this.Close();
                        LoginForm loginForm = new LoginForm();
                        loginForm.Show();
                    }
              
                }
                else
                {
                    MessageBox.Show("Mật khẩu nhập lại không đúng");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.mainForm.Show();
        }
    }
}

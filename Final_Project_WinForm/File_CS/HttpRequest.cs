using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Formatting;

namespace Final_Project_WinForm.File_CS
{

    public class respontAuth {
        public string result { get; set; }
        public User user { get; set; }
    }
    public class responeResult {  public string result { get; set; } }
    public class responeGet<T>
    {
        public IList<T> Nhanvien { get; set; }
        public int count { get; set; }
    }
    public class HttpRequest
    {
        static HttpClient client = new HttpClient();
        static string path = "https://quanlynhanvienbackend.onrender.com/";

        // Phương thức này được làm public để có thể gọi từ bên ngoài lớp HttpRequest
        public static async Task<string> GetNhanVien(string type = "nhanviencongchuc")
        {
            string data = null;
            HttpResponseMessage response = await client.GetAsync(path + "nhanvien/" + type);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            if (data != null)
            {
                return data;

            }
            else
            {
                return string.Empty;
            }


        }
        public static async Task<string> PutNhanVien<T>(string ma_so, T nhanvien, string type = "nhanviencongchuc")
        {
            string data = null;
            HttpResponseMessage response = await client.PutAsJsonAsync(path + "nhanvien/" + type + "/" + ma_so, nhanvien);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            if (data != null)
            {
                return data;

            }
            else
            {
                return string.Empty;
            }


        }
        public static async Task<string> PostNhanVien<T>(T nhanvien, string type = "nhanviencongchuc")
        {
            string data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path + "nhanvien/" + type, nhanvien);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            if (data != null)
            {
                return data;

            }
            else
            {
                return string.Empty;
            }

        }
        public static async Task<string> DeleteNhanVien(string ma_so, string type)
        {
            string data = null;
            HttpResponseMessage response = await client.DeleteAsync(path + "nhanvien/" + type+ "/" + ma_so);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            if (data != null)
            {
                return data;

            }
            else
            {
                return string.Empty;
            }


        }
        public static async Task<string> HandleLogin( Login dataLogin)
        {
            string data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path + "auth/login" , dataLogin);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            if (data != null)
            {
                return data;

            }
            else
            {
                return string.Empty;
            }

        }
        public static async Task<string> HandleRegister(Register dataRegister)
        {
            string data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync(path + "auth/register", new Login(dataRegister.username, dataRegister.password));
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsStringAsync();
            }
            if (data != null)
            {
                return data;

            }
            else
            {
                return string.Empty;
            }


        }


    }
      
    }

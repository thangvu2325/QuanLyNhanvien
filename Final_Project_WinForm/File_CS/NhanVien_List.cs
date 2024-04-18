using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_WinForm.File_CS
{
 
    public class NhanVien_List<T> where T : NhanVien
    {
        public IList<T> danhSachNhanVien;

        public NhanVien_List()
        {
            danhSachNhanVien = new List<T>();
        }

        // Method to add an employee to the list
        public void AddNhanVien(T nhanVien)
        {
            danhSachNhanVien.Add(nhanVien);
        }
        public T GetNhanVienByMaSo(string ma_so)
        {
            foreach (var nhanVien in danhSachNhanVien)
            {

                if (nhanVien.ma_so == ma_so)
                {
                    return nhanVien;
                }
            }
            return default(T); 
        }

        // Method to remove an employee from the list
        public void RemoveNhanVien(T nhanVien)
        {
            danhSachNhanVien.Remove(nhanVien);
        }

        // Method to get all employees
        public IList<T> GetAllNhanVien()
        {
            return danhSachNhanVien;
        }

  
    }
}

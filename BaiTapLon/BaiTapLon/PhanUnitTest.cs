using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class PhanUnitTest
    {
        public bool KiemTraPalindrome_17_PhanCongHieu(string chuoi)
        {
            // Loại bỏ khoảng trắng và chuyển đổi chuỗi sang chữ thường
            chuoi = chuoi.Trim().ToLower();

            // Kiểm tra độ dài
            if (chuoi.Length ==  0 ) return false;

            // Tạo chuỗi đảo ngược
            string chuoiDaoNguoc = new string(chuoi.ToCharArray().Reverse().ToArray());

            // So sánh chuỗi gốc và chuỗi đảo ngược
            return chuoi == chuoiDaoNguoc;
        }

        public bool KiemTraNamNhuan_17_PhanCongHieu(int nam)
        {
            if (nam == 0) { return false; }
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }
}

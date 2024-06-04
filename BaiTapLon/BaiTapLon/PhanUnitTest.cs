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
            // trả về kết quả sai nếu số năm bằng 0
            if (nam == 0) { return false; }

            // Trả về kết quả đúng nếu chia hết cho 4 và 100 hoặc chia hết cho 400
            if ((nam % 4 == 0 && nam % 100 != 0) || nam % 400 == 0)
            {
                return true;
            }
            return false;
        }

        public bool SoNguyenTo_14_VoLeHau(int x)
        {
            //Nếu x hơn 1 hay bằng 1 đều không phải là số nguyên tố
            if (x <= 1)
                return false;
            //kiểm tra liệu x có chia hết cho số khác hay không
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                //trả về kết quả false nếu x chia hết cho các số khác
                if (x % i == 0)
                    return false;
            }
            //trả về kết quả true khi vòng lặp kết thúc
            //có nghĩa là không tìm thấy số nào khác chia hết cho x ngoài x 
            return true;
        }
        public bool SoArmstrong_14_VoLeHau(int x)
        {
            int sum = 0, r, temp;
            //Vòng lặp kiêm tra từng chữ số của biến đầu vào x và tính tổng luỹ thừa của từng chữ số
            for (temp = x; x != 0; x = x / 10)
            {
                //gán chữ số hiện tại vào r
                r = x % 10;
                //tổng luỹ thừa của từng chữ số của biến đầu vào x
                sum = sum + (r * r * r);
            }
            //trả về true nếu là số Armstrong và false nếu ngược lại
            if (sum == temp) return true;
            else return false;
        }
    }
}

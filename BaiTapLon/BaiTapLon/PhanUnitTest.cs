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

        public bool SoNguyenTo_14_VoLeHau(int x_14_VoLeHau)
        {
            //Nếu x hơn 1 hay bằng 1 đều không phải là số nguyên tố
            if (x_14_VoLeHau <= 1)
                return false;
            //kiểm tra liệu x có chia hết cho số khác hay không
            for (int i_14_VoLeHau = 2; i_14_VoLeHau <= Math.Sqrt(x_14_VoLeHau); i_14_VoLeHau++)
            {
                //trả về kết quả false nếu x chia hết cho các số khác
                if (x_14_VoLeHau % i_14_VoLeHau == 0)
                    return false;
            }
            //trả về kết quả true khi vòng lặp kết thúc
            //có nghĩa là không tìm thấy số nào khác chia hết cho x ngoài x 
            return true;
        }
        public bool SoArmstrong_14_VoLeHau(int x_14_VoLeHau)
        {
            int sum_14_VoLeHau = 0, r_14_VoLeHau, temp_14_VoLeHau;
            //Vòng lặp kiêm tra từng chữ số của biến đầu vào x và tính tổng luỹ thừa của từng chữ số
            for (temp_14_VoLeHau = x_14_VoLeHau; x_14_VoLeHau != 0; x_14_VoLeHau = x_14_VoLeHau / 10)
            {
                //gán chữ số hiện tại vào r
                r_14_VoLeHau = x_14_VoLeHau % 10;
                //tổng luỹ thừa của từng chữ số của biến đầu vào x
                sum_14_VoLeHau = sum_14_VoLeHau + (r_14_VoLeHau * r_14_VoLeHau * r_14_VoLeHau);
            }
            //trả về true nếu là số Armstrong và false nếu ngược lại
            if (sum_14_VoLeHau == temp_14_VoLeHau) return true;
            else return false;
        }
    }
}

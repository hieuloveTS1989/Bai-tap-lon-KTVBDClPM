using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapLon
{
    public class PhanUnitTest_17_Hieu_14_Hau
    {
        public bool KiemTraPalindrome_17_Hieu(string chuoi_17_Hieu)
        {
            // Loại bỏ khoảng trắng và chuyển đổi chuỗi sang chữ thường
            chuoi_17_Hieu = chuoi_17_Hieu.Trim().ToLower();

            // Kiểm tra độ dài
            if (chuoi_17_Hieu.Length ==  0 ) return false;

            // Tạo chuỗi đảo ngược
            string chuoiDaoNguoc_17_Hieu = new string(chuoi_17_Hieu.ToCharArray().Reverse().ToArray());

            // So sánh chuỗi gốc và chuỗi đảo ngược
            return chuoi_17_Hieu == chuoiDaoNguoc_17_Hieu;
        }

        public bool KiemTraNamNhuan_17_Hieu(int nam_17_Hieu)
        {
            // trả về kết quả sai nếu số năm bé hơn hoặc bằng 0
            if (nam_17_Hieu <= 0) { return false; }

            // Trả về kết quả đúng nếu chia hết cho 4 nhưng không chia hết cho 100 hoặc chia hết cho 400
            if ((nam_17_Hieu % 4 == 0 && nam_17_Hieu % 100 != 0) || nam_17_Hieu % 400 == 0)
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

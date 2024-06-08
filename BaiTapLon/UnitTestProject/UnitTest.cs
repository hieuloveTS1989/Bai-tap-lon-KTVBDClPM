using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BaiTapLon;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        PhanUnitTest_17_Hieu_14_Hau unitTest_17_Hieu_14_Hau;
        [TestInitialize]
        public void SetUp() { unitTest_17_Hieu_14_Hau = new PhanUnitTest_17_Hieu_14_Hau(); }
        [TestMethod]
        public void TC1namnhuan_17_Hieu()
        {
            //Năm nhuận
            Console.WriteLine("2000");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(2000));
            Console.WriteLine("1600");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(1600));
            Console.WriteLine("400");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(400));
            Console.WriteLine("2008");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(2008));
        }

        [TestMethod]
        public void TC2namnhuan_17_Hieu()
        {
            //Năm không nhuận
            Console.WriteLine("2003");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(2003));
            Console.WriteLine("2009");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(2009));
            Console.WriteLine("2013");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(2013));
            Console.WriteLine("2023");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(2023));
        }

        [TestMethod]
        public void TC3namnhuan_17_Hieu()
        {
            //Ngoại lệ
            Console.WriteLine("-100");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(-100));
            Console.WriteLine("0");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraNamNhuan_17_Hieu(0));
        }

        [TestMethod]
        public void TC1palindrome_17_Hieu()
        {
            //Là chuỗi palindrome
            //Xuất chuổi cần kiểm tra
            Console.WriteLine("radar");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay không
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("radar"));
            //Tương tự với các chuỗi khác
            Console.WriteLine("level");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("level"));
            Console.WriteLine("madam");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("madam"));
            Console.WriteLine("1234321");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("1234321"));
            Console.WriteLine("!@!");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("!@!"));
        }

        [TestMethod]
        public void TC2palindrome_17_Hieu()
        {

            //Không phải chuỗi palindrome
            //Xuất chuổi cần kiểm tra
            Console.WriteLine("hello");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay không
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("hello"));
            Console.WriteLine("!2@@");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu("!2@@"));

            //Trường hợp ngoại lệ
            Console.WriteLine("");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu(""));
        }

        [TestMethod]
        public void TC3palindrome_17_Hieu()
        {
            //Trường hợp ngoại lệ
            //Xuất chuổi cần kiểm tra
            Console.WriteLine("");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay không
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.KiemTraPalindrome_17_Hieu(""));
        }

        [TestMethod]
        public void TestSoNguyenTo_14_VoLeHau()
        {
            //Trường hợp là số nguyên tố
            Console.WriteLine("2");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay ko
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(2));
            //Tương tự với các số khác
            Console.WriteLine("11");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(11));
            Console.WriteLine("13");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(13));
            Console.WriteLine("17");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(17));

            //Trường hợp ko phải là số nguyên tố
            Console.WriteLine("1");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(1));
            Console.WriteLine("12");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(12));
            Console.WriteLine("-2");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.SoNguyenTo_14_VoLeHau(-2));
        }
        [TestMethod]
        public void TestSoArmstrong_14_VoLeHau()
        {
            //Trường hợp là số armstrong
            Console.WriteLine("0");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay ko
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoArmstrong_14_VoLeHau(0));
            //Tương tự với các số khác
            Console.WriteLine("153");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoArmstrong_14_VoLeHau(153));
            Console.WriteLine("370");
            Assert.AreEqual(true, unitTest_17_Hieu_14_Hau.SoArmstrong_14_VoLeHau(370));
            //Trường hợp ko phải là số armstrong
            Console.WriteLine("-30");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.SoArmstrong_14_VoLeHau(-30));
            Console.WriteLine("100");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.SoArmstrong_14_VoLeHau(100));
            Console.WriteLine("999");
            Assert.AreEqual(false, unitTest_17_Hieu_14_Hau.SoArmstrong_14_VoLeHau(999));
        }
    }
}

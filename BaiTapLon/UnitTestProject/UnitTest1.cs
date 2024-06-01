using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BaiTapLon;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        PhanUnitTest unitTest;
        [TestInitialize]
        public void SetUp() { unitTest = new PhanUnitTest(); }
        [TestMethod]
        public void TestMethodKiemTraNamNhuan_17_PhanCongHieu()
        {
            //Năm nhuận
            Console.WriteLine("2000");
            Assert.AreEqual(true, unitTest.KiemTraNamNhuan_17_PhanCongHieu(2000));
            Console.WriteLine("1600");
            Assert.AreEqual(true, unitTest.KiemTraNamNhuan_17_PhanCongHieu(1600));
            Console.WriteLine("400");
            Assert.AreEqual(true, unitTest.KiemTraNamNhuan_17_PhanCongHieu(400));
            Console.WriteLine("2024");
            Assert.AreEqual(true, unitTest.KiemTraNamNhuan_17_PhanCongHieu(2024));

            //Năm không nhuận
            Console.WriteLine("1900");
            Assert.AreEqual(false, unitTest.KiemTraNamNhuan_17_PhanCongHieu(1900));
            Console.WriteLine("1700");
            Assert.AreEqual(false, unitTest.KiemTraNamNhuan_17_PhanCongHieu(1700));
            Console.WriteLine("100");
            Assert.AreEqual(false, unitTest.KiemTraNamNhuan_17_PhanCongHieu(100));
            Console.WriteLine("2023");
            Assert.AreEqual(false, unitTest.KiemTraNamNhuan_17_PhanCongHieu(2023));

            //Ngoại lệ
            Console.WriteLine("-100");
            Assert.AreEqual(false, unitTest.KiemTraNamNhuan_17_PhanCongHieu(-100));
            Console.WriteLine("0");
            Assert.AreEqual(false, unitTest.KiemTraNamNhuan_17_PhanCongHieu(0));
        }

        [TestMethod]
        public void TestMethodKiemTraPalindrome_17_PhanCongHieu()
        {
            //Là chuỗi palindrome
            //Xuất chuổi cần kiểm tra
            Console.WriteLine("radar");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay không
            Assert.AreEqual(true, unitTest.KiemTraPalindrome_17_PhanCongHieu("radar"));
            //Tương tự với các chuỗi khác
            Console.WriteLine("level");
            Assert.AreEqual(true, unitTest.KiemTraPalindrome_17_PhanCongHieu("level"));
            Console.WriteLine("madam");
            Assert.AreEqual(true, unitTest.KiemTraPalindrome_17_PhanCongHieu("madam"));
            Console.WriteLine("1234321");
            Assert.AreEqual(true, unitTest.KiemTraPalindrome_17_PhanCongHieu("1234321"));
            Console.WriteLine("!@!");
            Assert.AreEqual(true, unitTest.KiemTraPalindrome_17_PhanCongHieu("!@!"));

            //Không phải chuỗi palindrome
            Console.WriteLine("hello");
            Assert.AreEqual(false, unitTest.KiemTraPalindrome_17_PhanCongHieu("hello")); 
            Console.WriteLine("!2@@");
            Assert.AreEqual(false, unitTest.KiemTraPalindrome_17_PhanCongHieu("!2@@"));

            //Trường hợp ngoại lệ
            Console.WriteLine("");
            Assert.AreEqual(false, unitTest.KiemTraPalindrome_17_PhanCongHieu(""));
        }

        [TestMethod]
        public void TestSoNguyenTo_14_VoLeHau()
        {
            //Trường hợp là số nguyên tố
            Console.WriteLine("2");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay ko
            Assert.AreEqual(true, unitTest.SoNguyenTo_14_VoLeHau(2));
            //Tương tự với các số khác
            Console.WriteLine("11");
            Assert.AreEqual(true, unitTest.SoNguyenTo_14_VoLeHau(11));
            Console.WriteLine("13");
            Assert.AreEqual(true, unitTest.SoNguyenTo_14_VoLeHau(13));
            Console.WriteLine("17");
            Assert.AreEqual(true, unitTest.SoNguyenTo_14_VoLeHau(17));

            //Trường hợp ko phải là số nguyên tố
            Console.WriteLine("1");
            Assert.AreEqual(false, unitTest.SoNguyenTo_14_VoLeHau(1));
            Console.WriteLine("12");
            Assert.AreEqual(false, unitTest.SoNguyenTo_14_VoLeHau(12));
            Console.WriteLine("-2");
            Assert.AreEqual(false, unitTest.SoNguyenTo_14_VoLeHau(-2));
        }
        [TestMethod]
        public void TestSoArmstrong_14_VoLeHau()
        {
            //Trường hợp là số armstrong
            Console.WriteLine("0");
            //Kiểm tra giá trị mong đợi có bằng với giá trị kiểm tra được hay ko
            Assert.AreEqual(true, unitTest.SoArmstrong_14_VoLeHau(0));
            //Tương tự với các số khác
            Console.WriteLine("153");
            Assert.AreEqual(true, unitTest.SoArmstrong_14_VoLeHau(153));
            Console.WriteLine("370");
            Assert.AreEqual(true, unitTest.SoArmstrong_14_VoLeHau(370));
            //Trường hợp ko phải là số armstrong
            Console.WriteLine("-30");
            Assert.AreEqual(false, unitTest.SoArmstrong_14_VoLeHau(-30));
            Console.WriteLine("100");
            Assert.AreEqual(false, unitTest.SoArmstrong_14_VoLeHau(100));
            Console.WriteLine("999");
            Assert.AreEqual(false, unitTest.SoArmstrong_14_VoLeHau(999));
        }
    }
}

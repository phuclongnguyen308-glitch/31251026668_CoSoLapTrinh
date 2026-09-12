using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Exercise_2_No_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int TC1 = 4, TC2 = 3, TC3 = 2;

            Console.Write("Nhap diem mon Lap trinh C# (4 TC): ");
            double Diem1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem mon Toan roi rac (3 TC): ");
            double Diem2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap diem mon Tieng Anh (2 TC): ");
            double Diem3 = Convert.ToDouble(Console.ReadLine());

            int TongTC = TC1 + TC2 + TC3;
            double DiemTB = (Diem1 * TC1 + Diem2 * TC2 + Diem3 * TC3) / TongTC;

            string DiemChu = "";
            double Thang4 = 0.0;
            string XepLoai = "";

            if (DiemTB >= 8.5)
            {
                DiemChu = "A";
                Thang4 = 4.0;
                XepLoai = "Xuat sac / Gioi";
            }
            else if (DiemTB >= 7.0)
            {
                DiemChu = "B";
                Thang4 = 3.0;
                XepLoai = "Kha";
            }
            else if (DiemTB >= 5.5)
            {
                DiemChu = "C";
                Thang4 = 2.0;
                XepLoai = "Trung binh";
            }
            else if (DiemTB >= 4.0)
            {
                DiemChu = "D";
                Thang4 = 1.0;
                XepLoai = "Yeu";
            }
            else
            {
                DiemChu = "F";
                Thang4 = 0.0;
                XepLoai = "Kem (Truot)";
            }

            Console.WriteLine($"Diem TB Thang 10: {DiemTB:F2}");
            Console.WriteLine($"Diem Chu Quy Doi: {DiemChu}");
            Console.WriteLine($"Diem GPA Thang 4: {Thang4:F1}");
            Console.WriteLine($"Xep Loai Hoc Luc: {XepLoai}");
        }
    }
}

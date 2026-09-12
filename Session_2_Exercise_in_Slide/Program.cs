using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_2_Exercise_in_Slide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tinh tong hai so
            Console.WriteLine("Tinh tong hai so:");
            Console.Write("Nhap so thu nhat:");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tong: {a1} + {b1} = {a1 + b1}");

            // Doi gia tri hai so
            Console.WriteLine("Doi gia tri hai so:");
            Console.Write("Nhap so thu nhat:");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so thu hai:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Truoc khi doi gia tri: a = {a2}, b = {b2}");
            int temp = a2;
            a2 = b2;
            b2 = temp;
            Console.WriteLine($"Sau khi doi gia tri: a = {a2}, b = {b2}");

            // Tinh tich hai so
            Console.WriteLine("Tinh tich hai so:");
            Console.Write("Nhap so thuc thu nhat: ");
            float a3 = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thuc thu hai: ");
            float b3 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Tich: {a3} * {b3} = {a3 * b3}");

            // Doi tu feet sang met
            Console.WriteLine("Doi tu feet sang met:");
            Console.Write("Nhap so feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{feet} feet = {feet * 0.3048} m");

            // Doi tu do C sang do F va nguoc lai
            Console.WriteLine("Doi tu do C sang do F va nguoc lai:");
            Console.Write("Nhap do C: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{celsius} do C = {(celsius * 9 / 5) + 32} do F");
            Console.Write("Nhap do F: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{fahrenheit} do F = {(fahrenheit - 32) * 5 / 9} do C");

            // In ra size cac kieu du lieu
            Console.WriteLine("In ra size cac kieu du lieu:");
            Console.WriteLine($"Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");

            // In ra gia tri ASCII cua mot ky tu
            Console.WriteLine("In ra gia tri ASCII cua mot ky tu:");
            Console.Write("Nhap mot ky tu: ");
            char bai7 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Gia tri ASCII cua '{bai7}' là: {(int)bai7}");

            // Tinh ban kinh cua hinh tron
            Console.WriteLine("Tinh ban kinh cua hinh tron:");
            Console.Write("Nhap ban kinh: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh tron la: {Math.PI * r * r}");

            // Tinh dien tich cua hinh vuong
            Console.WriteLine("Tinh dien tich cua hinh vuong:");
            Console.Write("Nhap do dai canh: ");
            double a9 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Dien tich hinh vuong la: {a9 * a9}");

            // Doi so ngay thanh so nam, thang, ngay
            Console.WriteLine("Doi so ngay thanh so nam, thang, ngay:");
            Console.Write("Nhap tong so ngay: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());
            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int weeks = remainingDays / 7;
            int days = remainingDays % 7;
            Console.WriteLine($"{totalDays} ngay = {years} nam, {weeks} tuan, {days} ngay");
        }
    }
}

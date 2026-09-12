using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_CFS_No_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap so n va tinh tong chuoi harmonic den n
            Console.Write("Nhap N: ");
            int n = int.Parse(Console.ReadLine());

            double Tong = 0;
            for (int I = 1; I <= n; I++) Tong += 1.0 / I;

            Console.WriteLine($"Tong chuoi Harmonic: {Tong:F2}");
        }
    }
}

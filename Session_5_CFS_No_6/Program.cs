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
            // Nhap so N va tinh tong chuoi harmonic den N
            Console.Write("Nhap N: ");
            int N = int.Parse(Console.ReadLine());

            double Tong = 0;
            for (int I = 1; I <= N; I++) Tong += 1.0 / I;

            Console.WriteLine($"Tong chuoi harmonic den {N}: {Tong:F2}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_CFS_No_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap 10 so va tinh trung binh cua chung
            double Tong = 0;
            for (int I = 1; I <= 10; I++)
            {
                Console.Write($"Nhap so thu {I}: ");
                Tong += double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Tong: {Tong} | Trung binh: {Tong / 10:F2}");
        }
    }
}

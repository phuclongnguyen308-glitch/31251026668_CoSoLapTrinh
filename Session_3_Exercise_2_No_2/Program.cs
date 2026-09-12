using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Exercise_2_No_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu cao cua ban (m): ");
            double cao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap can nang cua ban (kg): ");
            double nang = Convert.ToDouble(Console.ReadLine());

            double BMI = nang / Math.Pow(cao, 2);

            string phanloai = "";
            if (BMI < 18.5)
            {
                phanloai = "Gay (Thieu can)";
            }
            else if (BMI < 23.0)
            {
                phanloai = "Binh thuong (Ly tuong)";
            }
            else if (BMI < 25.0)
            {
                phanloai = "Thua can (Tien beo phi)";
            }
            else
            {
                phanloai = "Beo phi";
            }

            double nangmin = 18.5 * cao * cao;
            double nangmax = 22.9 * cao * cao;

            Console.WriteLine($"Chi so BMI cua ban: {BMI:F2}");
            Console.WriteLine($"Phan loai suc khoe cua ban: {phanloai}");
            Console.WriteLine($"Khuyen dung: Can nang ly tuong cua ban nen tu {nangmin:F2} kg den {nangmax:F2} kg.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercise_3_PhuongTrinhBac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap he so cua bien bac hai: ");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so cua bien bac nhat: ");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap he so tu do: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A == 0)
            {
                if (B == 0)
                {
                    if (C == 0)
                    {
                        Console.WriteLine("Phuong trinh co vo so nghiem.");
                    }
                    else
                    {
                        Console.WriteLine("Phuong trinh vo nghiem.");
                    }
                }
                else
                {
                    double X = -C / B;
                    Console.WriteLine($"Phuong trinh co 1 nghiem duy nhat: x = {X:F2}");
                }
            }
            else
            {
                double Delta = B * B - 4 * A * C;

                if (Delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem.");
                }
                else if (Delta == 0)
                {
                    double X = -B / (2 * A);
                    Console.WriteLine($"Phuong trinh co nghiem kep: x1 = x2 = {X:F2}");
                }
                else
                {
                    double X1 = (-B + Math.Sqrt(Delta)) / (2 * A);
                    double X2 = (-B - Math.Sqrt(Delta)) / (2 * A);
                    Console.WriteLine($"Phuong trinh co 2 nghiem phan biet:");
                    Console.WriteLine($"x1 = {X1:F2}");
                    Console.WriteLine($"x2 = {X2:F2}");
                }
            }
        }
    }
}

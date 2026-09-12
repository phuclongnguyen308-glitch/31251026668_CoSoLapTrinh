using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercise_3_CFS_No_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap do dai canh a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap do dai canh b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap do dai canh c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Day la tam giac deu.");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Day la tam giac can.");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong (Scalene).");
                }
            }
            else
            {
                Console.WriteLine("Ba canh tren khong tao thanh tam giac!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercise_3_CFS_No_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so thu nhat: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so thu hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nhap so thu ba: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double Max = a;

            if (b > Max)
            {
                Max = b;
            }

            if (c > Max)
            {
                Max = c;
            }

            Console.WriteLine($"So lon nhat la: {Max}");
        }
    }
}

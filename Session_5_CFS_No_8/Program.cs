using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_CFS_No_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so can kiem tra: ");
            int So = int.Parse(Console.ReadLine());
            int DemUoc = 0;
            for (int I = 1; I <= So; I++)
            {
                if (So % I == 0)
                {
                    DemUoc++;
                }
            }

            if (DemUoc == 2)
            {
                Console.WriteLine($"So {So} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"So {So} KHONG la so nguyen to");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_CFS_No_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kiem tra so hoan hao
            Console.Write("Nhap so can kiem tra: ");
            int So = int.Parse(Console.ReadLine());

            int Tong = 0;
            for (int I = 1; I <= So / 2; I++)
            {
                if (So % I == 0)
                {
                    Tong += I;
                }
            }

            if (Tong == So && So > 0)
            {
                Console.WriteLine($"So {So} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"So {So} KHONG la so hoan hao");
            }
        }
    }
}

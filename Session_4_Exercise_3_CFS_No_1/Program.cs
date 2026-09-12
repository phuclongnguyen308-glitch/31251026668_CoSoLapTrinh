using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercise_3_CFS_No_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} la so chan.");
            }
            else
            {
                Console.WriteLine($"{a} la so le.");
            }
        }
    }
}

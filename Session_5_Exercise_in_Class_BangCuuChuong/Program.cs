using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_Exercise_in_Class_BangCuuChuong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int I = 1; I <= 10; I++)
            {
                Console.WriteLine($"Bang cuu chuong {I}");
                for (int J = 1; J <= 10; J++)
                {
                    int Tich = I * J;
                    Console.WriteLine($"{I} x {J} = {Tich}");
                }
            }
        }
    }
}

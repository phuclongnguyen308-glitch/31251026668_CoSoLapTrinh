using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_CFS_No_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap so hang va in ra tam giac so 
            Console.Write("Nhap so hang cua tam giac so: ");
            int N = int.Parse(Console.ReadLine());

            int Dem = 1;
            for (int I = 1; I <= N; I++)
            {
                for (int J = 1; J <= I; J++) Console.Write($"{Dem++} ");
                Console.WriteLine();
            }
        }
    }
}

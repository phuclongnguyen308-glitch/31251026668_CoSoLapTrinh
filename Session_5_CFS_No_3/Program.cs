using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_5_CFS_No_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nhap mot so va in ra bang cuu chuong cua so do
            Console.Write("Nhap mot so nguyen: ");
            int So = int.Parse(Console.ReadLine());

            Console.WriteLine($"Bang cuu chuong {So}");

            for (int I = 1; I <= 10; I++)
            Console.WriteLine($"{So} x {I} = {So * I}");
        }
    }
}

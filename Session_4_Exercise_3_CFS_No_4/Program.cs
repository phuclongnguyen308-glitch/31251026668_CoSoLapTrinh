using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4_Exercise_3_CFS_No_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap toa do X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhap toa do Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu nhat");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu hai");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu ba");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Toa do ({x},{y}) nam o goc phan tu thu tu");
            }
            else
            {
                Console.WriteLine($"Toa do ({x},{y}) nam tai goc toa do");
            }
        }
    }
}

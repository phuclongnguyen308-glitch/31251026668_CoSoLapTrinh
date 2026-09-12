using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Exercise_2_No_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so tien VND: ");
            decimal vnd = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Chon ngoai te (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int LuaChon = Convert.ToInt32(Console.ReadLine());

            decimal PhiDichVu = vnd * 0.005m;
            decimal VNDThucTe = vnd - PhiDichVu;

            decimal TyGia = 0m;
            string KyHieu = "";

            if (LuaChon == 1)
            {
                TyGia = 25400m;
                KyHieu = "USD";
            }
            else if (LuaChon == 2)
            {
                TyGia = 27200m;
                KyHieu = "EUR";
            }
            else if (LuaChon == 3)
            {
                TyGia = 165m;
                KyHieu = "JPY";
            }
            else if (LuaChon == 4)
            {
                TyGia = 32100m;
                KyHieu = "GBP";
            }
            else
            {
                Console.WriteLine("Loai ngoai te khong hop le!");
                return;
            }

            decimal NgoaiTe = VNDThucTe / TyGia;

            Console.WriteLine($"Phi dich vu (0.5%): {PhiDichVu:N0} VND");
            Console.WriteLine($"So tien VND quy doi: {VNDThucTe:N0} VND");
            Console.WriteLine($"So tien {KyHieu} nhan duoc: {NgoaiTe:F2} {KyHieu}");
        }
    }
}

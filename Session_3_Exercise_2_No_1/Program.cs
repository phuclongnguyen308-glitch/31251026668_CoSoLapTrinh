using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Exercise_2_No_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chi so dien cu (kWh): ");
            int cu = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap chi so dien moi (kWh): ");
            int moi = Convert.ToInt32(Console.ReadLine());
            if (moi < cu)
            {
                Console.WriteLine("Loi. Chi so moi phai lon hon hoac bang chi so cu");
                return;
            }

            int LuongDienTieuThu = moi - cu;
            decimal GiaChuaThue = 0;

            if (LuongDienTieuThu <= 50)
            {
                GiaChuaThue = LuongDienTieuThu * 1806m;
            }
            else if (LuongDienTieuThu <= 100)
            {
                GiaChuaThue = 50 * 1806m + (LuongDienTieuThu - 50) * 1866m;
            }
            else if (LuongDienTieuThu <= 200)
            {
                GiaChuaThue = 50 * 1806m + 50 * 1866m + (LuongDienTieuThu - 100) * 2167m;
            }
            else if (LuongDienTieuThu <= 300)
            {
                GiaChuaThue = 50 * 1806m + 50 * 1866m + 100 * 2167m + (LuongDienTieuThu - 200) * 2729m;
            }
            else
            {
                GiaChuaThue = 50 * 1806m + 50 * 1866m + 100 * 2167m + 100 * 2729m + (LuongDienTieuThu - 300) * 3050m;
            }
            decimal VAT = GiaChuaThue * 0.08m;
            decimal TongThanhToan = GiaChuaThue + VAT;

            Console.WriteLine($"So dien tieu thu: {LuongDienTieuThu} kWh");
            Console.WriteLine($"Tien dien chua thue: {GiaChuaThue:N0} VND");
            Console.WriteLine($"Thue VAT (8%): {VAT:N0} VND");
            Console.WriteLine($"Tong thanh toan: {TongThanhToan:N0} VND");
        }
    }
}

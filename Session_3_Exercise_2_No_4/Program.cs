using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_3_Exercise_2_No_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ngay sinh (dd/MM/yyyy): ");
            string ChuoiNgaySinh = Console.ReadLine();

            DateTime NgaySinh;
            bool HopLe = DateTime.TryParseExact(ChuoiNgaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NgaySinh);

            if (!HopLe)
            {
                Console.WriteLine("Loi dinh dang");
                return;
            }

            DateTime NgayHienTai = DateTime.Now.Date;

            int Tuoi = NgayHienTai.Year - NgaySinh.Year;

            if (NgayHienTai < NgaySinh.AddYears(Tuoi))
            {
                Tuoi--;
            }

            int TongSoNgaySong = (int)(NgayHienTai - NgaySinh).TotalDays;

            DateTime SinhNhatTiepTheo = new DateTime(NgayHienTai.Year, NgaySinh.Month, NgaySinh.Day);

            if (SinhNhatTiepTheo < NgayHienTai)
            {
                SinhNhatTiepTheo = SinhNhatTiepTheo.AddYears(1);
            }

            int SoNgayConLai = (int)(SinhNhatTiepTheo - NgayHienTai).TotalDays;

            Console.WriteLine($"Tuoi hien tai: {Tuoi} tuoi");
            Console.WriteLine($"Ban da song tong cong: {TongSoNgaySong:N0} ngay");
            Console.WriteLine($"Sinh nhat tiep theo con: {SoNgayConLai} ngay nua");
        }
    }
}

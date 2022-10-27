using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhomQ3H.Entities
{
    internal class NhaQuanLy : NhanVien
    {
        public int SoNgayCong { get; set; }
        public int BacLuong { get; set; }
        public string ChucVu { get; set; }

        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap so ngay cong: ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap bac luong: ");
            BacLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap chuc vu: ");
            ChucVu = Console.ReadLine();
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So ngay cong: "+ SoNgayCong);
            Console.WriteLine("Bac luong: "+ BacLuong);
            Console.WriteLine("Chuc vu: "+ ChucVu);
        }
        public override int tinhLuong()
        {
            return BacLuong * SoNgayCong;
        }
    }   
}

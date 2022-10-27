using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhomQ3H.Entities
{
    internal class NhanVienPhongThiNghiem : NhanVien
    {
        public int LuongTrongThang { get; set; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap luong trong thang: ");
            LuongTrongThang = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("Luong trong thang: "+ LuongTrongThang);
        }
        public override int tinhLuong()
        {
            return LuongTrongThang;
        }
    }
}

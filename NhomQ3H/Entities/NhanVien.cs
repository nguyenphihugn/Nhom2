using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NhomQ3H.Entities
{
    internal abstract class NhanVien
    {
        public string HoTen { get; set; }
        public int NamSinh { get; set; }
        public string BangCap { get; set; }
        public virtual void nhap()
        {
            Console.Write("Nhap ho ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            NamSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap bang cap: ");
            BangCap = Console.ReadLine();
        }
        public virtual void xuat()
        {
            Console.WriteLine("Ten: " + HoTen);
            Console.WriteLine("Nam sinh: "+ NamSinh);
            Console.WriteLine("Bang cap: " + BangCap);
        }
        public abstract int tinhLuong();
    }
}

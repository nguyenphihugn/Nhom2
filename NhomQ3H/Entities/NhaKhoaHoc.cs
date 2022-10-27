using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NhomQ3H.Entities
{
    internal class NhaKhoaHoc : NhaQuanLy
    {
        public int SoBaiBao { get; set; }
        public override void nhap()
        {
            base.nhap();
            Console.Write("Nhap so bai bao: ");
            SoBaiBao = int.Parse(Console.ReadLine());
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So bai bao: " + SoBaiBao);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhomQ3H.Entities;

namespace NhomQ3H
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VienKhoaHoc app = new VienKhoaHoc();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================== Menu =================");
                Console.WriteLine("= 1. Them nhan vien                      =");
                Console.WriteLine("= 2. Xuat danh sach nhan vien            =");
                Console.WriteLine("= 3. Thong ke luong cua nhan vien        =");
                Console.WriteLine("= 0. Thoat chuong trinh                  =");
                Console.WriteLine("==========================================");
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Nhap so luong nhan vien: ");
                        int soLuong = int.Parse(Console.ReadLine());
                        app.nhapds(soLuong);
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        app.xuatds();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        app.InTongLuong();
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Chuong trinh ket thuc !!!!");
                        Console.ReadKey();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

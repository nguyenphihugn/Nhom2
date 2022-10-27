using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NhomQ3H.Entities;

namespace NhomQ3H.Entities
{
    internal class VienKhoaHoc
    {
        public List<NhanVien> danhSachNhanVien;
        public VienKhoaHoc()
        {
            danhSachNhanVien = new List<NhanVien>();
        }
        public void nhapds(int soLuong)
        {
            NhanVien nhanvien = null;
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("============== Chon nhan vien ============");
                Console.WriteLine("= 1. Nha khoa hoc                        =");
                Console.WriteLine("= 2. Nha quan ly                         =");
                Console.WriteLine("= 3. Nhan vien phong thi nghiem          =");
                Console.WriteLine("= 0. Thoat                               =");
                Console.WriteLine("==========================================");
                int x = 0;
                int loaiNhanVien = int.Parse(Console.ReadLine());
                switch (loaiNhanVien)
                {
                    case 1: nhanvien = new NhaKhoaHoc();
                        break;
                    case 2: nhanvien = new NhaQuanLy();
                        break;
                    case 3: nhanvien = new NhanVienPhongThiNghiem();
                        break;
                    default: x = 1; break;
                }
                if (x == 0)
                {
                    nhanvien.nhap();
                    danhSachNhanVien.Add(nhanvien);
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }
        }
        public void xuatds()
        {
            Console.WriteLine("=============== DS Nhan vien =============");
            Console.WriteLine("-- Nha khoa hoc:");
            foreach (NhanVien nhanvien in danhSachNhanVien)
            {
                if (nhanvien.GetType() == typeof(NhaKhoaHoc))
                {
                    nhanvien.xuat();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-- Nha quan ly:");
            foreach (NhanVien nhanvien in danhSachNhanVien)
            {
                if (nhanvien.GetType() == typeof(NhaQuanLy) && (nhanvien.GetType() != typeof(NhaKhoaHoc)))
                {
                    nhanvien.xuat();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-- Nhan vien phong thi nghiem:");
            foreach (NhanVien nhanvien in danhSachNhanVien)
            {
                if (nhanvien.GetType() == typeof(NhanVienPhongThiNghiem))
                {
                    nhanvien.xuat();
                    Console.WriteLine();
                }
            }
            Console.WriteLine("==========================================");
        }
        public void InTongLuong()
        {
            Console.WriteLine("============== Tong Luong NV =============");
            Console.WriteLine("Tong luong nha khoa hoc: {0}", danhSachNhanVien.OfType<NhaKhoaHoc>().Sum(x=>x.tinhLuong()));
            Console.WriteLine("Tong luong nha quan ly: {0}", danhSachNhanVien.OfType<NhaQuanLy>().Sum(x => x.tinhLuong()) - danhSachNhanVien.OfType<NhaKhoaHoc>().Sum(x => x.tinhLuong()));
            Console.WriteLine("Tong luong nhan vien phong thi nghiem: {0}", danhSachNhanVien.OfType<NhanVienPhongThiNghiem>().Sum(x => x.tinhLuong()));
            Console.WriteLine("==========================================");
        }
    }
}

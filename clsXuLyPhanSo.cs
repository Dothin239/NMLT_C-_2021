using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    public struct PhanSo
    {
        public int TuSo;
        public int MauSo;

    }

    public class clsXuLyPhanSo
    {
        public static PhanSo NhapPhanSo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            PhanSo kq;
            kq.TuSo = clsXulySoNguyen.NhapSoNguyen("Nhap Tu So:");
            kq.MauSo = clsXulySoNguyen.NhapSoNguyen("Nhap Mau So:");
            return kq;
        }
        public static void XuatPhanSo(PhanSo p)
        {
            Console.Write($"{p.TuSo}/{p.MauSo}");
        }
        
        public static PhanSo Cong2PhanSo(PhanSo a, PhanSo b)
        {
            PhanSo kq;
            kq.TuSo = a.TuSo * b.MauSo + a.MauSo * b.TuSo;
            kq.MauSo = a.MauSo * b.MauSo;
            return kq;
        }
    }
}

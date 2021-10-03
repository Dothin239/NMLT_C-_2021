using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsBaiTapKieuCauTruc
    {
        public static void NhapXuatPhanSo()
        {
            //Nhap 2 phan so
            PhanSo a, b;

            a = clsXuLyPhanSo.NhapPhanSo("Nhap phan so a:");
            b = clsXuLyPhanSo.NhapPhanSo("Nhap phan so b:");

            //Tinh Tong
            PhanSo kq;
            kq = clsXuLyPhanSo.Cong2PhanSo(a, b);


            Console.WriteLine();
            clsXuLyPhanSo.XuatPhanSo(a);
            Console.WriteLine();
            clsXuLyPhanSo.XuatPhanSo(b);
            Console.WriteLine();
            Console.Write($"Tong hai phan so a va b la: ");
            clsXuLyPhanSo.XuatPhanSo(kq);
            Console.WriteLine();
        }

        public static void NhapToaDo()
        {
            //Nhap toa do 2 diem
            DIEM a, b;

            a = clsXuLyToaDo2Chieu.NhapToaDo("Nhap toa do diem a: ");
            b = clsXuLyToaDo2Chieu.NhapToaDo("Nhap toa do diem b: ");

            //Xuat toa do 2 diem
            Console.WriteLine();
            clsXuLyToaDo2Chieu.XuatToaDoDiem(a);
            Console.WriteLine();
            clsXuLyToaDo2Chieu.XuatToaDoDiem(b);

            //Tinh Khoang Cach
            double kq;
            kq = clsXuLyToaDo2Chieu.TinhKhoangCach2Diem(a, b);
            Console.WriteLine();
            Console.Write($"Khoang cach hai diem a va b la: {kq}");
            Console.WriteLine();
        }

        public static void NhapTamGiac()
        {
            //Nhap toa do 3 dinh tam giac
            TAMGIAC T;
            T = clsXuLyToaDo2Chieu.NhapToaDo3Dinh("Nhap toa do Tam Giac: ");

            //Xuat toa do 3 dinh
            Console.WriteLine();
            clsXuLyToaDo2Chieu.XuatToaDo3Dinh(T);

            //Tinh chu vi
            double ChuVi = clsXuLyToaDo2Chieu.TinhChuViTamGiac(T);
            Console.Write($"Chu vi Tam Giac la: {ChuVi}");
            Console.WriteLine();
        }
    }
}

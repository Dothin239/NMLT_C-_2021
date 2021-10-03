using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    public struct DIEM
    {
        public int X;
        public int Y;
    }

    public struct TAMGIAC
    {
        public DIEM A;
        public DIEM B;
        public DIEM C;
    }

    public class clsXuLyToaDo2Chieu
    {
        public static DIEM NhapToaDo(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            DIEM kq;
            kq.X = clsXulySoNguyen.NhapSoNguyen("Nhap toa do X: ");
            kq.Y = clsXulySoNguyen.NhapSoNguyen("Nhap toa do Y: ");
            return kq;
        }
        public static void XuatToaDoDiem(DIEM A)
        {
            Console.Write($"({A.X},{A.Y})");
        }
        public static double TinhKhoangCach2Diem(DIEM a, DIEM b)
        {
            //return Math.Sqrt(((a.X - b.X) * (a.X - b.X)) + ((a.Y - b.Y) * (a.Y - b.Y)));
            return Math.Sqrt((Math.Pow((a.X - b.X), 2)) + (Math.Pow((a.Y - b.Y), 2)));
        }

        public static TAMGIAC NhapToaDo3Dinh(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            TAMGIAC kq;
            kq.A = NhapToaDo("Nhap Toa Do Dinh A: ");
            kq.B = NhapToaDo("Nhap Toa Do Dinh B: ");
            kq.C = NhapToaDo("Nhap Toa Do Dinh C: ");
            return kq;
        }

        public static void XuatToaDo3Dinh(TAMGIAC T)
        {
            Console.Write($"Toa do ba dinh cua Tam Giac la: ");
            XuatToaDoDiem(T.A);
            Console.Write(" / ");
            XuatToaDoDiem(T.B);
            Console.Write(" / ");
            XuatToaDoDiem(T.C);
        }

        public static double TinhChuViTamGiac(TAMGIAC T)
        {
            double Canh1, Canh2, Canh3;
            Canh1 = TinhKhoangCach2Diem(T.A, T.B);
            Canh2 = TinhKhoangCach2Diem(T.B, T.C);
            Canh3 = TinhKhoangCach2Diem(T.A, T.C);
            return Canh1 + Canh2 + Canh3;
        }
    }
}

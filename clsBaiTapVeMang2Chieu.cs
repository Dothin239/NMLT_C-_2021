using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsBaiTapVeMang2Chieu
    {
        public static void BaiMau1()
        {
            //Nhap ma tran
            int[,] A;
            A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran:");

            //Xuat ma tran
            clsXuLyMang2Chieu.XuatMaTran(A);

            //Tinh tong ma tran
            int kq = clsXuLyMang2Chieu.TinhTongMaTranSoNguyen(A);

        }

        public static void Bai315()
        {
            Console.WriteLine("Bài 315: Viết hàm tìm giá trị lớn nhất trong ma trận số thực");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int max = clsXuLyMang2Chieu.TimMaxSoNguyenMaTran(A);
            Console.WriteLine($"Gia tri lon nhat ma tran la: {max}");
        }

        public static void Bai317()
        {
            Console.WriteLine("Bài 317: Viết hàm đếm số lượng số nguyên tố trong ma trận số nguyên");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int dem = clsXuLyMang2Chieu.DemSoNguyenToMaTran(A);
            Console.WriteLine($"Ket qua la: {dem}");
        }

        public static void Bai319()
        {
            Console.WriteLine("Viết hàm sắp xếp ma trận các số thực tăng dần từ trên xuống dưới và từ trái sang phải");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Mang ban dau");
            clsXuLyMang2Chieu.XuatMaTran(A);
            clsXuLyMang2Chieu.SapXepMaTranTangDan(A);
            Console.WriteLine();
            Console.WriteLine("Mang sap xep");
            clsXuLyMang2Chieu.XuatMaTran(A);
            Console.WriteLine();
        }

        public static void Bai322()
        {
            Console.WriteLine("Bài 322: Tính tổng giá trị trên 1 dòng trong ma trận các số thực");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            //int dong = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Nhap so dong: {dong}");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int kq = clsXuLyMang2Chieu.TinhTongDongMaTranSoNguyen(A,1);
            Console.WriteLine($"Ket qua la: {kq}");
        }

        public static void Bai323()
        {
            Console.WriteLine("Bài 323: Tính tích giá trị dương trên 1 cột trong ma trận các số thực");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            //int dong = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Nhap so dong: {dong}");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int kq = clsXuLyMang2Chieu.TinhTichSoNguyenDuongCuaCot(A, 1);
            Console.WriteLine($"Ket qua la: {kq}");
        }

        public static void Bai327()
        {
            Console.WriteLine("Bài 327: Tính tổng giá trị nằm trên biên của ma trận");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int kq = clsXuLyMang2Chieu.TinhTongGiaTriBienMaTran(A);
            Console.WriteLine($"Ket qua la: {kq}");
        }

        public static void Bai336()
        {
            Console.WriteLine("Bài 336: Đếm tần suất xuất hiện của 1 giá trị x trong ma trận các số thực");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int kq = clsXuLyMang2Chieu.DemSoLanXuatHien(A,3);
            Console.WriteLine($"Ket qua la: {kq}");
        }

        public static void Bai342()
        {
            Console.WriteLine("Bài 342(*): Đếm số lượng phần tử cực đại trong ma trận các số thực. Một phần tử được gọi là cực đại khi nó lớn hơn các phần tử xung quanh");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int kq = clsXuLyMang2Chieu.DemPhanTuCucDaiMaTran(A);
            Console.WriteLine($"Ket qua la: {kq}");
        }

        public static void Bai346()
        {
            Console.WriteLine("Bài 346(*): Đếm số lượng giá trị “Hoàng Hậu” trên ma trận. Một phần tử được gọi là Hoàng Hậu khi nó lớn nhất trên dòng, trên cột và 2 đường chéo đi qua nó");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            int kq = clsXuLyMang2Chieu.DemSoLuongGiaTriHoangHau(A);
            Console.WriteLine($"Ket qua la: {kq}");
        }

        public static void Bai364()
        {
            Console.WriteLine("Bài 364: Cho 2 ma trận A và B. Kiểm tra xem ma trận A có là ma trận con của ma trận B hay không");
            int[,] A = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            int[,] B = clsXuLyMang2Chieu.NhapMaTran("Nhap ma tran");
            clsXuLyMang2Chieu.XuatMaTran(A);
            clsXuLyMang2Chieu.XuatMaTran(B);
            bool kq = clsXuLyMang2Chieu.KiemTraMaTranCon(A,B);
            Console.WriteLine($"Ket qua la: {kq}");
        }
    }
}

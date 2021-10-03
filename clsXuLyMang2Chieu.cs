using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsXuLyMang2Chieu
    {
        public static int[,] NhapMaTran(string GhiChu)
        {
            Console.WriteLine(GhiChu);
            int[,] A;
            //Nhap ma tran
            Console.WriteLine("Nhap so dong:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot:");
            int M = int.Parse(Console.ReadLine());
            A = new int[N, M];
            for (int i = 0; i < A.GetLength(0); i++) //Lay so dong
            {
                for (int j = 0; j < A.GetLength(1); j++) //Lay so cot
                {
                    Console.WriteLine($"Nhap A[{i},{j}]");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return A;
            //Tinh tong
        }

        public static void XuatMaTran(int[,] A)
        {
            Console.WriteLine("Cac phan tu cua mang 2 chieu:");
            //Xuat ma tran
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"{A[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public static int TinhTongMaTranSoNguyen(int[,] A)
        {
            Console.WriteLine("Tong cac phan tu cua mang 2 chieu:");
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    S += A[i ,j];
                }
            }
            return S;
        }

        public static int TimMaxSoNguyenMaTran(int[,] A)
        {
            int max = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                    }
                }
            }
            return max;
        }

        public static int DemSoNguyenToMaTran(int[,] A)
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (clsXulySoNguyen.isNguyenTo(A[i, j]) == true)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        public static int TinhTongDongMaTranSoNguyen(int[,] A, int k)
        {
            int S = 0;
            for (int j = 0; j < A.GetLength(1); j++)
            {
                S += A[k, j];
            }
            return S;
        }

        public static int TinhTongCotMaTranSoNguyen(int[,] A, int k)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                S += A[k, i];
            }
            return S;
        }

        public static int TinhTichSoNguyenDuongCuaCot(int[,] A, int k)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                if (clsXulySoNguyen.isSoNguyenAm(A[k, i]) == false)
                {
                    S = S * A[i, k];
                }
            }
            return S;
        }

        public static int TinhTongGiaTriBienMaTran(int[,] A)
        {
            int S = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == 0 || i == A.GetLength(0) - 1 || j == 0 || j == A.GetLength(1) - 1)
                    {
                        S += A[i, j];
                    }
                }
            }
            return S;
        }

        public static void SapXepMaTranTangDan(int[,] A)
        {
            int N = A.GetLength(0) * A.GetLength(1);
            int M = A.GetLength(1);
            for (int i = 0; i < N - 1; i++)
            {
                //Dua gia tri nho nhat o phia sau ve vi tri i
                for (int j = i + 1; j < N; j++)
                {
                    if (A[i / M, i % M] > A[j / M, j % M])
                    {
                        int t = A[i / M, i % M];
                        A[i / M, i % M] = A[j / M, j % M];
                        A[j / M, j % M] = t;
                    }
                }
            }
        }

        public static int DemSoLanXuatHien(int[,] A, int x)
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (A[i, j] == x)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        public static int DemPhanTuCucDaiMaTran(int[,] A)
        {
            int[] dx = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] dy = { -1, 0, 1, -1, 1, -1, 0, 1 };
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    //Kiem tra A[i,j] thoa dieu kien
                    bool isOK = true;
                    for (int k = 0; k < 8; k++)
                    {
                        //Kiem tra phan tu hop le
                        if (i + dx[k] >= 0 && i + dx[k] < A.GetLength(0) &&
                            j + dy[k] >= 0 && i + dy[k] < A.GetLength(1))
                        {
                            if (A[i, j] <= A[i + dx[k], j + dy[k]])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }
                    if (isOK)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        public static int DemSoLuongGiaTriHoangHau(int[,] A)
        {
            int dem = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(0); j++)
                {
                    //Kiem tra A[i,j] thoa dieu kien
                    bool isOK = true;
                    //Kiem tra dong
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        if (A[i, j] < A[i, k])
                        {
                            isOK = false;
                            break;
                        }
                    }

                    //Kiem tra cot
                    if (isOK)
                    {
                        for (int k = 0; k < A.GetLength(0); k++)
                        {
                            if (A[i, j] < A[i, k])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }

                    //Kiem tra cheo chinh (duong cheo di tu trai qua phai)
                        //Cheo chinh tren
                    if (isOK)
                    {
                        for (int k = 1; k <= Math.Min(i,j); k++)
                        {
                            if (A[i, j] < A[i - k, j - k])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }
                        //Cheo chinh duoi
                    if (isOK)
                    {
                        for (int k = 1; k <= Math.Min(A.GetLength(0) - 1 - i, A.GetLength(1) - 1 - j); k++)
                        {
                            if (A[i, j] < A[i + k, j + k])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }


                    //Kiem tra cheo phu (duong cheo di tu phai qua trai)
                        //Cheo phu tren
                    if (isOK)
                    {
                        for (int k = 1; k <= Math.Min(i, A.GetLength(1) - 1 - j); k++)
                        {
                            if (A[i, j] < A[i - k, j + k])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }
                        //Cheo phu duoi
                    if (isOK)
                    {
                        for (int k = 1; k <= Math.Min(j, A.GetLength(0) - 1 - i); k++)
                        {
                            if (A[i, j] < A[i + k, j - k])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }

                    if (isOK)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }

        public static bool KiemTraMaTranCon(int[,] A, int[,] B)
        {
            for (int iB = 0; iB < B.GetLength(0) - A.GetLength(0); iB++)
            {
                for (int jB = 0; jB < B.GetLength(1) - A.GetLength(1); jB++)
                {
                    //Kiem tra coi A co la con B tai iB, jB hay k
                    bool isOK = true;
                    for (int iA = 0; iA < A.GetLength(0); iA++)
                    {
                        for (int jA = 0; jA < A.GetLength(1); jA++)
                        {
                            if (B[iB + iA, jB + jA] != A[iA, jA])
                            {
                                isOK = false;
                                break;
                            }
                        }
                    }
                    if (isOK) return true;
                }
            }
            return false;
        }
    }
}
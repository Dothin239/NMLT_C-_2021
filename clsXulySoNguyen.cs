using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsXulySoNguyen
    {
        public static bool isNguyenTo(int N)
        {
            if (N <= 1) return false;
            for (int i = 2; i < N; i++)
            {
                if (N % i == 0) return false;
            }
            return true;
        }

        public static bool isSoHoanThien(int A)
        {
            int S = 0;
            for (int i = 1; i < A; i++)
            {
                if (A % i == 0)
                {
                    S += i;
                }
                if (S == A && S != 1) return true;
            }
            return false;
        }

        public static bool isSoNguyenChan(int A)
        {
            if (A % 2 == 0) return true;
            return false;
        }

        public static bool isSoNguyenAm(int A)
        {
            if (A < 0) return true;
            return false;
        }

        public static int KhoangCachSoNguyenXaNhat(int[] A, int X)
        {
            int maxDistance = Math.Abs(A[0] - X);
            int Val = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (Math.Abs(A[i] - X) > maxDistance)
                {
                    maxDistance = Math.Abs(A[i] - X);
                    Val = A[i];
                }
            }
            return maxDistance;
        }

        public static int KhoanhCachSoNguyenGanNhat(int[] A, int X)
        {
            int minDistance = Math.Abs(A[0] - X);
            int Val = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (Math.Abs(A[i] - X) < minDistance)
                {
                    minDistance = Math.Abs(A[i] - X);
                    Val = A[i];
                }
            }
            return minDistance;
        }

        public static int DauTienTrongDoanSoNguyen(int[] A, int X, int Y)
        {
            int dem = 0;
            int i = 0;
            for (i = 0; i < A.Length; i++)
            {
                if ((A[i] >= X) && (A[i] <= Y))
                {
                    dem++;
                    break;
                }    
            }
            if (dem != 0)
            {
                return A[i];
            }
            return -1;
        }

        public static bool isSoChinhPhuong(int A)
        {
            if (Math.Sqrt((double)A) == (int)Math.Sqrt((double)A))
            {
                return true;
            }
            return false;
        }

        public static bool isSoGanh(int A)
        {
            int SoDao = 0;
            int donvi = A;
            if (A / 10 != 0) //điều kiện để loại trừ những số chỉ có hàng đơn vị (tương tự đk lọc isChuSoDauTienLe)
            {
                while (donvi != 0)
                {
                    SoDao = SoDao * 10 + donvi % 10;
                    donvi /= 10; 
                }
            }    
            if (A == SoDao)
            {
                return true;
            }
            return false;
        }

        public static bool isChuSoDauTienLe(int A)
        {
            int donvi = 0;
            while (Math.Abs(A) >= 10) //điều kiện để lọc ra số đầu tiên, lấy Abs để bao gồm TH số âm (tương tự đk lọc isSoGanh)
            {
                donvi = A % 10;
                A /= 10;
            }    
            if (A % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public static bool isSoNguyenDang2muK(int A)
        {
            int n = A;
            if (n <= 1)
            {
                return false;
            }
            while (n >= 1)
            {
                int du = n % 2;
                n /= 2;
                if (du != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isSoNguyenDang5muK(int A)
        {
            int n = A;
            if (n <= 5)
            {
                return false;
            }
            while (n >= 5)
            {
                int du = n % 5;
                n /= 5;
                if (du != 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isSoNguyenToanChuSoLe(int A)
        {
            int n = A;
            while (n != 0)
            {
                int dv = n % 10;
                n /= 10;
                if (dv % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int NhapSoNguyen(string ghiChu)
        {
            Console.WriteLine(ghiChu);
            int a = int.Parse(Console.ReadLine());
            return a;
        }

        public static int Cong2SoNguyen(int a, int b)
        {
            return a + b;
        }

    }
}

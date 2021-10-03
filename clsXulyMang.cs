using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsXulyMang
    {
        public static int[] NhapMang()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập vào phần tử thứ {i}: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            return A;
        }
        public static double[] NhapMangSoThuc()
        {
            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            double[] A = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập vào phần tử thứ {i}: ");
                A[i] = double.Parse(Console.ReadLine());
            }
            return A;
        }

        public static void XuatMang(int[] A)
        {
            Console.Write("Các phần tử của mảng: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();
        }
        public static void XuatMangSoThuc(double[] A)
        {
            Console.Write("Các phần tử của mảng: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"{A[i]} ");
            }
            Console.WriteLine();
        }

        public static double MaxMangSoThuc(double[] A)
        {
            double max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max) max = A[i];
            }
            return max;
        }

        public static int MaxMangSoNguyen(int[] A)
        {
            int max = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max) max = A[i];
            }
            return max;
        }

        public static int MinMangSoNguyen(int[] A)
        {
            int min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min) min = A[i];
            }
            return min;
        }
        public static double MinMangSoThuc(double[] A)
        {
            double min = A[0];
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min) min = A[i];
            }
            return min;
        }
        public static int ViTriMaxMangSoThuc(double[] A)
        {
            double max = A[0];
            int vitri = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    vitri = i;
                }
            }
            return vitri;
        }

        public static int ViTriMinMang(int[] A)
        {
            int min = A[0];
            int vitri = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    vitri = i;
                }
            }
            return vitri;
        }
        public static int ViTriMinMangSoThuc(double[] A)
        {
            double min = A[0];
            int vitri = 0;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    vitri = i;
                }
            }
            return vitri;
        }

        public static int [] SapXepMangTangdan(int[] A)
        {
            for (int i=0; i<A.Length; i++)
            {
                for (int j=i+1; j<A.Length; j++)
                {
                    if (A[j] < A[i]) {
                        int num = A[i];
                        A[i] = A[j];
                        A[j] = num;
                    }

                }
            }
            return A;
        }

        public static int [] DemChuSoNguyen(int[] A)
        {
            int[] dem = new int[10];
            //dem[3] = 7 ==> nghia là chu so 3 xuat hien 7 lan
            for (int i = 0; i < A.Length; i++)
            {
                int T = Math.Abs(A[i]);
                if (T == 0)
                {
                    dem[0]++;
                }    
                while (T > 0)
                {
                    int d = T % 10;
                    dem[d]++;
                    T /= 10;
                }    
            }
            return dem;
        }

        
    }
}

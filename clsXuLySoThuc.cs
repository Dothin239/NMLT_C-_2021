using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsXuLySoThuc
    {
        public static bool isSoThucAm(double A)
        {
            if (A < 0) return true;
            return false;
        }

        public static double KhoangCachSoThucXaNhat(double[] A, double X)
        {
            double maxDistance = Math.Abs(A[0] - X);
            double Val = 0;
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

        public static double KhoanhCachSoThucGanNhat(double[] A, double X)
        {
            double minDistance = Math.Abs(A[0] - X);
            double Val = 0;
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

        public static double DauTienTrongDoanSoThuc(double[] A, double X, double Y)
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

        public static double ViTriLanCanThoaDK(double[] A)
        {
            int i = 1;
            for (i = 1; i < A.Length - 2; i++)
            {
                if (A[i] == A[i-1] * A[i+1])
                {
                    return i;
                }    
            }
            return -1;
        }

    }
}

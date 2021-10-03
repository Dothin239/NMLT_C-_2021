using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap
{
    class clsBaiTapVeMang
    {
        public static int[] TaoMangNgauNhien()
        {
            System.Random random = new System.Random();
            int n = random.Next(minValue: 5, maxValue: 20);
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = random.Next(minValue: -2000, maxValue: 2000);
            }
            A[5] = 2;
            return A;
        }

        public static double[] TaoMangSoThucNgauNhien()
        {
            System.Random random = new System.Random();
            int n = random.Next(minValue: 5, maxValue: 20);
            double[] A = new double[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = random.Next(minValue: -2000, maxValue: 2000);
            }
            A[5] = 2;
            return A;
        }

        public static void Bai122()
        {
            Console.WriteLine("Bài 122: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");

            double[] A = clsXulyMang.NhapMangSoThuc();
            double max = clsXulyMang.MaxMangSoThuc(A);
            Console.WriteLine($"Phần tử có giá trị lớn nhất trong mảng là: {max}");
        }
        public static void Bai123()
        {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");

            int[] A = clsXulyMang.NhapMang();
            int vitri = clsXulyMang.ViTriMinMang(A);
            Console.WriteLine($"Vị trí có giá trị nhỏ nhất trong mảng: {vitri}");
        }
        public static void Bai124()
        {
            Console.WriteLine("Viết hàm kiểm tra trong mảng các số nguyên có tồn tại giá trị chẵn nhỏ hơn 2004 hay không");

            int[] A = clsXulyMang.NhapMang();
            bool tontai = false;
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] < 2004 && A[i] % 2 == 0)
                {
                    tontai = true;
                    break;
                };
            }
            if (tontai)
                Console.WriteLine($"Có tồn tại số chẵn nhỏ hơn 2004");
            else
                Console.WriteLine($"Không tồn tại số chẵn nhỏ hơn 2004");
        }
        public static void Bai125()
        {
            Console.WriteLine("Bài 125: Viết hàm đếm số lượng số nguyên tố nhỏ hơn 100 trong mảng");
            int[] A = TaoMangNgauNhien();
            //int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            int sl = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i]<100 && clsXulySoNguyen.isNguyenTo(A[i])) sl++;
            }
            Console.WriteLine($"Có {sl} số nguyên tố nhỏ hơn 100 trong mảng");

        }

        public static void Bai127()
        {
            Console.WriteLine("Bài 127: Viết hàm sắp xếp mảng 1 chiều các số thực tăng dần");
            Console.WriteLine("Mảng ban đầu");
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            //int[] A = clsXulyMang.NhapMang();
            A = clsXulyMang.SapXepMangTangdan(A);
            Console.WriteLine("Mảng sau khi sắp xếp");
            clsXulyMang.XuatMang(A);
            Console.WriteLine();
        }

        public static void Bai132()
        {
            static void LietKeSoNguyenChan(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenChan(A[i]) == true)
                    {
                        Console.Write($"{A[i] }");
                    }    
                }    
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 132: Viết hàm liệt kê các giá trị chẵn trong mảng 1 chiều các số nguyên");
            Console.Write($"Ket qua: ");
            LietKeSoNguyenChan(A);
            Console.WriteLine();
        }

        public static void Bai133()
        {
            static void LietKeViTriGiaTriAm(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenAm(A[i]) == true)
                    {
                        Console.Write($"{i} ");
                    }    
                }    
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 133: Viết hàm liệt kê các vị trí mà giá trị tại đó là giá trị âm trong mảng 1 chiều các số thực");
            Console.Write($"Ket qua: ");
            LietKeViTriGiaTriAm(A);
            Console.WriteLine();
        }

        public static void Bai134()
        {
            static double TimSoThucLonNhat(double[] A)
            {
                double max = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > max) max = A[i];
                }
                return max;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 134: Viết hàm tìm giá trị lớn nhất trong mảng 1 chiều các số thực");
            Console.Write($"Ket qua: {TimSoThucLonNhat(A)}");
            Console.WriteLine();
        }

        public static void Bai135()
        {
            static double TimSoThucDuongDauTien(double[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == false)
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 135: Viết hàm tìm giá trị dương đầu tiên trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về -1");
            Console.Write($"Ket qua: {TimSoThucDuongDauTien(A)}");
            Console.WriteLine();
        }

        public static void Bai136()
        {
            static int TimSoNguyenChanCuoiCung(int[] A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (clsXulySoNguyen.isSoNguyenChan(A[i]) == true)
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 136: Tìm số chẵn cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì trả về -1");
            Console.Write($"Ket qua: {TimSoNguyenChanCuoiCung(A)}");
            Console.WriteLine();
        }

        public static void Bai137()
        {
            static int TimViTriSoThucNhoNhat(double[] A)
            {
                int minIndex = 0;
                for (int i = minIndex; i < A.Length; i++)
                {
                    if (A[i] < A[minIndex])
                    {
                        minIndex = i;
                        A[minIndex] = A[i];
                    }
                }
                return minIndex;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 137: Tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số thực");
            Console.Write($"Ket qua: {TimViTriSoThucNhoNhat(A)}");
            Console.WriteLine();
        }

        public static void Bai138()
        {
            static int TimViTriSoNguyenChanDauTien(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenChan(A[i]) == true)
                    {
                        return i;
                    }
                }
                return -1;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 138: Tìm vị trí của giá trị chẵn đầu tiên trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị chẵn thì sẽ trả về -1");
            Console.Write($"Ket qua: {TimViTriSoNguyenChanDauTien(A)}");
            Console.WriteLine();
        }

        public static void Bai139()
        {
            static int TimViTriSoHoanThienCuoiCung(int[] A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (clsXulySoNguyen.isSoHoanThien(A[i]) == true)
                    {
                        return i;
                    }    
                }
                return -1;
            }
            int[] A = {-13,-25,28,6,37};
            clsXulyMang.XuatMang(A);
            Console.WriteLine("*Bài 139: Tìm vị trí số hoàn thiện cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có số hoàn thiện thì trả về giá trị  -1");
            Console.Write($"Ket qua: {TimViTriSoHoanThienCuoiCung(A)}");
            Console.WriteLine();
        }

        public static void Bai140()
        {
            static double DuongNhoNhat(double[] A)
            {
                double linhcanh = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == true)
                    {
                        if (A[i] < linhcanh || linhcanh == -1) linhcanh = A[i];
                    }
                }
                return linhcanh;
            }
            Console.WriteLine("Bài 140: Hãy tìm giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì sẽ trả về -1");
            double[] A = clsXulyMang.NhapMangSoThuc();
            Console.WriteLine($"{DuongNhoNhat(A)}");

        }

        public static void Bai141()
        {
            static double ViTriSoThucDuongNhoNhat(double[] A)
            {
                int minIndex = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == false)
                    {
                        minIndex = i;
                        break;
                    }
                }
                if (minIndex >= 0)
                {
                    for (int i = minIndex + 1; i < A.Length; i++)
                    {
                        if ((clsXuLySoThuc.isSoThucAm(A[i]) == false) && (A[i] < A[minIndex])) minIndex = i;
                    }    
                }
                return minIndex;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 141: Hãy tìm vị trí giá trị dương nhỏ nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị dương thì trả về  -1");
            Console.Write($"Ket qua: {ViTriSoThucDuongNhoNhat(A)}");
            Console.WriteLine();
        }

        public static void Bai142()
        {
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            double kq = clsXulyMang.MinMangSoThuc(A);
            Console.WriteLine("Bài 142: Tìm giá trị nhỏ nhất trong mảng 1 chiều số thực");
            Console.Write($"Ket qua: {kq}");
            Console.WriteLine();
        }

        public static void Bai143()
        {
            static int TimSoNguyenChanDauTien(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenChan(A[i]) == true)
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 143: Viết hàm tìm số chẵn đầu tiên trong mảng các số nguyên. Nếu mảng không có giá trị chẵn thì trả về  -1");
            Console.WriteLine($"Ket qua: {TimSoNguyenChanDauTien(A)}");
            Console.WriteLine();
        }

        public static void Bai144()
        {
            static int TimSoNguyenToDauTien(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isNguyenTo(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return -1;
            }
            int[] A = {-12,0,4,6,13,3};
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 144: Tìm số nguyên tố đầu tiên trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về  – 1");
            Console.WriteLine($"Ket qua: {TimSoNguyenToDauTien(A)}");
            Console.WriteLine();
        }

        public static void Bai145()
        {
            static int TimSoHoanThienDauTien(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoHoanThien(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return -1;
            }
            int[] A = { -12, 0, 4, 6, 13, 3 };
            clsXulyMang.XuatMang(A);
            Console.WriteLine("*Bài 145: Tìm số hoàn thiện đầu tiên trong mảng 1 chiều số nguyên. Nếu mảng không có số hoàn thiện thì trả về  -1");
            Console.WriteLine($"Ket qua: {TimSoHoanThienDauTien(A)}");
            Console.WriteLine();
        }

        public static void Bai146()
        {
            static double TimSoThucAmDauTien(double[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return -1;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 146: Tìm giá trị âm đầu tiên trong mảng 1 chiều các số thực. Nếu mảng không có giá trị âm thì trả về -1");
            Console.WriteLine($"Ket qua: {TimSoThucAmDauTien(A)}");
            Console.WriteLine();
        }

        public static void Bai147()
        {
            static double TimSoThucDuongCuoiCung(double[] A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == false)
                    {
                        return A[i];
                    }
                }
                return -1;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 147: Tìm số dương cuối cùng trong mảng số thực. Nếu mảng không có giá trị dương thì trả về  -1");
            Console.WriteLine($"Ket qua: {TimSoThucDuongCuoiCung(A)}");
            Console.WriteLine();
        }

        public static void Bai148()
        {
            static int TimSoNguyenToCuoiCung(int[] A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (clsXulySoNguyen.isNguyenTo(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return -1;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 148: Tìm số nguyên tố cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về  -1");
            Console.WriteLine($"Ket qua: {TimSoNguyenToCuoiCung(A)}");
            Console.WriteLine();
        }

        public static void Bai149()
        {
            static int TimSoHoanThienCuoiCung(int[] A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if (clsXulySoNguyen.isSoHoanThien(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return -1;
            }
            int[] A = { -13, -25, 28, 6, 37 };
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 149: Tìm số hoàn thiện cuối cùng trong mảng 1 chiều các số nguyên. Nếu mảng không có số hoàn thiện thì trả về  -1");
            Console.WriteLine($"Ket qua: {TimSoHoanThienCuoiCung(A)}");
            Console.WriteLine();
        }

        public static void Bai150()
        {
            static double TimSoThucAmLonNhat(double[] A)
            {
                int maxIndex = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == true)
                    {
                        maxIndex = i;
                        break;
                    }
                }
                if (maxIndex >= 0)
                {
                    for (int i = maxIndex + 1; i < A.Length; i++)
                    {
                        if ((clsXuLySoThuc.isSoThucAm(A[i]) == true) && (A[i] > A[maxIndex]))
                        {
                            A[maxIndex] = A[i];
                        }    
                    }
                    return A[maxIndex];
                }    
                return -1;
            }
            double[] A = {-123.445,-3243.3423,-847,-3448,-9877,-8967 };
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 150: Hãy tìm giá trị âm lớn nhất trong mảng 1 chiều các số thực. Nếu mảng không có giá trị âm thì trả về -1");
            Console.WriteLine($"Ket qua: {TimSoThucAmLonNhat(A)}");
            Console.WriteLine();
        }

        public static void Bai151()
        {
            static double TimNguyenToLonNhat(int[] A)
            {
                int linhcanh = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > linhcanh)
                        if (clsXulySoNguyen.isNguyenTo(A[i]))
                            linhcanh = A[i];
                }
                return linhcanh;
            }
            int[] A = TaoMangNgauNhien();
            //int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 151: Hãy tìm số nguyên tố lớn nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số nguyên tố thì trả về -1");
            Console.WriteLine($"Ket qua: {TimNguyenToLonNhat(A)}");
        }

        public static void Bai152()
        {
            static int TimSoHoanThienNhoNhat(int[] A)
            {
                int min = 0;
                int dem = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoHoanThien(A[i]) == true)
                    {
                        dem++;
                        min = A[i];
                        break;
                    }
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if ((clsXulySoNguyen.isSoHoanThien(A[j]) == true) && (min > A[j]))
                        {
                            min = A[j];
                        }
                    }
                }
                if (dem == 0)
                {
                    return -1;
                }
                return min;
            }
            int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 152: Hãy tìm số hoàn thiện nhỏ nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số hoàn thiện thì trả về -1");
            Console.WriteLine($"Ket qua: {TimSoHoanThienNhoNhat(A)}");
        }

        public static void Bai152b()
        {
            static int TimSoHoanThienNhoNhat2(int[] A)
            {
                int minIndex = -1;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoHoanThien(A[i]) == true)
                    {
                        minIndex = i;
                        break;
                    }
                }
                if (minIndex >= 0)
                {
                    for (int i = minIndex + 1; i < A.Length; i++)
                    {
                        if ((clsXulySoNguyen.isSoHoanThien(A[i]) == true) && (A[i]) < A[minIndex]) minIndex = i;
                    }    
                }    
                return minIndex;
            }
            int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            int kq = TimSoHoanThienNhoNhat2(A);
            Console.WriteLine("Bài 152: Hãy tìm số hoàn thiện nhỏ nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số hoàn thiện thì trả về -1");
            Console.WriteLine($"Ket qua: {A[kq]}");
        }

        public static void Bai153()
        {
            static int TimSoChanNhoNhatSoNguyen(int[] A)
            {
                int min = 0;
                int dem = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenChan(A[i]) == true)
                    {
                        dem++;
                        min = A[i];
                        break;
                    }
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if ((clsXulySoNguyen.isSoNguyenChan(A[j]) == true) && (min > A[j]))
                        {
                            min = A[j];
                        }
                    }
                }
                if (dem == 0) return -1;
                return min;
            }
            int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 153: Hãy tìm giá trị chẵn nhỏ nhất trong mảng 1 chiều các số nguyên. Nếu mảng không có số chẵn thì trả về -1");
            Console.WriteLine($"Ket qua: {TimSoChanNhoNhatSoNguyen(A)}");
        }

        public static void Bai154()
        {
            static double TimSoThucAmNhoNhat(double[] A)
            {
                double min = 0;
                int dem = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXuLySoThuc.isSoThucAm(A[i]) == true)
                    {
                        dem++;
                        min = A[i];
                        break;
                    }    
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if ((clsXuLySoThuc.isSoThucAm(A[i]) == true) && (min > A[j]))
                        {
                            min = A[j];
                        }
                    }    
                }
                if (dem == 0) return -1;
                return min;
            }
            double [] A = clsXulyMang.NhapMangSoThuc();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 154: Hãy tìm vị trí giá trị âm nhỏ nhất trong mảng các số thực. Nếu mảng không có số âm thì trả về -1");
            Console.WriteLine($"Ket qua: {TimSoThucAmNhoNhat(A)}");
        }

        public static void Bai155()
        {
            double[] A = { 21.45, 34.64, -89.45 };
            clsXulyMang.XuatMangSoThuc(A);
            double kq = clsXuLySoThuc.KhoangCachSoThucXaNhat(A,10.4);
            Console.WriteLine("Bài 155: Hãy tìm giá trị trong mảng các số thực xa giá trị x nhất");
            Console.WriteLine($"Ket qua: {kq}");
        }

        public static void Bai156()
        {
            double[] A = {21.45,34.64,-89.45 };
            clsXulyMang.XuatMangSoThuc(A);
            double kq = clsXuLySoThuc.KhoanhCachSoThucGanNhat(A, 10.4);
            Console.WriteLine("Bài 156: Hãy tìm giá trị trong mảng các số thực gần giá trị x nhất");
            Console.WriteLine($"Ket qua: {kq}");
        }

        public static void Bai157()
        {
            double[] A = { 21.45, 34.64, -89.45 };
            clsXulyMang.XuatMangSoThuc(A);
            double max = clsXulyMang.MaxMangSoThuc(A);
            double min = clsXulyMang.MinMangSoThuc(A);
            Console.WriteLine("Bài 155: Hãy tìm giá trị trong mảng các số thực xa giá trị x nhất");
            Console.WriteLine($"Ket qua: [{min},{max}]");
        }

        public static void Bai158()
        {
            static double TimDoanX(double[] A)
            {
                double X = A[0];
                for (int i = 0; i < A.Length; i++)
                {
                    if (X < (Math.Abs(A[i])))
                    {
                        X = Math.Abs(A[i]);
                    }    
                }
                return X;
            }
            double[] A = { 21.45, 34.64, -89.45 };
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 158: Cho mảng 1 chiều các số thực, hãy tìm giá trị x sao cho đoạn [-x, x] chứa tất cả các giá trị trong mảng");
            Console.WriteLine($"Ket qua: [{-TimDoanX(A)},{TimDoanX(A)}]");
        }

        public static void Bai159()
        {
            static double TimGiaTriDauTienLonHon2003(double[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > 2003)
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            double[] A = TaoMangSoThucNgauNhien();
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 159: Cho mảng 1 chiều các số thực, hãy tìm giá trị đầu tiên lớn hơn giá trị 2003. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về  -1");
            Console.WriteLine($"Ket qua: {TimGiaTriDauTienLonHon2003(A)}");
        }

        public static void Bai160()
        {
            static double TimGiaTriAmCuoiCungLonHonAm1(double[] A)
            {
                for (int i = A.Length - 1; i >= 0; i--)
                {
                    if ((clsXuLySoThuc.isSoThucAm(A[i]) == true) && (A[i] > -1))
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            double[] A = {-23,23,-4,-5,-0.9,-0.7 };
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 160: Cho mảng 1 chiều các số thực, hãy tìm giá trị âm cuối cùng lớn hơn giá trị -1. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về -1");
            Console.WriteLine($"Ket qua: {TimGiaTriAmCuoiCungLonHonAm1(A)}");
        }

        public static void Bai161()
        {
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 161: Cho mảng 1 chiều các số nguyên, hãy tìm giá trị đầu tiên nằm trong khoảng [x, y] cho trước. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về -1");
            int kq = clsXulySoNguyen.DauTienTrongDoanSoNguyen(A, -20, 20);
            Console.WriteLine($"Ket qua: {kq}");
        }

        public static void Bai162()
        {
            double[] A = {1,3,13,20,2 };
            clsXulyMang.XuatMangSoThuc(A);
            Console.WriteLine("Bài 162: Cho mảng 1 chiều các số thực. Hãy viết hàm tìm một vị trí trong mảng thỏa 2 điều kiện: có 2 giá trị lân cận và giá trị tại đó bằng tích 2 giá trị lân cận. Nếu mảng không tồn tại giá trị như vậy thì trả về giá trị -1");
            double kq = clsXuLySoThuc.ViTriLanCanThoaDK(A);
            Console.WriteLine($"Ket qua: {kq}");
        }

        public static void Bai163()
        {
            static int TimSoChinhPhuong(int[] A)
            {
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (clsXulySoNguyen.isSoChinhPhuong(A[i]) == true)
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 163: Tìm số chính phương đầu tiên trong mảng 1 chiều các số nguyên");
            Console.WriteLine($"Ket qua: {TimSoChinhPhuong(A)}");
        }

        public static void Bai164()
        {
            static int TimSoGanh(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoGanh(A[i]) == true)
                    {
                        return A[i];
                    }    
                }
                return -1;
            }
            int[] A = {1,6,6776, 4554 };
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 164: Cho mảng 1 chiều các số nguyên. Hãy tìm giá trị đầu tiên thỏa mãn tính chất số gánh");
            Console.WriteLine($"Ket qua: {TimSoGanh(A)}");
        }

        public static void Bai165()
        {
            static int TimSoNguyenCoDauTienLaSoLe(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isChuSoDauTienLe(A[i]) == true)
                    {
                        return A[i];
                    }    
                }
                return 0;
            }
            int[] A = {-3234,23,454,-567};
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 165: Cho mảng 1 chiều các số nguyên. Hãy tìm giá trị đầu tiên có chữ số đầu tiên là chữ số lẻ");
            Console.WriteLine($"Ket qua: {TimSoNguyenCoDauTienLaSoLe(A)}");
        }

        public static void Bai166()
        {
            static int TimSoNguyenCoDang2muK(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenDang2muK(A[i]) == true)
                    {
                        return A[i];
                    }    
                }
                return 0;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 166: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm giá trị đầu tiên trong mảng có dạng 2^k. Nếu mảng không có giá trị dạng 2k thì hàm sẽ trả về 0");
            Console.WriteLine($"Ket qua: {TimSoNguyenCoDang2muK(A)}");
        }

        public static void Bai167()
        {
            static int TimSoNguyenToanChuSoLe(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenToanChuSoLe(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return 0;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 167: Hãy tìm giá trị thỏa điều kiện toàn chữ số lẻ và là giá trị lớn nhất thỏa điều kiện ấy trong mảng 1 chiều các số nguyên. Nếu mảng không có giá trị thỏa điều kiện trên thì trả về 0");
            Console.WriteLine($"Ket qua: {TimSoNguyenToanChuSoLe(A)}");
        }

        public static void Bai168()
        {
            static int TimSoNguyenCoDang5muK(int[] A)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (clsXulySoNguyen.isSoNguyenDang5muK(A[i]) == true)
                    {
                        return A[i];
                    }
                }
                return 0;
            }
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 168: Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm giá trị lớn nhất trong mảng có dạng 5^k. Nếu mảng khong tồn tại giá trị 5^k thì hàm sẽ trả về 0");
            Console.WriteLine($"Ket qua: {TimSoNguyenCoDang5muK(A)}");
        }

        public static void Bai169()
        {
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);
            int max = clsXulyMang.MaxMangSoNguyen(A);
            if (max % 2 == 0)
            {
                max += 2;
            }
            else max += 1;
            Console.WriteLine("Bài 169 (*): Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm số chẵn nhỏ nhất lớn hơn mọi giá trị có trong mảng");
            Console.WriteLine($"Ket qua: {max}");
        }
        public static void Bai170()
        {
            int[] A = TaoMangNgauNhien();
            clsXulyMang.XuatMang(A);

        }

        public static void Bai173()
        {
            static double TimChuSoXuatHienItNhat(int[] A)
            {
                int[] dem = clsXulyMang.DemChuSoNguyen(A);
                int min = clsXulyMang.MaxMangSoNguyen(dem);
                int kq = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (dem[i] != 0 && dem[i] < min)
                    {
                        min = dem[i];
                        kq = i;
                    }    
                }    
                return kq;
            }
            int[] A = clsXulyMang.NhapMang();
            clsXulyMang.XuatMang(A);
            Console.WriteLine("Bài 173 (*): Cho mảng 1 chiều các số nguyên. Hãy viết hàm tìm chữ số xuất hiện ít nhất trong mảng");
            Console.WriteLine($"Ket qua: {TimChuSoXuatHienItNhat(A)}");
        }

    }
}

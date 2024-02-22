using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap_2
{
    internal class Program
    {
        /*
         * Câu 1: Viết hàm không trả về, không truyền vào để nhập xuất thông tin 
         * bao gồm: Tên, tuổi, số đt, địa chỉ.
         * Sau đó in ra thông tin với cú pháp sau:
         * Tôi tên là: ... Tôi sinh năm: ..., Gọi tôi số: ..., tìm tôi tại: ... 
         * trên 1 câu lệnh duy nhất
         */
        static void Bai1()
        {
            Console.WriteLine("Nhập thông tin cá nhân:");
            Console.WriteLine("Mời nhập tên: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Mời nhập tuổi: ");
            int tuoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập SĐT: ");
            int sdt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập địa chỉ: ");
            string diachi = Console.ReadLine();
            Console.WriteLine("Thông tin cá nhân: \n " +
                $"Tên: {ten}\n Tuổi: {tuoi}\n SĐT: {sdt}\n Địa Chỉ: {diachi}");
        }
        /*
         * Viết hàm truyền vào 3 số x, y, z, không trả về. 
         * Thực hiện việc tính và in ra các giá trị sau: 
         * - Trung bình công 3 số x, y, z.
         * - Hiển thị số bé nhất trong 3 số 
         * - Xác định xem có mấy số âm, mấy số dương
         */
        static void Bai2(double x, double y, double z)
        {
            //Console.WriteLine("Mời nhập x: ");
            //x = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Mời nhập y: ");
            //y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Mời nhập z: ");
            //z = Convert.ToDouble(Console.ReadLine());
            double tbc = (x + y + z) / 3;
            Console.WriteLine($"Trung bình cộng của 3 số là: " + tbc);
            double min = Math.Min(Math.Min(x, y), z);
            Console.WriteLine("Số bé nhất trong 3 số là: " + min);
            int duong = 0;
            int am = 0;
            if (x > 0)
            {
                duong++;
            }
            else if (x < 0)
            {
                am++;
            }

            if (y > 0)
            {
                duong++;
            }
            else if (y < 0)
            {
                am++;
            }

            if (z > 0)
            {
                duong++;
            }
            else if (z < 0)
            {
                am++;
            }
            Console.WriteLine("Số dương: " + duong);
            Console.WriteLine("Số âm: " + am);
        }
        /*
         * Viết hàm không truyền vào nhưng cho phép nhập vào 1 mảng số nguyên, 
         * trả về kết quả là trung bình cộng của các số âm trong mảng đó. 
         * Nếu không có số âm, trả về 1
         */
        static int Bai3()
        {
            Console.WriteLine("Nhập phần tử trong mảng: ");
            int x = Convert.ToInt32(Console.ReadLine());

            int[] mang = new int[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Phần tử thứ {i + 1}: ", i + 1);
                mang[i] = Convert.ToInt32(Console.ReadLine());
            }
                int sum = 0;
                int count = 0;
                
                
                    foreach (int num in mang)
                    {
                        if (num < 0)
                        {
                            sum += num;
                            count++;
                        }
                    }

                    if (count == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return (int)sum / count;
                    }
                
        }
        /*
         * Viết hàm truyền vào 1 số, trả về kết quả là 
         * true nếu đó là số nguyên tố, 
         * false nếu đó không là số nguyên tố
         */
        static int Bai4()
        {

            return Bai4();
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            //Bai1();
            //Bai2(-4, -7, -9);
            int TrungBinh = Bai3();
            Console.WriteLine("Trung bình cộng các số âm trong mảng là: " + TrungBinh);
            //Bai4();
        }
    }
}

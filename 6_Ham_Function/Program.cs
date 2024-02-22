using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Ham_Function
{
    internal class Program
    {
        /*
         *  Hàm-Function là 1 tập hợp các câu lệnh đc viêt riêng biệt để 
         *  thực hiện các nhiệm vụ, hành động nào đó.
         *  Hàm đc viết trong class và ngoài hàm main
         *  Hàm có các thành phần sau: 
         *  1. Kiểu trả về (int, string, aray, ...) hoặc void nếu không trả về
         *  2. Tên Hàm viết hoa chữ cái đầu của mỗi từ
         *  3. Tham số truyền vào (Parameter) có thể có hoặc không
         *  3 thành phần này kết hợp thành chữ kí hàm
         *  Khi muốn sử dụng hàm ta thực hiện gọi hàm thông qua tên
         */
        // 1. Hàm không trả về, không tham số

        static void DongThue()
        {
            Console.WriteLine("Nhập mức lương của bạn mỗi tháng");
            long salary = Convert.ToInt64(Console.ReadLine());
            if (salary > 0 && salary <= 5000000)
            {
                Console.WriteLine($"Bạn nộp thuế {salary * 5 / 100}");
            }
            else if (salary > 5000000 && salary <= 10000000)
            {
                Console.WriteLine($"Bạn nộp thuế {salary * 10 / 100}");
            }
            else if (salary > 10000000 && salary <= 30000000)
            {
                Console.WriteLine($"Bạn nộp thuế {salary * 15 / 100}");
            }
            else if (salary > 30000000 && salary <= 80000000)
            {
                Console.WriteLine($"Bạn nộp thuế {salary * 25 / 100}");
            }
            else
            {
                Console.WriteLine($"Bạn quá giàu rồi nên cần gì phải lo thuế");
            }
        }

        // 2. Hàm không trả về, có tham số

        static void TinhToan(int a, int b) // a và b là tham số - parameter
        {
            // Tính a/b và a^b và căn bậc b của a
            //Console.WriteLine("Mời nhập a: ");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Mời nhập b: ");
            //b = Convert.ToInt32(Console.ReadLine());
            if(b == 0)
            {
                Console.WriteLine("Không thể chia cho 0");
            }
            else
            {
                Console.WriteLine($"Thương của {a} và {b} là {a * 1.0 / b}");
            }
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a , b)}");
            Console.WriteLine($"Căn bậc {b} của {a} là {Math.Pow(a, 1.0 / b)}");

        }

        // Hàm trả về không tham số - HÀm trả về khi đc gọi là sẽ đc sử dụng như 1 biến có giá trị

        static string TuThuat()
        {
            Console.WriteLine("Nhập thông tin cá nhân");
            Console.WriteLine("Nhập tên: ");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhập năm sinh: ");
            int namsinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập địa chỉ: ");
            string diachi = Console.ReadLine();
            return $"Thông tin cá nhân: \n" +
                $"Tên: {ten}\n Tuổi: {2024 - namsinh}\n Địa Chỉ: {diachi}";
        }

        // Hàm trả về có tham số 

        static int SumOfArray(int size) // Tính tổng của 1 mảng sau khi nhập từng phần tử
        {
            int[] arr = new int[size]; // Khởi tạo mảng có kích thước cho sẵn là size
            int sum = 0;
            Console.WriteLine("Nhập mảng: ");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            // DongThue();
            // TinhToan(3, 5); // 3 và 5 là đối số - argument
            // Console.WriteLine(TuThuat()); // Khi đc gọi, hàm trả về có vai trò như giá trị
            Console.WriteLine("Tổng các phần tử của mảng là: " + SumOfArray(5));
        }
    }
}

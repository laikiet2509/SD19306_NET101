using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuyenTap
{
    internal class Program
    {
        /*
         * 1: Viết chương trình cho phép nhập liên tục các số, dừng lại khi nhập số thập phân. 
         * Khi dừng vòng lặp, hãy tính và in ra kết quả là tổng của các số đã nhập
         * 2: Xây dựng Menu lặp cho phép hiển thị các lựa chọn
         * a. Nhập
         * b. Xuất
         * c. Tính toán
         * d. Thoát
         * Khi người dùng nhập a hoặc b hoặc c vòng lặp tiếp tục chạy, 
         * khi nhập d thì thoát vòng lặp và nếu nhập khác các yêu cầu trên thì báo: Hãy nhập lại
         * 3. Viết chương trình kiển tra xem 3 số x,y,z được nhập vào có phải 3 cạnh của 1 tam giác không?
         * nếu đúng hay xác định xem đó là loại tam giác gì? Nhọn, vuông hay tù?
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            // b1:
            /*
            double tong = 0;
            while (true)
            {
                Console.WriteLine("Mời nhập số bất kì: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (Math.Floor(a) != a) // có thể dùng (int)a != a
                    {
                         Console.WriteLine(a + "là số thập phân");
                         break;
                    }
            }
            Console.WriteLine("Tổng các số vừa nhập là: " + tong);
            */

            // b2:
            string choice = "";
            do
            {
                Console.WriteLine("Please enter a choose: ");
                Console.WriteLine("a. Input: ");
                Console.WriteLine("b. Output: ");
                Console.WriteLine("c. Caculater: ");
                Console.WriteLine("d. Exit: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine("You've choosen input");
                        break;
                    case "b":
                        Console.WriteLine("You've choosen output");
                        break;
                    case "c":
                        Console.WriteLine("You've choosen caculater");
                        break;
                    case "d":
                        Console.WriteLine("You want to exit, thanks");
                        break;


                    default:
                        Console.WriteLine("Wrong input!!!!!");
                        break;
                }

            } while (true);
        }
    }
}

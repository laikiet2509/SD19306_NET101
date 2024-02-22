using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_VongLap
{
    internal class Program
    {
        /*
         *  Vòng lặp là 1 cấu trúc lệnh cho phép thực thi lặp đi lặp lại
         *  một khối lệnh mà không cần viết lại nhiều lần tuân theo một
         *  điều kiện nào đó
         *  Các loại vòng lặp: for, while, do-while, foreach, 
         */
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            /*for (int i = 0; i < 11; i++)
            {
                Console.Write(i+" ");
            }*/
            // int i = 0;
            //for (; i < 11; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine("Giá trị sau vòng lặp for là: "+i);

            // dùng vòng lặp for để ktra số nguyên tố
            // số nguyên tố là số nguyên dương chỉ có 2 ước là 
            // 1 và chính nó

            /*
            Console.Write("Nhập một số: ");
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = true;// kiểm tra số nguyên tố
            if (number < 2)
            {
                Console.WriteLine($"{number} là số nguyên tố");
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }

            if (IsPrime)
            {
                Console.Write("Số này là số nguyên tố.");
            }
            else
            {
                Console.Write("Số này không phải là số nguyên tố.");
            }

            Console.ReadKey();
            */

            // Sử dụng do while để viết chương trình yêu cầu người dùng nhập số cho đến khi 
            // nhập 1 số chính phương thì dừng lại 

            do 
            {
                Console.WriteLine("Mời nhập số bất kì: ");
                int num = int.Parse(Console.ReadLine());
                int a = (int)Math.Sqrt(num);// Tính nguyên của căn bậc 2 của số vừa nhập
                if (a * a == num)
                {
                    Console.WriteLine($"{num} là số chính phương!!");
                }
            } while (true);
        }
    }
}

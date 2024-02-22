using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Switch_Case
{
    internal class Program
    {
        /*
         * Switch-case là câu lệnh điều kiện cho phép thực thi các câu lệnh
         * theo một điều kiện nào đó mang 1 giá trị cụ thể
         */
        static void Main(string[] args)
        {
            // nhập một số thực a và một số nguyên b
            // sw switch case để thực hiện các câu lệnh sau
            // nếu b = 2, 3 thì chúng ta tính a^b
            // nếu b = 4, 5 thì ta tính căn bậc b của a a= a^(1/b)
            //còn lại thì tính kết quả căn bậc b của a*b
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            
            Console.WriteLine("Moi nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Moi nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            switch(b)
            {
                case 2:
                case 3:
                    Console.WriteLine($"{a}^{b}= {Math.Pow(a, b)}");
                    break;
                case 4:
                case 5:
                    Console.WriteLine($"Căn bậc {b} của {a} là: {Math.Pow(a, 1.0/b)}");
                    break;

                default:
                    Console.WriteLine($"Căn bậc {b} của {a * b} là: {Math.Pow(a*b, 1.0 / b)}");
                    break;
            }
            
            // Khi code xong hãy quen với thao tác: ctrl shift s để lưu lại code
            // 2: ctrl b để build lại project hoặc ctrl shift b để build lại solution

           

        }
    }
}

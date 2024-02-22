using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CauLenhDieuKien
{
    /*
     * Câu lệnh điều kiện là những cú pháp, câu lệnh, cấu trúc mà
     * kq thực thi dựa theo 1 điều kiện nào đó mang giá trị
     * boolean (True/False) 
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int x = 10, y = 20;
            bool a = x == y;
            Console.WriteLine(a);
            if(a)
            {
                Console.WriteLine("x bằng y");
            }else
            {
                Console.WriteLine("x khác y");
            }
            */

            //Khi chunnsg ta sử dụng 1 biến bool trong điều kiện
            //thì không cần so sánh thêm nó với true hay false
            //Sử dụng if else để thực hiện in ra màn hình 
            //học lực của sinh viên dựa theo điểm
            //0-5 tạch 5-6.5 tb 6.5-8 khá 8-10 giỏi
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Nhập điểm của sinh viên: ");
            double diem = Convert.ToDouble(Console.ReadLine());
            if(diem <0 || diem > 10)
            {
                Console.WriteLine("fail");
            }
            if (diem >= 0 && diem <5)
            {
                Console.WriteLine("Tạch");
            }else if (diem > 5 && diem < 6.5)
            {
                Console.WriteLine("TB");
            }else if (diem > 6.5 && diem < 8)
            {
                Console.WriteLine("Khá");
            }else 
            {
                Console.WriteLine("Giỏi");
            }

        }
    }
}

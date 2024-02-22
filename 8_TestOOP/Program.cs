using _8_OOP_4TinhChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_TestOOP
{
    // Muốn dùng đc class ... ở project khác => Add references
    // Chuột phải vào mục dependency/references của project
    // Chọn add project reference => Chọn project nguồn cần add => OK
    internal class Program
    {
        static void Main(string[] args)
        {
            Oto ot = new Oto();
            // Console.WriteLine(ot.ten);
            Console.WriteLine(ot.hangSX);
            // Console.WriteLine(ot.namSX);
            // Console.WriteLine(ot.color);
            // Console.WriteLine(ot.soghe);

        }
    }
}

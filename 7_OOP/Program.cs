using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{
    internal class Program
    {
        /*
         * OOP là gì? Object Orientend Programing - Lập trình hướng đối tượng
         * Là phương pháp lập trình sửu dụng các đối tượng làm trung tâm
         * Mỗi đối tượng sẽ có các thành phần cụ thể là:
         * - Thuộc tính: các giá trị thể hiện các tính chất của đối tượng
         * - Constructor: hàm tạo (sử dụng để khởi tạo đối tượng với các thuộc tính)
         * - Method (Phương thức) thể hiện các hành vi của đối tượng
         * Class (lớp) là khuôn mẫu cho các đối tượng, đối tượng (object) được 
         * gọi là các instance (thể hiện) của các class
         * Một class thường đc tạo trong 1 file vật lí. Tuy nhiên cần phân biệt
         * file .cs và các class. Một fide cs có thể chứa nhiều class
         * Tất cả những thứ gì chứa thông tin, có thể đc lưu thông tin lại và
         * tương tác được => đối tượng
         * OOP có 4 tính chât cơ bản (Đóng gói, kế thừa, tính đa hình, trừu tượng)
         * Đóng gói: thể hiện khả năng truy cập
         * Kế thừa: thể hiện khả năng sử dụng lại các thành phần có sẵn
         * Đa hình: thể hiện sự đa dạng trong việc thể hiện các hành động
         * Trừu tượng: trừu tượng hóa các lớp đối tượng thông qua các thành phần chung
         */
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            // tạo 1 đối tượng
            Dongvat dv; // khai báo - đối tượng sẽ mang giá trị null
            // dv.InThongTin(); // Lỗi vì đối tượng chưa đc khởi tạo
            Dongvat dv2 = new Dongvat(); // Khởi tạo động vật
            dv2.InThongTin();
            // Sử dụng get để lấy giá trị của thuộc tính để get và gán
            // giá trị cho thuộc tính
            Console.WriteLine("Sau khi set giá trị");
            dv2.Ten = "Mèo";
            dv2.Noio = "Rừng";
            dv2.InThongTin();
            Console.WriteLine("Số chân của con vật này là: " + dv2.Sochan);
            // get hay set đều dùng dấu . để tương tác với thuộc tính
            // Dùng constructor có tham số
            Dongvat dv3 = new Dongvat("gà", "3 tháng", "Mái", 2, "Chuồng gà");
            dv3.InThongTin();
            Dongvat dv4 = dv3;
            dv4.InThongTin();
            dv3.Sochan = 10;
            Console.WriteLine("Sau khi thay đổi dv3");
            dv4.InThongTin();
            // Khi gán dv4 = dv3 mà ta thay đổi thông tin của dv3 thì dv4 thay đổi theo
            // class là 1 references type là những kiểu dữ liệu cho phép tham chiếu.
            // Tức là khi ta khai báo dv4 = dv3 thì bản chất chúng ta chỉ tạo ra thêm 
            // 1 biến dv4 kiểu Dongvat nhưng trỏ tới nơi lưu trữ dữ liệu của dv3

        }
    }
}

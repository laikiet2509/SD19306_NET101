using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TinhChat
{
    internal class Program
    {
        /*
         * OOP có 4 tính chất cơ bản bao gồm: 
         * 1. Tính đóng gói (bao đóng): thể hiện khả năng truy cập của các
         * thành phần trong class(field, constructor, method, ...)
         * VD: Phòng học khi đóng cửa (private) thì sinh viên không thể vào được 
         * Cổng Trường luôn mở nên bất kì ai cũng không vào được
         * 2. Tính kế thừa: Thể hiện khả năng tái sử dụng các thành phần đã được
         * tạo ra và kế thừa lại. Trong C# chỉ có thể kế thừa với Class
         * 3. Tính đa hình: Với cùng 1 hành động (thể hiện qua các method) thì với
         * các đối tượng khác nhau hoặc cùng 1 đối tượng nhưng ở các trạng thái 
         * khác nhau sẽ thể hiện ra khác nhau 
         */
        static void Main(string[] args)
        {
            
            //Oto ot = new Oto();
            //Console.WriteLine(ot.ten);
            //Console.WriteLine(ot.hangSX);
            //Console.WriteLine(ot.namSX);
            //Console.WriteLine(ot.color);
            //Console.WriteLine(ot.soghe);
            ChimDaiBang daibang = new ChimDaiBang();
            ChimChoc chimchoc = new ChimChoc();
            // ChimDaiBang daibang2 = new ChimChoc(); // lỗi
            ChimChoc chimchoc2 = new ChimDaiBang();
            // constructor của lớp ChimChoc sẽ có tối đa 3 thuộc tính mà ChimDaiBang
            // có 4 thuộc tính do đó không thế tạo đối tượng daibang bằng constructor mà
            // chỉ khởi tạo 3 thuộc tính hay nói tổng quát, không thể tạo ra đối tượng
            // của lớp con với constructor của lớp cha
            // Điều ngược lại hoàn toàn đc vì constructor của ChimDaiBang có 4 thuộc
            // tính nhưng nó đã bao gồm cả 3 thuộc tính của lớp ChimChoc
            //chimchoc.InThongTin();
            //daibang.InThongTin(); // đại bang đã kế thừa từ chim chóc nên nó dùng được
            //daibang.XuatThongTin(); // cha dùng được của con nhưng con kh dùng đc của cha
            //daibang.Bay();
            //daibang.Bay("Săn Mồi");
            //ChimChoc chimchoc3 = new ChimDaiBang();
            //chimchoc3.VoCanh();
            // Khi đối tượng đc gọi bằng constructor của lớp nào thì phương thức
            // cũng tương tự dùng của lớp đó

            // Đối tượng của lớp abstract nếu muốn tạo ra thì phải là bằng 
            // constructor của lớp con vì class có thể ảo nhưng đối tượng thì không thể
            Ca ca = new CaVoi();
        }
    }
}

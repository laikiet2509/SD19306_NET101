using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TinhChat
{
    internal class ChimDaiBang:ChimChoc
    {
        // Khi kế thừa, thì lớp con sẽ có
        // tất cả các thành phần của lớp cha 
        string ten; // thêm thuộc tình tên

        public string Ten { get => ten; set => ten = value; }

        // ChimDaiBang có 4 thuộc tính bao gồm 3 tt 
        // kế thừa và 1 thuộc tính tên
        public ChimDaiBang()
        {

        }

        public ChimDaiBang(string chungloai, string noio, int soluong, string ten) : base(chungloai, noio, soluong)
        {
            this.ten = ten;
        }
        // Tạo constructor đầy đủ 4 tham số
        // Cách 1: tự gõ / copy
        // Cách 2: Bước 1. Ấn chuột vào tên class 
        //         Bước 2. CTRL . sau đó chọn Generate constructor
        //         chứa các tham số của lớp cha
        // Từ khóa base cho phép trỏ đến thành phần từ lớp cha
        // Bước 3: Bôi đen các thuộc tính mới của lớp con sau đó CTRL . chọn 
        // add parameter to Constructor => Chọn cái mình cần
        // Từ khóa base cho phép trỏ đến thành phần từ lớp cha, base = class cha
        // kế thừa phương thức
        public void XuatThongTin()
        {
            base.InThongTin(); // dùng từ khóa base để gọi phương thức của lớp cha
            // kế thừa phương thức
            Console.WriteLine("Tên là " + ten); 
        }
        // Tính đa hình: là tính chất cho phép các hành động giống nhau được thể hiện khác nhau
        // ở những đối tượng khác nhau hoặc cùng 1 đối tượng nhưng trọng trạng thái khác nhau
        public void Bay()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Bay tà tà chờ thời cơ");
        }
        public void Bay(string trangthai)
        {
            if (trangthai == "Săn mồi") Console.WriteLine("Bay nhanh");
            else if (trangthai == "Thấy súng") Console.WriteLine("Bay mất tích");
            else Console.WriteLine("Lại bay tà tà");

        }
        // Cùng 1 hành động của 1 đối tượng (cùng method) nhưng trạng thái khác
        // nhau (Khác tham số truyền vào) thì thể hiện khác nhau
        // Khi đó người ta gọi là Overload - Nạp chồng
        public override void VoCanh()
        {
            Console.WriteLine("Chim đại bàng không vỗ cánh");

        }
    }
}

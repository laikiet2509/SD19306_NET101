using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_List
{
    internal class Program
    {
        /*
         * List là một loại Generic Collection được sử dụng để hỗ trợ lập 
         * trình viên lưu trữ và quản lí dữ liệu một cách hiệu quả hơn
         * so với mảng, List có thể chứa nhiều kiểu dữ liệu nhưng khi đã 
         * đc khai báo nó chỉ có thể dùng được 1 loại dữ liệu duy nhất
         * cho cả danh sách. VD: List số nguyên, List động vật, ....
         * Kích thước của list là không giới hạn, truy xuất phần tử trong list
         * tương tự như trong array ( mảng ) thông qua chỉ số
         */
        static void Main(string[] args)
        {
            // Cú pháp khai báo
            List<int> list; // không nên chỉ khai báo
            // khởi tạo 
            List<int> listInt = new List<int>();
            List<string> listString = new List<string>();
            // Kí hiệu <x> với x là kiểu dữ liệu chung của cả list
            // Để sử dụng được list ta có các phương thức hỗ trợ
            // Các phương thức thêm
            // Các phương thức xóa
            // Thêm với add và addrange
            listInt.Add(1); listInt.Add(2); listInt.Add(3); listInt.Add(4);
            Console.WriteLine("List int so 1");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            List<int> listInt2 = new List<int>();
            listInt2.Add(5); listInt2.Add(6); listInt2.Add(7); listInt2.Add(8);
            Console.WriteLine("\nList int so 2");
            foreach (var item in listInt2)
            {
                Console.WriteLine(item + " ");
            }
            listInt.AddRange(listInt2); // thêm 1 list vào list khác cùng loại
            Console.WriteLine("\nList int so 1 sau khi them la");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            // thêm với Insert/InsertRange
            listInt.Insert(5, 1000); // thêm vào vị trí 5 giá trị 1000
            Console.WriteLine("\nList int so 1 sau khi insert 1000 la");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            // List không có phương thức để sửa trực tiếp mà cần truy xuất đến phần tử
            // sau đó trực tiếp sửa phần tử đó
            listInt[7] = 777;
            Console.WriteLine("\nList int so 1 sau khi sửa la");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            // xóa với remove/ removeAt/ removeRange/ removeAll
            listInt.Remove(4); // xóa phần tử đầu tiên có giá trị là 4
            Console.WriteLine("\nList int so 1 sau khi xoa phan tu vi tri 4 la");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            listInt.Remove(4); // xóa phần tử đầu tiên có giá trị là 4
            Console.WriteLine("\nList int so 1 sau khi xoa vi tri 4 la");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            listInt.RemoveRange(2, 3); // xóa từ vị trí 2, 3 phần tử
            listInt.Remove(4); // xóa phần tử đầu tiên có giá trị là 4
            Console.WriteLine("\nList int so 1 sau khi xoa phan tu vi tri 2, 3 phan tu la");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            listInt.Insert(2, 4); listInt.Insert(5, 4); listInt.Insert(0, 4);
            Console.WriteLine("\nList khi them 3 phan tu 4");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
            listInt.RemoveAll(p => p == 4); // xóa tất cả phần tử bằng 4
            Console.WriteLine("\nList sau khi xoa het phan tu 4");
            foreach (var item in listInt)
            {
                Console.WriteLine(item + " ");
            }
        }
    }
}

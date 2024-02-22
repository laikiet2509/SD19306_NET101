using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ToanTu
{
    /*
     * toán tử là những kí hiệu để đại diện cho 1 thao tác/phép toán, biểu thức
     * trong lập trình. Toán tử là thành phần không thể thiếu đối với lập trình.
     * các rất nhiêud loại toán tử và cách để phân loại.
     * cách phân loại toán tử theo chức năng: 
     * - Toán tử số học (Thực thi các biểu thức số học như: + - * / %)
     * - Toán tử quan hệ (>, <, >=, <=, !=, ==)
     * - Toán tử logic (&& || ! ^)
     * - Toán tử gán (=; +=; -=; ....)
     * - Toán tử bit (&, !, ^, ~, >>, <<)
     * Phân loại theo ngôi ( Ngôi ở đây là số lượng chủ thể cần có của toán tử)
     * - 1 ngôi: --a, ++a, a--, a++, !a,...
     * - 2 ngôi: + - * / %, gán, so sánh,...
     * - 3 ngôi: điều kiện ? biểu thức nếu đk đúng : biểu thức nếu đk sai
     */
    internal class Program
    {
        // 1. Nhập 2 số nguyên sau đó in ra kết quả của các phép +, -, *, / 
        // chính xác dến chữ số thập phân số 4 ( Math.Round(số cần làm tròn, số chữ số thập phân) )
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Mời nhập số a : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mời nhập số b : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}+{b}={a + b}");
            Console.WriteLine($"{a}-{b}={a - b}");
            Console.WriteLine($"{a}*{b}={a * b}");
            //Console.WriteLine($"{a}/{b}={Convert.ToDouble(a / b)}");
            Console.WriteLine($"{a}/{b}={1.0 * a / b}");
            */

            //Console.WriteLine($"{a}/{b}={(Double) a / b}");
            // double phepchia = 1.0 * a / b;
            //Console.WriteLine($"{a}/{b}={Math.Round(phepchia,4}");
            //Lưu ý: a là số nguyên mà 1.0 là số thực thì kq a*1.0 là số thực
            //dẫn đến kq a*1.0/b là số thực
            //2. Thực hiện các phép gán với a và b vừa nhập
            //Console.WriteLine($"Tăng a lên b đơn vị {a+=b}");
            //3. Thực hiện các phép ++, -- trên a hoặc b
            /*
             * Toán tử 3 ngôi có cấu trúc như sau:
             * Điều kiện ? cú pjasp nếu đk đúng : cú pháp nếu đk sai
             */

            /*
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Moi nhap a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Moi nhap b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kết quả so sánh a và b: "+ (a>=b?"A lớn hơn hoặc bằng B":"B lớn hơn A"));
            // Dùng toán tử 4 ngôi để tính sai khác giữa 2 số: Nếu a >= b thì in ra a-b, ngược lại in ra b-a
            Console.WriteLine(a >= b ? a - b : b -a);
            */

            // Nhập 3 số x, y, z hãy tìm ra số lớn thứ 2 trong 3 số đó
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Moi nhap x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi nhap z: ");
            int z = Convert.ToInt32(Console.ReadLine());
            int max = 0;
            if(x >= y && x <= z || x <= y && x >= z)
            {
                max = x;
                Console.WriteLine($"Số lớn thứ 2 là: {x}");
            }else if(y >= z && y <= x || y <= z && y >= x)
            {
                max = y;
                Console.WriteLine($"Số lớn thứ 2 là : {y}");
            }else
            {
                max = z;
                Console.WriteLine($"Số lớn thứ 2 là : {z}");
            }

            // ý tưởng 2: tìm max và min sau đó lấy tổng 3 số trừ mã và min
            // ý tưởng 3: dựa vào tính chất của số lớn thứ 2:
            // số lớn thứ 2 trừ đi max <=0 và trừ đi min >=0, 2 kq đó khi nhân với nhau <=0
            // max - 2 số còn lại >=0 2 kết quả nhân với nhau >=0
            // min - 2 số còn lại <=0 2 kết quả nhân với nhau >=0
        }
    }
}

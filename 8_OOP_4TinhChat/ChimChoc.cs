using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TinhChat
{

    internal class ChimChoc
    {

        // Thuộc tính
        string chungloai = "Gà bay";
        string noio = "Nồi";
        int soluong= 2;

        public string Chungloai { get => chungloai; set => chungloai = value; }
        public string Noio { get => noio; set => noio = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public ChimChoc()
        {

        }

        public ChimChoc(string chungloai, string noio, int soluong)
        {
            this.chungloai = chungloai;
            this.noio = noio;
            this.soluong = soluong;
        }

        public void InThongTin()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine($"Loài: {chungloai}, Nơi ở: {noio}, Số Lượng: {soluong}");

        }
        public virtual void VoCanh() // từ khóa vỉtual cho phép 1 phương thức có thể được ghi đè
        {
            Console.WriteLine("Vỗ pạch pạch");
            
        }
    }
}

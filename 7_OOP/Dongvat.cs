using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_OOP
{
    internal class Dongvat
    {
        // khai báo các thuộc tính cho đối tượng
        private string ten; // mặc địng là private
        string tuoi;
        string gioitinh;
        int sochan;
        string noio;

        // Property với get và set đc dùng để gán hoặc lấy ra giá trị
        // của thuộc tính nào đó
        // Bôi đen các thuộc tính, sau đó ấn tổ hợp phím ctrl . hoặc
        // click chuột phải chọn Quichk Antion...
        // Sau đó chọn Encasulate Field and Use Property

        public string Ten { get => ten; set => ten = value; }
        public string Tuoi { get => tuoi; set => tuoi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public int Sochan { get => sochan; set => sochan = value; }
        public string Noio { get => noio; set => noio = value; }

        // Constructor (hàm tạo) khởi tạo các đối tượng với các giá trị thuộc tính
        // Constructor không tham số
        // Khởi tạo đối tượng với các giá trị mặc định (có thể đc thiết lập)
        // Tổ hợp phím: CTOR tab tab
        public Dongvat() // Tên Constructor trùng tên class
        {
            ten = "Mew";
            sochan = 4;
            tuoi = "1";
            gioitinh = "Cái";
            noio = "Nhà";
        }

        // Constructor có tham số - khởi tạo đối tượng với thuộc tính mang giá
        // trị của các tham số đc truyền vào
        // Cách tạo:
        // 1. Bôi đen các thuộc tính => Ctrl . => Generate Constructor
        // 2. Click vào vùng trống trên màn hình => Ctrl . => Generate Constructor
        // chọn các thuộc tính mà mình muốn cho vào => OK
        
        // Cách 1: 
        public Dongvat(string ten, string tuoi, string gioitinh, int sochan, string noio)
        {
            this.ten = ten; // this chính là bản thân class
            this.tuoi = tuoi; // this.tuoi và tuoi khác gì nhau 
            this.gioitinh = gioitinh; //this.tuoi là thuộc tính tuoi của class
            this.sochan = sochan; // tuoi là giá trị được truyền vào (param)
            this.noio = noio;
        }

        // Cách 2: 
        public Dongvat(string ten, string tuoi, string gioitinh)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.gioitinh = gioitinh;
        }

        // Các Method (Phương thức) thể hiện các hành vu của đối tượng
        // Method có cấu tạo như function nhưng phải gắn liền với đối tượng
        public void InThongTin()
        {
            Console.WriteLine($"Động vật {ten} có số tuổi là: {tuoi} ");
            Console.WriteLine($"Đang sinh sống tại ''{noio}'' hiện còn: {sochan} chân");
        }
        // Noio viết hoa thực chất sẽ trỏ đến noio viết thường nên bản chát chúng đều là 1
        public void PhanLoai()
        {
            if (sochan == 2) Console.WriteLine("Gia Cầm");
            else if (sochan == 4) Console.WriteLine("Gia Súc");
            else Console.WriteLine("Không xác định");
        }

    }
}
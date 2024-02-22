using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_OOP_4TinhChat
{
    internal class ChimSe : ChimChoc
    {
        // Tạo phương thức ghi đè
        // Cách 1: tự viết
        // Cách 2: Click vào tên class => ctrl . => Generate override => Chọn cái cần và OK
        public override void VoCanh()
        {
            Console.WriteLine("Chim sẻ vỗ cánh liên toành toạch");

        }
    }
}

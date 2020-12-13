using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.ViewModels;

namespace YourTour.Models.ViewModels
{
    public class CommonViewModel
    {
        public int ID { get; set; }
        public string Tentour { get; set; }
        public string Tourcode { get; set; }
        public string Diadiemkhoihanh { get; set; }
        public string Diemden { get; set; }
        public DateTime Ngaydi { get; set; }
        public DateTime Ngayve { get; set; }
        public string Hoten { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Diachi { get; set; }
        public string Hoadoncode { get; set; }
        public DateTime Ngaylaphd { get; set; }
        public int Tongtien { get; set; }
        public string Ptthanhtoan { get; set; }
        public int Songuoidi { get; set; }
        public byte Tinhtrang { get; set; }
    }
}

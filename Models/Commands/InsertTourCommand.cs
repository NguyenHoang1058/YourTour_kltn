using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using YourTour.Models.db;

namespace YourTour.Models.Commands
{
    public class InsertTourCommand
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Tentour { get; set; }
        public string Diadiemkhoihanh { get; set; }
        public ICollection<Diadiemdulich> diadiemduliches { get; set; }
        public string Diemden { get; set; }
        public DateTime Ngaydi { get; set; }
        public DateTime Ngayve { get; set; }
        public int Thoigiandi { get; set; }
        public IFormFile Hinhanh { get; set; }
        public string Lichtrinh { get; set; }
        public int Gianguoilon { get; set; }
        public int Giatreem { get; set; }
        public string Mota { get; set; }
        public string Loaitour { get; set; }
        public string TenHDV { get; set; }
        public int Songuoi { get; set; }
        public string Trangthai { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.ViewModels
{
    public class HoadonViewModel
    {
        public int ID { get; set; }
        public DateTime Ngaylaphd { get; set; }
        public int Tongtien { get; set; }
        public string Ptthanhtoan { get; set; }
        public byte Tinhtrang { get; set; }
        public int KhachhangID { get; set; }
    }
}

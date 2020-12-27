using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.ViewModels
{
    public class ThongKeDTViewModel
    {
        public int ID { get; set; }
        public string TenKH { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }
        public DateTime NgayLapHD { get; set; }
        public decimal DoanhThu { get; set; }
    }
}

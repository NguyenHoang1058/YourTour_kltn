using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;

namespace YourTour.Models.ViewModels
{
    public class DiadiemViewModel
    {
        public int ID { get; set; }
        public string Tendiadiem { get; set; }
        public string Mota { get; set; }
        public int MienID { get; set; }
        //public int TourID { get; set; }
        //public Tinh Tinh { get; set; }
    }
}

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
        public int TinhID { get; set; }
        //public Tinh Tinh { get; set; }
    }
}

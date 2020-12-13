using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.Commands
{
    public class LocationCommand
    {
        public int ID { get; set; }
        public string Tendiadiem { get; set; }
        public string Mota { get; set; }
        public int TinhID { get; set; }
        public string Tentinh { get; set; }
    }
}

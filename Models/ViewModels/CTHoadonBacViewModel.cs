﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.ViewModels
{
    public class CTHoadonBacViewModel
    {
        public int ID { get; set; }
        public string Hotenkhachhang { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Hoadoncode { get; set; }
        public int Songuoidi { get; set; }
        public byte Dahuy { get; set; }
        public int HoadonID { get; set; }
        public int TourID { get; set; }
    }
}

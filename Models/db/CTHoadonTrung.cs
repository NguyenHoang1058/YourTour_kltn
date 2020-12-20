using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class CTHoadonTrung
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Hotenkhachhang { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Hoadoncode { get; set; }
        public int Songuoidi { get; set; }
        public byte Dahuy { get; set; }
        public int HoadonID { get; set; }
        public int TourID { get; set; }
        public Hoadon Hoadon { get; set; }
        public Tour Tour { get; set; }
        public CTHoadonTrung() { }
        public CTHoadonTrung(CTHoadonTrungViewModel cTHoadonTrungViewModel)
        {
            this.ID = cTHoadonTrungViewModel.ID;
            this.Hotenkhachhang = cTHoadonTrungViewModel.Hotenkhachhang;
            this.Sdt = cTHoadonTrungViewModel.Sdt;
            this.Email = cTHoadonTrungViewModel.Email;
            this.Hoadoncode = cTHoadonTrungViewModel.Hoadoncode;
            this.Songuoidi = cTHoadonTrungViewModel.Songuoidi;
            this.Dahuy = cTHoadonTrungViewModel.Dahuy;
            this.HoadonID = cTHoadonTrungViewModel.HoadonID;
            this.TourID = cTHoadonTrungViewModel.TourID;
        }
    }
}

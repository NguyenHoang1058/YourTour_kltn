using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class CTHoadonBac
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Hotenkhachhang { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Hoadoncode { get; set; }
        public int Songuoidi { get; set; }
        public string Ptthanhtoan { get; set; }
        public int HoadonID { get; set; }
        public int TourID { get; set; }
        public Hoadon Hoadon { get; set; }
        public Tour Tour { get; set; }
        public CTHoadonBac() { }
        public CTHoadonBac(CTHoadonBacViewModel cTHoadonBacViewModel)
        {
            this.ID = cTHoadonBacViewModel.ID;
            this.Hotenkhachhang = cTHoadonBacViewModel.Hotenkhachhang;
            this.Sdt = cTHoadonBacViewModel.Sdt;
            this.Email = cTHoadonBacViewModel.Email;
            this.Hoadoncode = cTHoadonBacViewModel.Hoadoncode;
            this.Songuoidi = cTHoadonBacViewModel.Songuoidi;
            this.Ptthanhtoan = cTHoadonBacViewModel.Ptthanhtoan;
            this.HoadonID = cTHoadonBacViewModel.HoadonID;
            this.TourID = cTHoadonBacViewModel.TourID;
        }
    }
}

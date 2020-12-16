using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class CTHoadonNam
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
        public CTHoadonNam() { }
        public CTHoadonNam(CTHoadonViewModel cTHoadonViewModel)
        {
            this.ID = cTHoadonViewModel.ID;
            this.Hotenkhachhang = cTHoadonViewModel.Hotenkhachhang;
            this.Sdt = cTHoadonViewModel.Sdt;
            this.Email = cTHoadonViewModel.Email;
            this.Hoadoncode = cTHoadonViewModel.Hoadoncode;
            this.Songuoidi = cTHoadonViewModel.Songuoidi;
            this.Ptthanhtoan = cTHoadonViewModel.Ptthanhtoan;
            this.HoadonID = cTHoadonViewModel.HoadonID;
            this.TourID = cTHoadonViewModel.TourID;
        }
    }
}

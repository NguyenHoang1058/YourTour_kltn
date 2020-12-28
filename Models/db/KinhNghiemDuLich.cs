using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class KinhNghiemDuLich
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tieude { get; set; }
        public string HinhAnh { get; set; }
        public string Noidung { get; set; }
        public KinhNghiemDuLich() { }
        public KinhNghiemDuLich(KinhNghiemDuLichViewModel kndl)
        {
            this.ID = kndl.ID;
            this.Tieude = kndl.Tieude;
            this.HinhAnh = kndl.Hinhanh;
            this.Noidung = kndl.Noidung;
        }
    }
}

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
        public string HinhAnh1 { get; set; }
        public string Noidung1 { get; set; }
        public string HinhAnh2 { get; set; }
        public string Noidung2 { get; set; }
        public string HinhAnh3 { get; set; }
        public string Noidung3 { get; set; }
        public string HinhAnh4 { get; set; }
        public string Noidung4 { get; set; }
        public string HinhAnh5 { get; set; }
        public string Noidung5 { get; set; }
        public KinhNghiemDuLich() { }
        public KinhNghiemDuLich(KinhNghiemDuLichViewModel kndl)
        {
            this.ID = kndl.ID;
            this.Tieude = kndl.Tieude;
            this.HinhAnh = kndl.Hinhanh;
            this.Noidung = kndl.Noidung;
            this.HinhAnh1 = kndl.Hinhanh1;
            this.Noidung1 = kndl.Noidung1;
            this.HinhAnh2 = kndl.Hinhanh2;
            this.Noidung2 = kndl.Noidung2;
            this.HinhAnh3 = kndl.Hinhanh3;
            this.Noidung3 = kndl.Noidung3;
            this.HinhAnh4 = kndl.Hinhanh4;
            this.Noidung4 = kndl.Noidung4;
            this.HinhAnh5 = kndl.Hinhanh5;
            this.Noidung5 = kndl.Noidung5;
        }
    }
}

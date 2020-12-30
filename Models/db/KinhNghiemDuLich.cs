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
        public string Tieude1 { get; set; }
        public string Noidung1 { get; set; }
        public string Tieude2 { get; set; }
        public string Noidung2 { get; set; }
        public string Tieude3 { get; set; }
        public string Noidung3 { get; set; }
        public string Tieude4 { get; set; }
        public string Noidung4 { get; set; }
        public string Tieude5 { get; set; }
        public string Noidung5 { get; set; }
        public string Tieude6 { get; set; }
        public string Noidung6 { get; set; }
        public KinhNghiemDuLich() { }
        public KinhNghiemDuLich(KinhNghiemDuLichViewModel kndl)
        {
            this.ID = kndl.ID;
            this.Tieude = kndl.Tieude;
            this.HinhAnh = kndl.Hinhanh;
            this.Noidung = kndl.Noidung;
            this.Tieude1 = kndl.Tieude1;
            this.Noidung1 = kndl.Noidung1;
            this.Tieude2 = kndl.Tieude2;
            this.Noidung2 = kndl.Noidung2;
            this.Tieude3 = kndl.Tieude3;
            this.Noidung3 = kndl.Noidung3;
            this.Tieude4 = kndl.Tieude4;
            this.Noidung4 = kndl.Noidung4;
            this.Tieude5 = kndl.Tieude5;
            this.Noidung5 = kndl.Noidung5;
            this.Tieude6 = kndl.Tieude6;
            this.Noidung6 = kndl.Noidung6;

        }
    }
}

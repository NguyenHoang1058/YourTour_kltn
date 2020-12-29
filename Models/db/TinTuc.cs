using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class TinTuc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tieude { get; set; }
        public DateTime NgayDang { get; set; }
        public string Hinhanh { get; set; }
        public string Noidung { get; set; }
        public string Tieude1 { get; set; }
        public string Hinhanh1 { get; set; }
        public string Noidung1 { get; set; }
        public string Tieude2 { get; set; }
        public string Hinhanh2 { get; set; }
        public string Noidung2 { get; set; }
        public string Tieude3 { get; set; }
        public string Hinhanh3 { get; set; }
        public string Noidung3 { get; set; }
        public string Tieude4 { get; set; }
        public string Hinhanh4 { get; set; }
        public string Noidung4 { get; set; }
        public string Tieude5 { get; set; }
        public string Hinhanh5 { get; set; }
        public string Noidung5 { get; set; }
        public TinTuc() { }
        public TinTuc(TinTucViewModel tt)
        {
            this.ID = tt.ID;
            this.Tieude = tt.Tieude;
            this.NgayDang = tt.NgayDang;
            this.Hinhanh = tt.Hinhanh;
            this.Noidung = tt.Noidung;
            this.Tieude1 = tt.Tieude1;
            this.Hinhanh1 = tt.Hinhanh1;
            this.Noidung1 = tt.Noidung1;
            this.Tieude2 = tt.Tieude2;
            this.Hinhanh2 = tt.Hinhanh2;
            this.Noidung2 = tt.Noidung2;
            this.Tieude3 = tt.Tieude3;
            this.Hinhanh3 = tt.Hinhanh3;
            this.Noidung3 = tt.Noidung3;
            this.Tieude4 = tt.Tieude4;
            this.Hinhanh4 = tt.Hinhanh4;
            this.Noidung4 = tt.Noidung4;
            this.Tieude5 = tt.Tieude5;
            this.Hinhanh5 = tt.Hinhanh5;
            this.Noidung5 = tt.Noidung5;
        }
    }
}

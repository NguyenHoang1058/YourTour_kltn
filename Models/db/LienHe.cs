using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class LienHe
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LoaiThongTin { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string TenCongTy { get; set; }
        public int SoKhach { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public byte XacNhan { get; set; }

        public LienHe() { }
        public LienHe(LienHeViewModel lh)
        {
            this.ID = lh.ID;
            this.LoaiThongTin = lh.LoaiThongTin;
            this.HoTen = lh.HoTen;
            this.Email = lh.Email;
            this.Sdt = lh.Sdt;
            this.TenCongTy = lh.TenCongTy;
            this.SoKhach = lh.SoKhach;
            this.TieuDe = lh.TieuDe;
            this.NoiDung = lh.NoiDung;
            this.XacNhan = lh.XacNhan;
        }
    }
}

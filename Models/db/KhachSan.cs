using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class KhachSan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tenks { get; set; }
        public string Hinhanh { get; set; }
        public string Mota { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }
        public string Loaiphong { get; set; }
        public string Thongtinphong { get; set; }
        public int Gia { get; set; }
        public int Giaphuthu { get; set; }
        public int Giatreem { get; set; }
        public int DiaDiemID { get; set; }
        public Diadiemdulich Diadiemdulich { get; set; }

        public KhachSan() { }
        public KhachSan(KhachSanViewModel ks)
        {
            this.ID = ks.ID;
            this.Tenks = ks.Tenks;
            this.Hinhanh = ks.Hinhanh;
            this.Mota = ks.Mota;
            this.Diachi = ks.Diachi;
            this.Gia = ks.Gia;
            this.Giaphuthu = ks.Giaphuthu;
            this.Giatreem = ks.Giatreem;
            this.Sdt = ks.Sdt;
            this.DiaDiemID = ks.DiadiemID;
            this.Thongtinphong = ks.Thongtinphong;
            this.Loaiphong = ks.Loaiphong;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class CTHoadonTuChon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Ngaynhan { get; set; }
        public DateTime Ngaytra { get; set; }
        public int Sophong { get; set; }
        public int Sogiuongthem { get; set; }
        public int Sotreem { get; set; }
        public string Hoten { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Ghichu { get; set; }
        public string Hoadoncode { get; set; }
        public int HoadonID { get; set; }
        public int KhachsanID { get; set; }
        public Hoadon Hoadon { get; set; }
        public KhachSan KhachSan { get; set; }
        public CTHoadonTuChon() { }
        public CTHoadonTuChon(CTHoadonTuChonViewModel cthd)
        {
            this.ID = cthd.ID;
            this.Ngaynhan = cthd.Ngaynhan;
            this.Ngaytra = cthd.Ngaytra;
            this.Sophong = cthd.Sophong;
            this.Sogiuongthem = cthd.Sogiuongthem;
            this.Sotreem = cthd.Sotreem;
            this.Hoten = cthd.Hoten;
            this.Sdt = cthd.Sdt;
            this.Email = cthd.Email;
            this.Ghichu = cthd.Ghichu;
            this.Hoadoncode = cthd.Hoadoncode;
            this.HoadonID = cthd.HoadonID;
            this.KhachsanID = cthd.KhachsanID;
        }
    }
}

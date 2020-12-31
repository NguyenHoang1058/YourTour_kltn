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
        public int Giaphong { get; set; }
        public int Giaphuthu { get; set; }
        public int Giatreem { get; set; }
        public string Hoten { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Ghichu { get; set; }
        public int HoadonID { get; set; }
        public int KhachsanID { get; set; }
        public Hoadon Hoadon { get; set; }
        public KhachSan KhachSan { get; set; }
    }
}

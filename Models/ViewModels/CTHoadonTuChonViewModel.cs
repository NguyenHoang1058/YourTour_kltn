using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class CTHoadonTuChonViewModel
    {
        public int ID { get; set; }
        [DisplayName("Ngày nhận phòng")]
        public DateTime Ngaynhan { get; set; }
        [DisplayName("Ngày trả phòng")]
        public DateTime Ngaytra { get; set; }
        public int Sophong { get; set; }
        public int Sogiuongthem { get; set; }
        public int Sotreem { get; set; }
        [DisplayName("Họ tên")]
        public string Hoten { get; set; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }
        public string Hoadoncode { get; set; }
        public int HoadonID { get; set; }
        public int KhachsanID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YourTour.Models.Validation
{
    public class TourTuChonValidation
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn ngày nhận phòng")]
        public DateTime Ngaynhan { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn ngày trả phòng")]
        public DateTime Ngaytra { get; set; }
        public int Sophong { get; set; }
        public int Sogiuongthem { get; set; }
        public int Sotreem { get; set; }
        public int Tongtien { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập họ tên")]
        public string Hoten { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(0)[0-9]{9}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Sdt { get; set; }
        public string Cmnd { get; set; }
        public string Diachi { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"[a-zA-Z0-9]+\@[a-z]{3,5}\.[a-z]{3}$", ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        public string Ghichu { get; set; }
        public int KhachSanID { get; set; }
    }
}

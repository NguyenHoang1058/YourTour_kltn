using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YourTour.Models.ViewModels
{
    public class LienHeViewModel
    {
        public int ID { get; set; }
        [DisplayName("Loại liên hệ")]
        [Required(ErrorMessage = "Vui lòng chọn loại thông tin")]
        public string LoaiThongTin { get; set; }
        [DisplayName("Họ tên")]
        [Required(ErrorMessage = "Vui lòng nhập tên")]
        [DataType(DataType.Text, ErrorMessage = "Hãy nhập kí tự")]
        public string HoTen { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Vui lòng nhập email")]
        [RegularExpression(@"[a-zA-Z0-9]+\@[a-z]{3,5}\.[a-z]{3}$", ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Vui lòng nhập số điện thoại")]
        [RegularExpression(@"^(0)[0-9]{9}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Sdt { get; set; }
        [DisplayName("Tên công ty")]
        public string TenCongTy { get; set; }
        [DisplayName("Số khách")]
        public int SoKhach { get; set; }
        [DisplayName("Tiêu đề")]
        [Required(ErrorMessage = "Vui lòng nhập tiêu đề")]
        public string TieuDe { get; set; }
        [DisplayName("Nội dung")]
        [Required(ErrorMessage = "Vui lòng nhập nội dung")]
        public string NoiDung { get; set; }
        public byte XacNhan { get; set; }
    }
}

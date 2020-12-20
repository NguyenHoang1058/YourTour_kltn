using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YourTour.Models.ViewModels
{
    public class TourTuyChonViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Hãy cho chúng tôi biết tên của bạn")]
        [DisplayName("Tên")]
        public string TenKH { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được trống")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(09|08|07)[0-9]{8}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Sdt { get; set; }

        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"^[a-zA-Z0-9]+\@[a-z]{3,5}\.[a-z]{3}$", ErrorMessage = "Email không hợp lệ")]
        [DisplayName("Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Hãy chọn miền bạn muốn đi")]
        [DisplayName("Miền")]
        public string Mien { get; set; }
        [Required(ErrorMessage = "Vui lòng cung cấp số người đi")]
        [Range(10,60,ErrorMessage = "Số người phải hơn 10 và không quá 60")]
        [DisplayName("Số người đi")]
        public int Songuoidi { get; set; }
        [DisplayName("Ngày khởi hành")]
        [Required(ErrorMessage = "Vui lòng chọn ngày khởi hành")]
        public DateTime Ngaykhoihanh { get; set; }
        [DisplayName("Ghi chú")]
        public string Ghichu { get; set; }
        [DisplayName("Tình trạng")]
        public byte Xacnhan { get; set; }
    }
}

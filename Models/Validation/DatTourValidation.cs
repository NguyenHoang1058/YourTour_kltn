using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.Validate
{
    public class DatTourValidation
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Tên khách hàng không được để trống")]
        public string Hoten { get; set; }
        [Required(ErrorMessage = "Số cmnd không được để trống")]
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Số chứng minh nhân dân không hợp lệ")]
        public int Cmnd { get; set; }

        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string Diachi { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(0)[0-9]{9}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Sdt { get; set; }
        
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"[a-zA-Z0-9]+\@[a-z]{3,5}\.[a-z]{3}$", ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số người đi không được để trống")]
        [Range(1,9, ErrorMessage = "Số người đi không hợp lệ")]
        public int Songuoidi { get; set; }
        public int Tongtien { get; set; }
        public string Ghichu { get; set; }
        public int TourID { get; set; }
        [Required(ErrorMessage = "Chọn hình thức thanh toán")]
        public string Ptthanhtoan { get; set; }
    }
}

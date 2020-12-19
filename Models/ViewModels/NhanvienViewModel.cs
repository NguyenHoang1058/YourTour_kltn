using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.ViewModels
{
    public class NhanvienViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên nhân viên không được để trống")]
        public string Hoten { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public string Gioitinh { get; set; }
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(09|08|07)[0-9]{8}$", ErrorMessage = "Số điện thoại không hợp lệ")]
        public string Sdt { get; set; }
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"[a-zA-Z0-9]+\@[a-z]{3,5}\.[a-z]{3}$", ErrorMessage = "Email không hợp lệ")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Matkhau { get; set; }
        [DisplayName("Vai trò")]
        [Required(ErrorMessage = "Vai trò không được để trống")]
        public string Vaitro { get; set; }
    }
}

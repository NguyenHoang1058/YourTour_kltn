using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.ViewModels
{
    public class NhanvienViewModel
    {
        public int ID { get; set; }
        [DisplayName("Họ tên")]
        public string Hoten { get; set; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; }
        [DisplayName("Giới tính")]
        public string Gioitinh { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Mật khẩu")]
        public string Matkhau { get; set; }
        [DisplayName("Vai trò")]
        public string Vaitro { get; set; }
    }
}

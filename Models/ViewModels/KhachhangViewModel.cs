using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class KhachhangViewModel
    {
        public int ID { get; set; }
        [DisplayName("Họ tên")]
        public string Hoten { get; set; }
        [DisplayName("Số cmnd")]
        public int Cmnd { get; set; }
        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; }
        public string Email { get; set; }
    }
}

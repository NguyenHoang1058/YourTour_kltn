using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class KinhNghiemDuLichViewModel
    {
        public int ID { get; set; }
        [DisplayName("Tiêu đề")]
        public string Tieude { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung { get; set; }
    }
}

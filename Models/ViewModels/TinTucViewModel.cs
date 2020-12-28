using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class TinTucViewModel
    {
        public int ID { get; set; }
        [DisplayName("Tiêu đề")]
        public string TieuDe { get; set; }
        [DisplayName("Hình ảnh")]
        public string HinhAnh { get; set; }
        [DisplayName("Ngày đăng")]
        public DateTime NgayDang { get; set; }
        [DisplayName("Nội dung")]
        public string NoiDung { get; set; }
    }
}

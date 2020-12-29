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
        public string Tieude { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh { get; set; }
        [DisplayName("Ngày đăng")]
        public DateTime NgayDang { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung { get; set; }
        [DisplayName("Tiêu đề")]
        public string Tieude1 { get; set; }
        public string Hinhanh1 { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung1 { get; set; }
        [DisplayName("Tiêu đề")]
        public string Tieude2 { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh2 { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung2 { get; set; }
        [DisplayName("Tiêu đề")]
        public string Tieude3 { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh3 { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung3 { get; set; }
        [DisplayName("Tiêu đề")]
        public string Tieude4 { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh4 { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung4 { get; set; }
        [DisplayName("Tiêu đề")]
        public string Tieude5 { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh5 { get; set; }
        [DisplayName("Nội dung")]
        public string Noidung5 { get; set; }
    }
}

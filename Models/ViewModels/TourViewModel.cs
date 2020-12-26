using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using YourTour.Models.db;
using YourTour.Models.Validation;

namespace YourTour.Models.ViewModels
{
    public class TourViewModel
    {
        public int ID { get; set; }
        [DisplayName("Mã Tour")]
        public string Code { get; set; }
        [DisplayName("Tên Tour")]
        public string Tentour { get; set; } 
        [DisplayName("Địa điểm khởi hành")]
        public string Diadiemkhoihanh { get; set; }
        [DisplayName("Điểm đến")]
        public string Diemden { get; set; }
        [Required(ErrorMessage = "Ngày khởi hành không được để trống")]
        [Display(Name = "Ngày đi")]
        [CustomDate("Ngày khởi hành phải lớn hơn ngày hiện tại ít nhất 15 ngày")]
        public DateTime Ngaydi { get; set; }
        //[DisplayName("Thời gian trở về")]
        //public DateTime Ngayve { get; set; }
        [DisplayName("Thời gian đi")]
        public int Thoigiandi { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh { get; set; }
        [DisplayName("Chương trình tour")]
        public string Lichtrinh { get; set; }
        [DisplayName("Giá người lớn")]
        public int Gianguoilon { get; set; }
        //[DisplayName("Giá trẻ em")]
        //public int Giatreem { get; set; }
        [DisplayName("Mô tả")]
        public string Mota { get; set; }
        [DisplayName("Loại tour")]
        public string Loaitour { get; set; }
        [DisplayName("Tên hướng dẫn viên")]
        public string TenHDV { get; set; }
        [DisplayName("Số chỗ")]
        public int Songuoi { get; set; }
        [DisplayName("Trạng thái")]
        public string Trangthai { get; set; }
        [DisplayName("Tour nổi bật")]
        public byte Tournoibat { get; set; }
        public int Thuocmien { get; set; }
    }
}

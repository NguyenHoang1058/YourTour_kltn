using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using YourTour.Models.db;

namespace YourTour.Models.Commands
{
    public class InsertTourCommand
    {
        public int ID { get; set; }
        [Display(Name = "Mã tour")]
        public string Code { get; set; }
        [Display(Name = "Tên tour")]
        [Required(ErrorMessage = "Tên tour không được để trống")]
        public string Tentour { get; set; }
        [Display(Name = "Địa điểm khời hành")]
        public string Diadiemkhoihanh { get; set; }
        //public ICollection<Diadiemdulich> diadiemduliches { get; set; }
        [Display(Name = "Điểm đến")]
        public string Diemden { get; set; }
        [Display(Name = "Ngày đi")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-dd-yyyy HH:mm:ss}")]
        //[Required]
        public DateTime Ngaydi { get; set; }
        //public DateTime Ngayve { get; set; }
        [Display(Name = "Số ngày đi")]
        [Range(1,30)]
        [Required(ErrorMessage = "Số ngày đi không được để trống")]
        public int Thoigiandi { get; set; }
        [Display(Name = "Hình ảnh")]
        [Required(ErrorMessage = "Chưa chọn hình ảnh")]
        public IFormFile Hinhanh { get; set; }
        [Display(Name = "Lịch trình")]
        [Required(ErrorMessage = "Chưa chọn lịch trình")]
        public IFormFile Lichtrinh { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Giá tour không được để trống")]
        public int Gianguoilon { get; set; }
        //public int Giatreem { get; set; }
        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Mota { get; set; }
        [Display(Name = "Loại tour")]
        public string Loaitour { get; set; }
        [Display(Name = "Tên hướng dẫn viên")]
        [Required(ErrorMessage = "Tên hướng dẫn viên không được để trống")]
        public string TenHDV { get; set; }
        [Display(Name = "Số chỗ")]
        [Required(ErrorMessage = "Số chỗ không được để trống")]
        public int Songuoi { get; set; }
        [Display(Name = "Trạng thái")]
        public string Trangthai { get; set; }
        [Display(Name = "Thuộc miền")]
        public int Thuocmien { get; set; }
        //public List<int> MultiDiaDiem { get; set; }
    }
}

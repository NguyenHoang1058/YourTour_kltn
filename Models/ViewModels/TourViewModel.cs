using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class TourViewModel
    {
        public int ID { get; set; }
        [DisplayName("Mã Tour")]
        public string Code{ get; set; }
        [DisplayName("Tên Tour")]
        public string Tentour{ get; set; }
        [DisplayName("Địa điểm khởi hành")]
        public string Diadiemkhoihanh{ get; set; }
        [DisplayName("Điểm đến")]
        public string Diemden { get; set; }
        [DisplayName("Thời gian khởi hành")]
        public DateTime Ngaydi { get; set; }
        [DisplayName("Thời gian trở về")]
        public DateTime Ngayve { get; set; }
        [DisplayName("Thời gian")]
        public int Thoigiandi { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh { get; set; }
        [DisplayName("Chương trình tour")]
        public string Lichtrinh { get; set; }
        [DisplayName("Giá người lớn")]
        public int Gianguoilon { get; set; }
        [DisplayName("Giá trẻ em")]
        public int Giatreem { get; set; }
        public string Mota { get; set; }
        public byte Trongnuoc { get; set; }
        public byte Tuychon { get; set; }
        [DisplayName("Số chỗ")]
        public int Songuoi { get; set; }
    }
}

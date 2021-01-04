using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class KhachSanViewModel
    {
        public int ID { get; set; }
        [DisplayName("Tên khách sạn")]
        public string Tenks { get; set; }
        [DisplayName("Hình ảnh")]
        public string Hinhanh { get; set; }
        [DisplayName("Mô tả")]
        public string Mota { get; set; }
        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }
        [DisplayName("Giá")]
        public int Gia { get; set; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; }
        [DisplayName("Tiện nghi phòng")]
        public string Thongtinphong { get; set; }
        public string Loaiphong { get; set; }
        public int Giaphuthu { get; set; }
        public int Giatreem { get; set; }
        public int DiadiemID { get; set; }
    }
}

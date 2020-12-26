using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.ViewModels;
using System.ComponentModel;

namespace YourTour.Models.ViewModels
{
    public class CommonViewModel
    {
        public int ID { get; set; }
        [DisplayName("Tên tour")]
        public string Tentour { get; set; }
        [DisplayName("Mã tour")]
        public string Code { get; set; }
        [DisplayName("Nơi khởi hành")]
        public string Diadiemkhoihanh { get; set; }
        public string Diemden { get; set; }
        [DisplayName("Ngày đi")]
        public DateTime Ngaydi { get; set; }
        [DisplayName("Ngày về")]
        public DateTime Ngayve { get; set; }
        [DisplayName("Họ tên khách hàng")]
        public string Hoten { get; set; }
        [DisplayName("Số điện thoại")]
        public string Sdt { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Địa chỉ")]
        public string Diachi { get; set; }
        [DisplayName("Mã booking")]
        public string Hoadoncode { get; set; }
        [DisplayName("Ngày đặt tour")]
        public DateTime Ngaylaphd { get; set; }
        [DisplayName("Tổng tiền")]
        public int Tongtien { get; set; }
        [DisplayName("Hình thức thanh toán")]
        public string Ptthanhtoan { get; set; }
        [DisplayName("Số người đi")]
        public int Songuoidi { get; set; }
        [DisplayName("Tình trạng")]
        public byte Tinhtrang { get; set; }
        [DisplayName("Miền")]
        public int Thuocmien { get; set; }
    }
}

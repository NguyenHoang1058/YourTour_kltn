﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using YourTour.Models.db;

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
        public ICollection<Diadiemdulich> diadiemduliches { get; set; }
        [DisplayName("Điểm du lịch")]
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
        public string Loaitour { get; set; }
        [DisplayName("Tên hướng dẫn viên")]
        public string TenHDV { get; set; }
        [DisplayName("Số chỗ")]
        public int Songuoi { get; set; }
        public string Trangthai { get; set; }
        [DisplayName("Tour nổi bật")]
        public byte Tournoibat { get; set; }
        public int MienID { get; set; }
        public List<String> MultiDiaDiem { get; set; }
    }
}

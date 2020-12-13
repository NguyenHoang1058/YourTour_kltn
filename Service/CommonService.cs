using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using YourTour.Models;
using YourTour.Models.db;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class CommonService
    {
        private readonly YourTourContext _db;
        public CommonService(YourTourContext db)
        {
            this._db = db;
        }
        public CommonViewModel GetThongTinBooking(string bookingCode)
        {
            var lsResult = from cthd in _db.CTHoadons
                           join t in _db.Tours on cthd.TourID equals t.ID
                           join hd in _db.Hoadons on cthd.HoadonID equals hd.ID
                           join kh in _db.Khachhangs on hd.KhachHangID equals kh.ID
                           where cthd.Hoadoncode == bookingCode
                           select new { t.Tentour, t.Code, t.Diadiemkhoihanh, t.Ngaydi, t.Ngayve, t.Diemden,
                                            cthd.Hotenkhachhang, cthd.Sdt, cthd.Email, cthd.Hoadoncode,
                                            cthd.Songuoidi ,hd.Ngaylaphd, hd.Tongtien, cthd.Ptthanhtoan, 
                                            kh.Diachi, hd.Tinhtrang};
            var common = new CommonViewModel();
            foreach (var item in lsResult)
            {
                common.Tentour = item.Tentour;
                common.Tourcode = item.Code;
                common.Diadiemkhoihanh = item.Diadiemkhoihanh;
                common.Diemden = item.Diemden;
                common.Ngaydi = item.Ngaydi;
                common.Ngayve = item.Ngayve;
                common.Hoadoncode = item.Hoadoncode;
                common.Ptthanhtoan = item.Ptthanhtoan;
                common.Tongtien = item.Tongtien;
                common.Ngaylaphd = item.Ngaylaphd;
                common.Hoten = item.Hotenkhachhang;
                common.Diadiemkhoihanh = item.Diadiemkhoihanh;
                common.Sdt = item.Sdt;
                common.Email = item.Email;
                common.Diachi = item.Diachi;
                common.Songuoidi = item.Songuoidi;
                common.Tinhtrang = item.Tinhtrang;
            }
            return common;
        }
    }
}

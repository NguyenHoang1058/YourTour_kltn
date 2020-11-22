using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.Validate;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class DattourService
    {
        private readonly YourTourContext _db;
        private readonly TourService _tourService;

        public DattourService(YourTourContext db, TourService tourService)
        {
            this._db = db;
            this._tourService = tourService;
        }

        public void DatTour(DatTourValidation validation)
        {
            var kh = _db.Khachhangs.FirstOrDefault(n => n.Cmnd == validation.Cmnd);
            if(kh == null)
            {
                var newKH = new Khachhang(validation);
                _db.Khachhangs.Add(newKH);
                _db.SaveChanges();

                //thêm hóa đơn
                HoadonViewModel hd = new HoadonViewModel();
                hd.KhachhangID = newKH.ID;
                hd.Ngaylaphd = DateTime.Now;
                hd.Tongtien = validation.Tongtien;
                var newHD = new Hoadon(hd);
                _db.Hoadons.Add(newHD);
                _db.SaveChanges();

                // tìm tourID
                var tour = _db.Tours.FirstOrDefault(n => n.ID == validation.TourID);
                tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                _db.SaveChanges();

                //thêm chi tiết hóa đơn
                CTHoadonViewModel cthd = new CTHoadonViewModel();
                cthd.Hotenkhachhang = newKH.Hoten;
                cthd.Sdt = newKH.Sdt;
                cthd.Email = newKH.Email;
                cthd.Songuoidi = validation.Songuoidi;
                cthd.Ptthanhtoan = "Chuyển khoản";
                cthd.HoadonID = newHD.ID;
                cthd.TourID = tour.ID;
                var newCTHD = new CTHoadon(cthd);
                _db.CTHoadons.Add(newCTHD);
                _db.SaveChanges();
            }
            else
            {
                //thêm hóa đơn
                HoadonViewModel hd = new HoadonViewModel();
                hd.KhachhangID = kh.ID;
                hd.Ngaylaphd = DateTime.Now;
                hd.Tongtien = validation.Tongtien;
                var newHD = new Hoadon(hd);
                _db.Hoadons.Add(newHD);
                _db.SaveChanges();

                // tìm tourID
                var tour = _db.Tours.FirstOrDefault(n => n.ID == validation.TourID);
                tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                _db.SaveChanges();
                //thêm chi tiết hóa đơn
                CTHoadonViewModel cthd = new CTHoadonViewModel();
                cthd.Hotenkhachhang = kh.Hoten;
                cthd.Sdt = kh.Sdt;
                cthd.Email = kh.Email;
                cthd.Songuoidi = validation.Songuoidi;
                cthd.Ptthanhtoan = "Chuyển khoản";
                cthd.HoadonID = newHD.ID;
                cthd.TourID = tour.ID;
                var newCTHD = new CTHoadon(cthd);
                _db.CTHoadons.Add(newCTHD);
                _db.SaveChanges();
            }
        }
    }
}

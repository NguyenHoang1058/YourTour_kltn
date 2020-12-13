using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourTour.Helpers;
using YourTour.Models.db;
using YourTour.Models.Validate;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class DattourService
    {
        private readonly YourTourContext _db;
        private readonly TourService _tourService;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DattourService(YourTourContext db, TourService tourService, IHostingEnvironment hostingEnvironment)
        {
            this._db = db;
            this._tourService = tourService;
            this._hostingEnvironment = hostingEnvironment;
        }

        public void DatTour(DatTourValidation validation)
        {
            var tour = _db.Tours.FirstOrDefault(n => n.ID == validation.TourID);
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

                tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                _db.SaveChanges();

                //thêm chi tiết hóa đơn

                CTHoadonViewModel cthd = new CTHoadonViewModel();
                cthd.Hotenkhachhang = newKH.Hoten;
                cthd.Sdt = newKH.Sdt;
                cthd.Email = newKH.Email;
                cthd.Hoadoncode = RandomString();
                cthd.Songuoidi = validation.Songuoidi;
                cthd.Ptthanhtoan = validation.Ptthanhtoan;
                cthd.HoadonID = newHD.ID;
                cthd.TourID = tour.ID;
                var newCTHD = new CTHoadon(cthd);
                _db.CTHoadons.Add(newCTHD);
                _db.SaveChanges();
                
                //send mail

                var webRoot = _hostingEnvironment.WebRootPath;
                var body = string.Empty;
                var pathToFile = _hostingEnvironment.WebRootPath
                    + Path.DirectorySeparatorChar.ToString()
                    + "templates"
                    + Path.DirectorySeparatorChar.ToString()
                    + "email"
                    + Path.DirectorySeparatorChar.ToString()
                    + "bookingdetail.html";
                using (StreamReader reader = new StreamReader(pathToFile))
                {
                    body = reader.ReadToEnd();
                }
                body = body.Replace("{{TourName}}", tour.Tentour);
                body = body.Replace("{{Code}}", tour.Code);
                body = body.Replace("{{Noixuatphat}}", tour.Diadiemkhoihanh);
                body = body.Replace("{{Diemden}}", tour.Diemden);
                body = body.Replace("{{Ngaydi}}", tour.Ngaydi.ToString());
                body = body.Replace("{{Ngayve}}", tour.Ngayve.ToString());
                body = body.Replace("{{Sobooking}}", "0000000001");
                body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                body = body.Replace("{{Hinhthucthanhtoan}}", cthd.Ptthanhtoan);
                //int day = hd.Ngaylaphd.Date + 7;
                body = body.Replace("{{Thoihanthanhtoan}}", "N/A");
                body = body.Replace("{{Hoten}}", validation.Hoten);
                body = body.Replace("{{Diachi}}", validation.Diachi);
                body = body.Replace("{{Sdt}}", validation.Sdt);
                body = body.Replace("{{Email}}", validation.Email);
                body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                var mailHelper = new MailHelpers();
                mailHelper.SendMail(validation.Email, "Thông tin booking", body);
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

                tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                _db.SaveChanges();

                //thêm chi tiết hóa đơn

                CTHoadonViewModel cthd = new CTHoadonViewModel();
                cthd.Hotenkhachhang = kh.Hoten;
                cthd.Sdt = kh.Sdt;
                cthd.Email = kh.Email;
                cthd.Hoadoncode = RandomString();
                cthd.Songuoidi = validation.Songuoidi;
                cthd.Ptthanhtoan = validation.Ptthanhtoan;
                cthd.HoadonID = newHD.ID;
                cthd.TourID = tour.ID;
                var newCTHD = new CTHoadon(cthd);
                _db.CTHoadons.Add(newCTHD);
                _db.SaveChanges();

                //send mail

                var webRoot = _hostingEnvironment.WebRootPath;
                var body = string.Empty;
                var pathToFile = _hostingEnvironment.WebRootPath
                    + Path.DirectorySeparatorChar.ToString()
                    + "templates"
                    + Path.DirectorySeparatorChar.ToString()
                    + "email"
                    + Path.DirectorySeparatorChar.ToString()
                    + "bookingdetail.html";
                using (StreamReader reader = new StreamReader(pathToFile))
                {
                    body = reader.ReadToEnd();
                }
                body = body.Replace("{{TourName}}", tour.Tentour);
                body = body.Replace("{{Code}}", tour.Code);
                body = body.Replace("{{Noixuatphat}}", tour.Diadiemkhoihanh);
                body = body.Replace("{{Diemden}}", tour.Diemden);
                body = body.Replace("{{Ngaydi}}", tour.Ngaydi.ToString());
                body = body.Replace("{{Ngayve}}", tour.Ngayve.ToString());
                body = body.Replace("{{Sobooking}}", "0000000001");
                body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                body = body.Replace("{{Hinhthucthanhtoan}}", cthd.Ptthanhtoan);
                //int day = hd.Ngaylaphd.Date + 7;
                body = body.Replace("{{Thoihanthanhtoan}}", "N/A");
                body = body.Replace("{{Hoten}}", validation.Hoten);
                body = body.Replace("{{Diachi}}", validation.Diachi);
                body = body.Replace("{{Sdt}}", validation.Sdt);
                body = body.Replace("{{Email}}", validation.Email);
                body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                var mailHelper = new MailHelpers();
                mailHelper.SendMail(validation.Email, "Thông tin booking", body);
            }
        }
        private string RandomString()
        {
            var str = new StringBuilder();
            var random = new Random();
            for (int i = 0; i <= 8; i++)
            {
                var c = Convert.ToChar(Convert.ToInt32(random.Next(48, 57)));
                str.Append(c);
            }
            return str.ToString();
        }
    }
}

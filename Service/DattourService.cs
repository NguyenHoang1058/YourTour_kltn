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
        private readonly IHostingEnvironment _hostingEnvironment;

        public DattourService(YourTourContext db, IHostingEnvironment hostingEnvironment)
        {
            this._db = db;
            this._hostingEnvironment = hostingEnvironment;
        }

        public void DatTourMienNam(DatTourValidation validation)
        {
            var tour = _db.Tours.FirstOrDefault(n => n.ID == validation.TourID);
            var kh = _db.Khachhangs.FirstOrDefault(n => n.Cmnd == validation.Cmnd);
                if (kh == null)
                {
                    var newKH = new Khachhang(validation);
                    _db.Khachhangs.Add(newKH);
                    _db.SaveChanges();

                    //thêm thông tin tour miền Nam
                    //thêm hóa đơn

                    HoadonViewModel hd = new HoadonViewModel
                    {
                        KhachhangID = newKH.ID,
                        Ngaylaphd = DateTime.Now,
                        Ptthanhtoan = validation.Ptthanhtoan,
                        Tongtien = validation.Tongtien,
                        Ghichu = validation.Ghichu
                    };
                    var newHD = new Hoadon(hd);
                    _db.Hoadons.Add(newHD);
                    _db.SaveChanges();

                //update số chỗ của tour

                var cho = tour.Songuoi - validation.Songuoidi;
                    if(cho == 0)
                {
                    tour.Trangthai = "hết chỗ";
                    _db.SaveChanges();
                }
                else
                {
                    tour.Songuoi = cho;
                    _db.SaveChanges();
                }

                    //thêm chi tiết hóa đơn

                    CTHoadonNamViewModel cthd = new CTHoadonNamViewModel
                    {
                        Hotenkhachhang = newKH.Hoten,
                        Sdt = newKH.Sdt,
                        Email = newKH.Email,
                        Hoadoncode = RandomString(),
                        Songuoidi = validation.Songuoidi,
                        HoadonID = newHD.ID,
                        TourID = tour.ID
                    };
                    var newCTHD = new CTHoadonNam(cthd);
                    _db.CTHoadonNams.Add(newCTHD);
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
                    body = body.Replace("{{Sobooking}}", cthd.Hoadoncode);
                    body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                    body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                    body = body.Replace("{{Hinhthucthanhtoan}}", hd.Ptthanhtoan);
                    //int day = hd.Ngaylaphd.Date + 7;
                    body = body.Replace("{{Thoihanthanhtoan}}", "Vui lòng thanh toán trước khi tour khởi hành 3 ngày");
                    body = body.Replace("{{Hoten}}", validation.Hoten);
                    body = body.Replace("{{Diachi}}", validation.Diachi);
                    body = body.Replace("{{Sdt}}", validation.Sdt);
                    body = body.Replace("{{Email}}", validation.Email);
                    body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                    var mailHelper = new MailHelpers();
                    mailHelper.SendMail(validation.Email, "Thông tin booking tour", body);
                }
                else
                {

                    //thêm thông tin tour miền Nam
                    //thêm hóa đơn 

                    HoadonViewModel hd = new HoadonViewModel
                    {
                        KhachhangID = kh.ID,
                        Ngaylaphd = DateTime.Now,
                        Ptthanhtoan = validation.Ptthanhtoan,
                        Tongtien = validation.Tongtien,
                        Ghichu = validation.Ghichu
                    };
                    var newHD = new Hoadon(hd);
                    _db.Hoadons.Add(newHD);
                    _db.SaveChanges();

                if (tour.Songuoi > 1)
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    _db.SaveChanges();
                }
                else
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    tour.Trangthai = "hết chỗ";
                    _db.SaveChanges();
                }

                //thêm chi tiết hóa đơn

                CTHoadonNamViewModel cthd = new CTHoadonNamViewModel
                    {
                        Hotenkhachhang = kh.Hoten,
                        Sdt = kh.Sdt,
                        Email = kh.Email,
                        Hoadoncode = RandomString(),
                        Songuoidi = validation.Songuoidi,
                        HoadonID = newHD.ID,
                        TourID = tour.ID
                    };
                    var newCTHD = new CTHoadonNam(cthd);
                    _db.CTHoadonNams.Add(newCTHD);
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
                    body = body.Replace("{{Sobooking}}", cthd.Hoadoncode);
                    body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                    body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                    body = body.Replace("{{Hinhthucthanhtoan}}", hd.Ptthanhtoan);
                    //int day = hd.Ngaylaphd.Date + 7;
                    body = body.Replace("{{Thoihanthanhtoan}}", "Vui lòng thanh toán trước khi tour khởi hành 3 ngày");
                    body = body.Replace("{{Hoten}}", validation.Hoten);
                    body = body.Replace("{{Diachi}}", validation.Diachi);
                    body = body.Replace("{{Sdt}}", validation.Sdt);
                    body = body.Replace("{{Email}}", validation.Email);
                    body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                    var mailHelper = new MailHelpers();
                    mailHelper.SendMail(validation.Email, "Thông tin booking tour", body);
                }
        }
        public void DatTourMienBac(DatTourValidation validation)
        {
            var tour = _db.Tours.FirstOrDefault(n => n.ID == validation.TourID);
            var kh = _db.Khachhangs.FirstOrDefault(n => n.Cmnd == validation.Cmnd);
            if(kh == null)
            {
                var newKH = new Khachhang(validation);
                _db.Khachhangs.Add(newKH);
                _db.SaveChanges();

                //thêm thông tin tour miền Bắc
                //thêm hóa đơn
                HoadonViewModel hd = new HoadonViewModel
                {
                    KhachhangID = newKH.ID,
                    Ngaylaphd = DateTime.Now,
                    Ptthanhtoan = validation.Ptthanhtoan,
                    Tongtien = validation.Tongtien,
                    Ghichu = validation.Ghichu
                };
                var newHD = new Hoadon(hd);
                _db.Hoadons.Add(newHD);
                _db.SaveChanges();

                if (tour.Songuoi > 1)
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    _db.SaveChanges();
                }
                else
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    tour.Trangthai = "hết chỗ";
                    _db.SaveChanges();
                }

                //thêm chi tiết hóa đơn

                CTHoadonBacViewModel cthd = new CTHoadonBacViewModel
                {
                    Hotenkhachhang = newKH.Hoten,
                    Sdt = newKH.Sdt,
                    Email = newKH.Email,
                    Hoadoncode = RandomString(),
                    Songuoidi = validation.Songuoidi,
                    HoadonID = newHD.ID,
                    TourID = tour.ID
                };
                var newCTHD = new CTHoadonBac(cthd);
                _db.CTHoadonBacs.Add(newCTHD);
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
                //body = body.Replace("{{Ngayve}}", tour.Ngayve.ToString());
                body = body.Replace("{{Sobooking}}", cthd.Hoadoncode);
                body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                body = body.Replace("{{Hinhthucthanhtoan}}", hd.Ptthanhtoan);
                //int day = hd.Ngaylaphd.Date + 7;
                body = body.Replace("{{Thoihanthanhtoan}}", "Vui lòng thanh toán trước khi tour khởi hành 3 ngày");
                body = body.Replace("{{Hoten}}", validation.Hoten);
                body = body.Replace("{{Diachi}}", validation.Diachi);
                body = body.Replace("{{Sdt}}", validation.Sdt);
                body = body.Replace("{{Email}}", validation.Email);
                body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                var mailHelper = new MailHelpers();
                mailHelper.SendMail(validation.Email, "Thông tin booking tour", body);
            }
            else
            {
                //thêm thông tin tour miền Bắc
                //thêm hóa đơn 

                HoadonViewModel hd = new HoadonViewModel
                {
                    KhachhangID = kh.ID,
                    Ngaylaphd = DateTime.Now,
                    Ptthanhtoan = validation.Ptthanhtoan,
                    Tongtien = validation.Tongtien,
                    Ghichu = validation.Ghichu
                };
                var newHD = new Hoadon(hd);
                _db.Hoadons.Add(newHD);
                _db.SaveChanges();

                if (tour.Songuoi > 1)
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    _db.SaveChanges();
                }
                else
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    tour.Trangthai = "hết chỗ";
                    _db.SaveChanges();
                }

                //thêm chi tiết hóa đơn

                CTHoadonBacViewModel cthd = new CTHoadonBacViewModel
                {
                    Hotenkhachhang = kh.Hoten,
                    Sdt = kh.Sdt,
                    Email = kh.Email,
                    Hoadoncode = RandomString(),
                    Songuoidi = validation.Songuoidi,
                    HoadonID = newHD.ID,
                    TourID = tour.ID
                };
                var newCTHD = new CTHoadonBac(cthd);
                _db.CTHoadonBacs.Add(newCTHD);
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
                //body = body.Replace("{{Ngayve}}", tour.Ngayve.ToString());
                body = body.Replace("{{Sobooking}}", cthd.Hoadoncode);
                body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                body = body.Replace("{{Hinhthucthanhtoan}}", hd.Ptthanhtoan);
                //int day = hd.Ngaylaphd.Date + 7;
                body = body.Replace("{{Thoihanthanhtoan}}", "Vui lòng thanh toán trước khi tour khởi hành 3 ngày");
                body = body.Replace("{{Hoten}}", validation.Hoten);
                body = body.Replace("{{Diachi}}", validation.Diachi);
                body = body.Replace("{{Sdt}}", validation.Sdt);
                body = body.Replace("{{Email}}", validation.Email);
                body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                var mailHelper = new MailHelpers();
                mailHelper.SendMail(validation.Email, "Thông tin booking tour", body);
            }
        }
        public void DatTourMienTrung(DatTourValidation validation)
        {
            var tour = _db.Tours.FirstOrDefault(n => n.ID == validation.TourID);
            var kh = _db.Khachhangs.FirstOrDefault(n => n.Cmnd == validation.Cmnd);
            if(kh == null)
            {
                var newKH = new Khachhang(validation);
                _db.Khachhangs.Add(newKH);
                _db.SaveChanges();

                //thêm thông tin tour miền Trung
                //thêm hóa đơn

                HoadonViewModel hd = new HoadonViewModel
                {
                    KhachhangID = newKH.ID,
                    Ngaylaphd = DateTime.Now,
                    Ptthanhtoan = validation.Ptthanhtoan,
                    Tongtien = validation.Tongtien,
                    Ghichu = validation.Ghichu
                };
                var newHD = new Hoadon(hd);
                _db.Hoadons.Add(newHD);
                _db.SaveChanges();

                if (tour.Songuoi > 1)
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    _db.SaveChanges();
                }
                else
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    tour.Trangthai = "hết chỗ";
                    _db.SaveChanges();
                }

                //thêm chi tiết hóa đơn

                CTHoadonTrungViewModel cthd = new CTHoadonTrungViewModel
                {
                    Hotenkhachhang = newKH.Hoten,
                    Sdt = newKH.Sdt,
                    Email = newKH.Email,
                    Hoadoncode = RandomString(),
                    Songuoidi = validation.Songuoidi,
                    HoadonID = newHD.ID,
                    TourID = tour.ID
                };
                var newCTHD = new CTHoadonTrung(cthd);
                _db.CTHoadonTrungs.Add(newCTHD);
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
                //body = body.Replace("{{Ngayve}}", tour.Ngayve.ToString());
                body = body.Replace("{{Sobooking}}", cthd.Hoadoncode);
                body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                body = body.Replace("{{Hinhthucthanhtoan}}", hd.Ptthanhtoan);
                body = body.Replace("{{Thoihanthanhtoan}}", "Vui lòng thanh toán trước khi tour khởi hành 3 ngày");
                body = body.Replace("{{Hoten}}", validation.Hoten);
                body = body.Replace("{{Diachi}}", validation.Diachi);
                body = body.Replace("{{Sdt}}", validation.Sdt);
                body = body.Replace("{{Email}}", validation.Email);
                body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                var mailHelper = new MailHelpers();
                mailHelper.SendMail(validation.Email, "Thông tin booking tour", body);
            }
            else
            {
                //thêm thông tin tour miền Trung
                //thêm hóa đơn

                HoadonViewModel hd = new HoadonViewModel
                {
                    KhachhangID = kh.ID,
                    Ngaylaphd = DateTime.Now,
                    Ptthanhtoan = validation.Ptthanhtoan,
                    Tongtien = validation.Tongtien,
                    Ghichu = validation.Ghichu
                };
                var newHD = new Hoadon(hd);
                _db.Hoadons.Add(newHD);
                _db.SaveChanges();

                if (tour.Songuoi > 1)
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    _db.SaveChanges();
                }
                else
                {
                    tour.Songuoi = tour.Songuoi - validation.Songuoidi;
                    tour.Trangthai = "hết chỗ";
                    _db.SaveChanges();
                }

                //thêm chi tiết hóa đơn

                CTHoadonTrungViewModel cthd = new CTHoadonTrungViewModel();
                cthd.Hotenkhachhang = kh.Hoten;
                cthd.Sdt = kh.Sdt;
                cthd.Email = kh.Email;
                cthd.Hoadoncode = RandomString();
                cthd.Songuoidi = validation.Songuoidi;
                cthd.HoadonID = newHD.ID;
                cthd.TourID = tour.ID;
                var newCTHD = new CTHoadonTrung(cthd);
                _db.CTHoadonTrungs.Add(newCTHD);
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
                //body = body.Replace("{{Ngayve}}", tour.Ngayve.ToString());
                body = body.Replace("{{Sobooking}}", cthd.Hoadoncode);
                body = body.Replace("{{Tongtien}}", hd.Tongtien.ToString());
                body = body.Replace("{{Ngaydangky}}", hd.Ngaylaphd.ToString());
                body = body.Replace("{{Hinhthucthanhtoan}}", hd.Ptthanhtoan);
                //int day = hd.Ngaylaphd.Date + 7;
                body = body.Replace("{{Thoihanthanhtoan}}", "N/A");
                body = body.Replace("{{Hoten}}", validation.Hoten);
                body = body.Replace("{{Diachi}}", validation.Diachi);
                body = body.Replace("{{Sdt}}", validation.Sdt);
                body = body.Replace("{{Email}}", validation.Email);
                body = body.Replace("{{Songuoidi}}", validation.Songuoidi.ToString());
                var mailHelper = new MailHelpers();
                mailHelper.SendMail(validation.Email, "Thông tin booking tour", body);
            }
        }
        public void DatTourTuyChon(TourTuyChonViewModel tourTC)
        {
            var newTour = new TourTuyChonViewModel
            {
                TenKH = tourTC.TenKH,
                Email = tourTC.Email,
                Sdt = tourTC.Sdt,
                Mien = tourTC.Mien,
                Songuoidi = tourTC.Songuoidi,
                Ngaykhoihanh = tourTC.Ngaykhoihanh,
                Ghichu = tourTC.Ghichu,
                Xacnhan = 0
            };
            var newTourTuyChon = new TourTuyChon(newTour);
            _db.TourTuyChons.Add(newTourTuyChon);
            _db.SaveChanges();
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

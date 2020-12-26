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

        //lấy tất cả thông tin đặt tour miền Nam theo mã booking
        public CommonViewModel GetThongTinBookingTourMienNam(string bookingCode)
        {
            var lsResult = from cthd in _db.CTHoadonNams
                           join t in _db.Tours on cthd.TourID equals t.ID
                           join hd in _db.Hoadons on cthd.HoadonID equals hd.ID
                           join kh in _db.Khachhangs on hd.KhachHangID equals kh.ID
                           where cthd.Hoadoncode == bookingCode
                           select new { t.Tentour, t.Code, t.Diadiemkhoihanh, t.Ngaydi, /*t.Ngayve,*/ t.Diemden,
                                            cthd.Hotenkhachhang, cthd.Sdt, cthd.Email, cthd.Hoadoncode,
                                            cthd.Songuoidi ,hd.Ngaylaphd, hd.Tongtien, hd.Ptthanhtoan, 
                                            kh.Diachi, hd.Tinhtrang, t.Thuocmien};
            var common = new CommonViewModel();
            foreach (var item in lsResult)
            {
                common.Tentour = item.Tentour;
                common.Code = item.Code;
                common.Diadiemkhoihanh = item.Diadiemkhoihanh;
                common.Diemden = item.Diemden;
                common.Ngaydi = item.Ngaydi;
                //common.Ngayve = item.Ngayve;
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
                common.Thuocmien = item.Thuocmien;
            }
            return common;
        }

        //lấy tất cả thông tin đặt tour miền Trung theo mã booking
        public CommonViewModel GetThongTinBookingTourMienTrung(string bookingCode)
        {
            var lsResult = from cthd in _db.CTHoadonTrungs
                           join t in _db.Tours on cthd.TourID equals t.ID
                           join hd in _db.Hoadons on cthd.HoadonID equals hd.ID
                           join kh in _db.Khachhangs on hd.KhachHangID equals kh.ID
                           where cthd.Hoadoncode == bookingCode
                           select new
                           {
                               t.Tentour,
                               t.Code,
                               t.Diadiemkhoihanh,
                               t.Ngaydi,
                               //t.Ngayve,
                               t.Diemden,
                               cthd.Hotenkhachhang,
                               cthd.Sdt,
                               cthd.Email,
                               cthd.Hoadoncode,
                               cthd.Songuoidi,
                               hd.Ngaylaphd,
                               hd.Tongtien,
                               hd.Ptthanhtoan,
                               kh.Diachi,
                               hd.Tinhtrang,
                               t.Thuocmien
                           };
            var common = new CommonViewModel();
            foreach (var item in lsResult)
            {
                common.Tentour = item.Tentour;
                common.Code = item.Code;
                common.Diadiemkhoihanh = item.Diadiemkhoihanh;
                common.Diemden = item.Diemden;
                common.Ngaydi = item.Ngaydi;
                //common.Ngayve = item.Ngayve;
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
                common.Thuocmien = item.Thuocmien;
            }
            return common;
        }

        //lấy tất cả thông tin đật tour miền Bac theo mã booking
        public CommonViewModel GetThongTinBookingTourMienBac(string bookingCode)
        {
            var lsResult = from cthd in _db.CTHoadonBacs
                           join t in _db.Tours on cthd.TourID equals t.ID
                           join hd in _db.Hoadons on cthd.HoadonID equals hd.ID
                           join kh in _db.Khachhangs on hd.KhachHangID equals kh.ID
                           where cthd.Hoadoncode == bookingCode
                           select new
                           {
                               t.Tentour,
                               t.Code,
                               t.Diadiemkhoihanh,
                               t.Ngaydi,
                               //t.Ngayve,
                               t.Diemden,
                               cthd.Hotenkhachhang,
                               cthd.Sdt,
                               cthd.Email,
                               cthd.Hoadoncode,
                               cthd.Songuoidi,
                               hd.Ngaylaphd,
                               hd.Tongtien,
                               hd.Ptthanhtoan,
                               kh.Diachi,
                               hd.Tinhtrang,
                               t.Thuocmien
                           };
            var common = new CommonViewModel();
            foreach (var item in lsResult)
            {
                common.Tentour = item.Tentour;
                common.Code = item.Code;
                common.Diadiemkhoihanh = item.Diadiemkhoihanh;
                common.Diemden = item.Diemden;
                common.Ngaydi = item.Ngaydi;
                //common.Ngayve = item.Ngayve;
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
                common.Thuocmien = item.Thuocmien;
            }
            return common;
        }

        //
        //admin
        //

        //lấy ds đặt tour miền Nam
        public List<CommonViewModel> GetAllThongTinBookingTourMienNam()
        {
            var lsResult = new List<CommonViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<CommonViewModel>(@"select * from CTHoadonNam join Tour on CTHoadonNam.TourID = Tour.ID
                                                        join Hoadon on CTHoadonNam.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonNam.Dahuy = 0").ToList();
                conn.Close();
            }
            return lsResult;
        }

        //lấy thông tin chi tiết 1 tour đã đặt thuộc miền Nam
        public CommonViewModel GetChiTietThongTinBookingTourMienNam(int id)
        {
            var result = new CommonViewModel();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<CommonViewModel>(@"select * from CTHoadonNam join Tour on CTHoadonNam.TourID = Tour.ID
                                                        join Hoadon on CTHoadonNam.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonNam.ID= " + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }

        // lấy ds tour miền Trung
        public List<CommonViewModel> GetAllThongTinBookingTourMienTrung()
        {
            var dstour = new List<CommonViewModel>();

            using( var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                dstour = conn.Query<CommonViewModel>(@"select * from CTHoadonTrung join Tour on CTHoadonTrung.TourID = Tour.ID
                                                        join Hoadon on CTHoadonTrung.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonTrung.Dahuy = 0").ToList();
                conn.Close();
            }
            return dstour;
        }

        // lấy thông tin chi tiết 1 tour đã đặt thuộc miền Trung
        public CommonViewModel GetChiTietThongTinBookingTourMienTrung(int id)
        {
            var result = new CommonViewModel();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<CommonViewModel>(@"select * from CTHoadonTrung join Tour on CTHoadonTrung.TourID = Tour.ID
                                                        join Hoadon on CTHoadonTrung.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonTrung.ID= " + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }

        // lấy ds tour miền Bắc
        public List<CommonViewModel> GetAllThongTinBookingTourMienBac()
        {
            var dstour = new List<CommonViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                dstour = conn.Query<CommonViewModel>(@"select * from CTHoadonBac join Tour on CTHoadonBac.TourID = Tour.ID
                                                        join Hoadon on CTHoadonBac.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonBac.Dahuy = 0").ToList();
                conn.Close();
            }
            return dstour;
        }

        // lấy thông tin chi tiết 1 tour đã đặt thuộc miền Bắc
        public CommonViewModel GetChiTietThongTinBookingTourMienBac(int id)
        {
            var result = new CommonViewModel();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<CommonViewModel>(@"select * from CTHoadonBac join Tour on CTHoadonBac.TourID = Tour.ID
                                                        join Hoadon on CTHoadonBac.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonBac.ID= " + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models;
using YourTour.Models.ViewModels;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Dapper;
using System.Data;

namespace YourTour.Service
{
    public class HoaDonService 
    {
        private readonly YourTourContext _db;
        public HoaDonService(YourTourContext db)
        {
            this._db = db;
        }

        public HoadonViewModel GetPTThanhToan()
        {
            var pttt = new HoadonViewModel();

            //using Dapper
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                pttt = conn.Query<HoadonViewModel>(@"select top 1 * from HoaDon where Ptthanhtoan = N'Tiền mặt' 
                                                        or Ptthanhtoan = N'Thanh toán online' 
                                                        or Ptthanhtoan = N'Chuyển khoản'
                                                        order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return pttt;
        }
        public Hoadon GetHoaDon()
        {
            var total = new Hoadon();
            
            //using Dapper
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                total = conn.Query<Hoadon>(@"select top 1 * from HoaDon order by ID desc ").FirstOrDefault();
                conn.Close();
            }
            return total;
        }

        //lấy thông tin hóa đơn đặt tour miền Nam
        public CTHoadonNam GetCTHoaDonTourMienNam()
        {
            var cthd = new CTHoadonNam();
            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                cthd = conn.Query<CTHoadonNam>(@"select top 1 * from CTHoadonNam order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return cthd;
        }

        //lấy thông tin hóa đơn đặt tour miền Bắc
        public CTHoadonBac GetCTHoaDonTourMienBac()
        {
            var cthd = new CTHoadonBac();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                cthd = conn.Query<CTHoadonBac>(@"select top 1 * from CTHoadonBac order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return cthd;
        }

        //lấy thông tin hóa đơn đặt tour miền Trung
        public CTHoadonTrung GetCTHoaDonTourMienTrung()
        {
            var cthd = new CTHoadonTrung();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                cthd = conn.Query<CTHoadonTrung>(@"select top 1 * from CTHoadonTrung order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return cthd;
        }

        //hủy tour miền Nam
        public CTHoadonNam HuyBookingTourMienNam(int id)
        {
            var result = new CTHoadonNam();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<CTHoadonNam>(@"select * from CTHoadonNam join Tour on CTHoadonNam.TourID = Tour.ID
                                                        join Hoadon on CTHoadonNam.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonNam.ID= " + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }

        //hủy tour miền Trung
        public CTHoadonTrung HuyBookingTourMienTrung(int id)
        {
            var result = new CTHoadonTrung();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<CTHoadonTrung>(@"select * from CTHoadonTrung join Tour on CTHoadonTrung.TourID = Tour.ID
                                                        join Hoadon on CTHoadonTrung.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonTrung.ID= " + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }

        //hủy tour miền Bắc
        public CTHoadonBac HuyBookingTourMienBac(int id)
        {
            var result = new CTHoadonBac();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<CTHoadonBac>(@"select * from CTHoadonBac join Tour on CTHoadonBac.TourID = Tour.ID
                                                        join Hoadon on CTHoadonBac.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonBac.ID= " + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }
        public Hoadon XacNhanThanhToan(int id)
        {
            var result = new Hoadon();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<Hoadon>(@"select * from Hoadon where ID =" + id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }

        //lấy thông tin hóa đơn tour tự chọn
        public CTHoadonTuChon GetCTHoaDonTourTuChon()
        {
            var cthd = new CTHoadonTuChon();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                cthd = conn.Query<CTHoadonTuChon>(@"select top 1 * from CTHoadonTuChon order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return cthd;
        }
    }
}

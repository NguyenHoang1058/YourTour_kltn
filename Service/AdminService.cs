using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class AdminService
    {
        private readonly YourTourContext _db;
        public AdminService (YourTourContext db)
        {
            this._db = db;
        }

        //lấy danh sách tour đã hủy miền Nam

        public List<CommonViewModel> GetAllTourDaHuyMienNam()
        {
            var lsResult = new List<CommonViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<CommonViewModel>(@"select * from CTHoadonNam join Tour on CTHoadonNam.TourID = Tour.ID
                                                        join Hoadon on CTHoadonNam.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonNam.Dahuy = 1").ToList();
                conn.Close();
            }
            return lsResult;
        }

        //lấy danh sách tour đã hủy miền Bắc
        public List<CommonViewModel> GetAllTourDaHuyMienBac()
        {
            var lsResult = new List<CommonViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<CommonViewModel>(@"select * from CTHoadonBac join Tour on CTHoadonBac.TourID = Tour.ID
                                                        join Hoadon on CTHoadonBac.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonBac.Dahuy = 1").ToList();
                conn.Close();
            }
            return lsResult;
        }
        //lấy danh sách tour đã hủy miền Trung
        public List<CommonViewModel> GetAllTourDaHuyMienTrung()
        {
            var lsResult = new List<CommonViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<CommonViewModel>(@"select * from CTHoadonTrung join Tour on CTHoadonTrung.TourID = Tour.ID
                                                        join Hoadon on CTHoadonTrung.HoadonID = Hoadon.ID
                                                        join KhachHang on Hoadon.KhachhangID = Khachhang.ID
                                                        where CTHoadonTrung.Dahuy = 1").ToList();
                conn.Close();
            }
            return lsResult;
        }
    }
}

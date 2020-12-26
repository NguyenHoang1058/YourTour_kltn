using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;
using Dapper;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace YourTour.Service
{
    public class TourService
    {
        private readonly YourTourContext _db;

        public TourService(YourTourContext db)
        {
            this._db = db;
        }
        public List<TourViewModel> TourTrongNuoc()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select * from Tour where Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> TourMienBac()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select top 6 * from Tour where Thuocmien = 3 and Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> ShowAllTourMienBac()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select * from Tour where Thuocmien = 3 and Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> TourMienTrung()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select top 3 * from Tour where Thuocmien = 2 and Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> ShowAllTourMienTrung()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select * from Tour where Thuocmien = 2 and Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> TourMienNam()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select top 3 * from Tour where Thuocmien = 1 and Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> ShowAllTourMienNam()
        {
            var tourTrongNuoc = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourTrongNuoc = conn.Query<TourViewModel>(@"select * from Tour where Thuocmien = 1 and Trangthai=N'còn chỗ'").ToList();
            }

            return tourTrongNuoc;
        }
        public List<TourViewModel> TourNoiBat()
        {
            var tourNoiBat = new List<TourViewModel>();

            // using Dapper

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tourNoiBat = conn.Query<TourViewModel>(@"select top 4 * from Tour where Loaitour=N'Trong nước' and Tournoibat=1 and Trangthai=N'còn chỗ'").ToList();
                conn.Close();
            }
            return tourNoiBat;
        }
        public TourViewModel ChiTietTourMienNam(int? id)
        {
            var tour = new List<TourViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<TourViewModel>(@"select * from Tour where Thuocmien = 3 and ID = " + id).ToList();
                conn.Close();
            }

            return tour.SingleOrDefault(n => n.ID == id);
        }
        public TourViewModel ChiTietTourMienBac(int? id)
        {
            var tour = new List<TourViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<TourViewModel>(@"select * from Tour where Thuocmien = 1 and ID = " + id).ToList();
                conn.Close();
            }

            return tour.SingleOrDefault(n => n.ID == id);
        }
        public TourViewModel ChiTietTourMienTrung(int? id)
        {
            var tour = new List<TourViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<TourViewModel>(@"select * from Tour where Thuocmien = 2 and ID = " + id).ToList();
                conn.Close();
            }

            return tour.SingleOrDefault(n => n.ID == id);
        }

        public TourTuyChon GetTourTuyChon(int id)
        {
            var tour = new TourTuyChon();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<TourTuyChon>(@"select * from TourTuyChon where ID = " + id).FirstOrDefault();
                conn.Close();
            }
            return tour;
        }
        public List<TourViewModel> TimTour(string diemDen, DateTime ngayDi)
        {
            var result = new List<TourViewModel>();
            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<TourViewModel>(@"select * from Tour")
                                                    .Where(d => d.Diemden.Equals(diemDen) || d.Ngaydi.Equals(ngayDi)).ToList();
                conn.Close();
            }
            return result;
        }
    }
}

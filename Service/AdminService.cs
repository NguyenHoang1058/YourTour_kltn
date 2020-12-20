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
        public List<TourTuyChonViewModel> GetTourTuyChon()
        {
            var tour = new List<TourTuyChonViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<TourTuyChonViewModel>(@"select * from TourTuyChon where Xacnhan = 0").ToList();
                conn.Close();
            }
            return tour;
        }
        public List<TourTuyChonViewModel> GetTourTuyChonDaXacNhan()
        {
            var tour = new List<TourTuyChonViewModel>();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<TourTuyChonViewModel>(@"select * from TourTuyChon where Xacnhan = 1").ToList();
                conn.Close();
            }
            return tour;
        }
    }
}

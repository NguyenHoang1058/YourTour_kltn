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
        private YourTourContext _db;

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
                tourTrongNuoc = conn.Query<TourViewModel>(@"select * from Tour where Trongnuoc=1").ToList();
            }

            return tourTrongNuoc;
        }
    }
}

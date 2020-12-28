using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;
using Dapper;

namespace YourTour.Service
{
    public class TinTucService
    {
        private readonly YourTourContext _db;
        public TinTucService(YourTourContext db)
        {
            this._db = db;
        }
        public List<TinTucViewModel> GetAll()
        {
            var lsResult = new List<TinTucViewModel>();

            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<TinTucViewModel>(@"select * from TinTuc").ToList();
                conn.Close();
            }
            return lsResult;
        }
    }
}

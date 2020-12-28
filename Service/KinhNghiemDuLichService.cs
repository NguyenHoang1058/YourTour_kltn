using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.EntityFrameworkCore;
using YourTour.Models.db;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class KinhNghiemDuLichService
    {
        private readonly YourTourContext _db;
        public KinhNghiemDuLichService(YourTourContext db)
        {
            this._db = db;
        }
        public List<KinhNghiemDuLichViewModel> GetAll()
        {
            var lsResult = new List<KinhNghiemDuLichViewModel>();
            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<KinhNghiemDuLichViewModel>(@"select * from KinhNghiemDuLich").ToList();
                conn.Close();
            }
            return lsResult;
        }
    }
}

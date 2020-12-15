using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace YourTour.Service
{
    public class DiaDiemService
    {
        private readonly YourTourContext _db;
        public DiaDiemService(YourTourContext db)
        {
            this._db = db;
        }
        public List<DiadiemViewModel> Diadiem()
        {
            var diaDiem = new List<DiadiemViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                diaDiem = conn.Query<DiadiemViewModel>(@"select top 4 * from Diadiemdulich").ToList();
            }
            return diaDiem;
        }
    }
}

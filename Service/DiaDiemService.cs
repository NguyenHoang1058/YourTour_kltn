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

        //địa điểm thuộc miền Nam
        public List<DiadiemViewModel> DiadiemMienNam()
        {
            var diaDiem = new List<DiadiemViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                diaDiem = conn.Query<DiadiemViewModel>(@"select top 4 * from Diadiemdulich where MienID = 1").ToList();
            }
            return diaDiem;
        }

        //địa điểm thuộc miền Bắc
        public List<DiadiemViewModel> DiadiemMienBac()
        {
            var diaDiem = new List<DiadiemViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                diaDiem = conn.Query<DiadiemViewModel>(@"select top 4 * from Diadiemdulich where MienID = 3").ToList();
            }
            return diaDiem;
        }

        //địa điểm thuộc miền Trung
        public List<DiadiemViewModel> DiadiemMienTrung()
        {
            var diaDiem = new List<DiadiemViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                diaDiem = conn.Query<DiadiemViewModel>(@"select top 4 * from Diadiemdulich where MienID = 2").ToList();
            }
            return diaDiem;
        }
    }
}

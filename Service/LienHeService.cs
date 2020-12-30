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
    public class LienHeService
    {
        private readonly YourTourContext _db;
        public LienHeService(YourTourContext db)
        {
            this._db = db;
        }
        public void LienHe(LienHeViewModel lh)
        {
            var newLH = new LienHeViewModel
            {
                LoaiThongTin = lh.LoaiThongTin,
                HoTen = lh.HoTen,
                Email = lh.Email,
                Sdt = lh.Sdt,
                TenCongTy = lh.TenCongTy,
                SoKhach = lh.SoKhach,
                TieuDe = lh.TieuDe,
                NoiDung = lh.NoiDung,
                XacNhan = 0

            };
            var newLienHe = new LienHe(newLH);
            _db.LienHes.Add(newLienHe);
            _db.SaveChanges();
        }
        public LienHe GetYeuCauTuVan(int id)
        {
            var tour = new LienHe();
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                tour = conn.Query<LienHe>(@"select * from LienHe where ID = " + id).FirstOrDefault();
                conn.Close();
            }
            return tour;
        }
    }
}

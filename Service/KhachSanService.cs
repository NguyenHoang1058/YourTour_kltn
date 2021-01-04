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
    public class KhachSanService
    {
        private readonly YourTourContext _db;
        public KhachSanService(YourTourContext db)
        {
            this._db = db;
        }

        //lấy ds khách sạn thuộc địa điểm du lịch ở miền Trung
        public List<KhachSanViewModel> KsMienTrung(int id)
        {
            var lsResult = new List<KhachSanViewModel>();
            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                lsResult = conn.Query<KhachSanViewModel>(@"select * from KhachSan where DiadiemID = " + id).ToList();
                conn.Close();
            }
            return lsResult;
        }

        //lấy thông tin chi tiết 1 khách sạn
        public KhachSanViewModel ChiTietKS(int id)
        {
            var result = new KhachSanViewModel();
            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                result = conn.Query<KhachSanViewModel>(@"select * from KhachSan where ID = "+ id).FirstOrDefault();
                conn.Close();
            }
            return result;
        }

        //tìm khách sạn
    }
}

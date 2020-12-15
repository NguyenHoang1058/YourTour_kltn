using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models;
using YourTour.Models.ViewModels;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Dapper;

namespace YourTour.Service
{
    public class HoaDonService 
    {
        private readonly YourTourContext _db;
        public HoaDonService(YourTourContext db)
        {
            this._db = db;
        }

        public CTHoadonViewModel GetPTThanhToan()
        {
            var pttt = new CTHoadonViewModel();

            //using Dapper
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                pttt = conn.Query<CTHoadonViewModel>(@"select top 1 * from CTHoaDon where Ptthanhtoan = N'Tiền mặt' 
                                                        or Ptthanhtoan = N'Thanh toán online' 
                                                        or Ptthanhtoan = N'Chuyển khoản'
                                                        order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return pttt;
        }
        public Hoadon GetTotal()
        {
            var total = new Hoadon();
            
            //using Dapper
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                total = conn.Query<Hoadon>(@"select top 1 * from HoaDon order by ID desc ").FirstOrDefault();
                conn.Close();
            }
            return total;
        }
        public CTHoadon GetHoaDonCode()
        {
            var cthd = new CTHoadon();
            using(var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                cthd = conn.Query<CTHoadon>(@"select top 1 * from CTHoadon order by ID desc").FirstOrDefault();
                conn.Close();
            }
            return cthd;
        }
    }
}

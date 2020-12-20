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
    public class StatisticService
    {
        private readonly YourTourContext _db;
        public StatisticService(YourTourContext db)
        {
            this._db = db;
        }
        public List<DoanhThuNgayViewModel> ThongKeDTNgay(string tuNgay, string denNgay)
        {
            var dtn = new List<DoanhThuNgayViewModel>();
            var parameters = new object[]
            {
                new SqlParameter("@Tungay", tuNgay),
                new SqlParameter("@Denngau", denNgay)
            };
            //using Dapper
            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                dtn = conn.Query<DoanhThuNgayViewModel>(@"select h.Ngaylaphd, SUM(h.Tongtien) as Doanhthu
                                                            from Hoadon h  join CTHoadonBac ct
                                                            on h.ID = ct.HoadonID
                                                            where h.Ngaylaphd >= @Tungay and h.Ngaylaphd <= @Denngay
                                                            group by h.Ngaylaphd").ToList();
                conn.Close();
            }
            return dtn;
        }
    }
}

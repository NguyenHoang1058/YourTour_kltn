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
        public IQueryable<ThongKeDTViewModel> ShowAllDoanhThu()
        {
            var doanhthu = from hd in _db.Hoadons
                           join kh in _db.Khachhangs on
                           hd.KhachHangID equals
                           kh.ID
                        select new { hd.ID, kh.Hoten, hd.Ngaylaphd, hd.Tongtien };

            var tkView = new List<ThongKeDTViewModel>();
            foreach (var item in doanhthu)
            {
                ThongKeDTViewModel tkViewModel = new ThongKeDTViewModel();
                tkViewModel.ID = item.ID;
                tkViewModel.TenKH = item.Hoten;
                tkViewModel.NgayLapHD = item.Ngaylaphd;
                tkViewModel.Thang = item.Ngaylaphd.Month.ToString();
                tkViewModel.Nam = item.Ngaylaphd.Year.ToString();
                tkViewModel.DoanhThu = item.Tongtien;
                tkView.Add(tkViewModel);
            }
            return tkView.AsQueryable();
        }
        //public List<ThongKeDTViewModel> ThongKeDTNgay(string tuNgay, string denNgay)
        //{
        //    var dtn = new List<DoanhThuNgayViewModel>();
        //    var parameters = new object[]
        //    {
        //        new SqlParameter("@Tungay", tuNgay),
        //        new SqlParameter("@Denngau", denNgay)
        //    };
        //    //using Dapper
        //    using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
        //    {
        //        conn.Open();
        //        dtn = conn.Query<DoanhThuNgayViewModel>(@"select h.Ngaylaphd, SUM(h.Tongtien) as Doanhthu
        //                                                    from Hoadon h  join CTHoadonBac ct
        //                                                    on h.ID = ct.HoadonID
        //                                                    where h.Ngaylaphd >= @Tungay and h.Ngaylaphd <= @Denngay
        //                                                    group by h.Ngaylaphd").ToList();
        //        conn.Close();
        //    }
        //    return dtn;
        //}
    }
}

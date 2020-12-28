using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;

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
                LoaiLienHe = lh.LoaiLienHe,
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
    }
}

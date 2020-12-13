using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class ThanhToanController : Controller
    {
        private readonly HoaDonService _hoaDonService;
        private readonly CommonService _commonService;
        public ThanhToanController (HoaDonService hoaDonService, CommonService commonService)
        {
            this._hoaDonService = hoaDonService;
            this._commonService = commonService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ThanhToanTienMat()
        {
            var cthd = this._hoaDonService.GetHoaDonCode();
            var model = this._commonService.GetThongTinBooking(cthd.Hoadoncode);
            return View(model);
        }
        public IActionResult ThanhToanChuyenKhoan()
        {
            var cthd = this._hoaDonService.GetHoaDonCode();
            var model = this._commonService.GetThongTinBooking(cthd.Hoadoncode);
            return View(model);
        }
        public IActionResult ThanhToanOnline()
        {
            var cthd = this._hoaDonService.GetHoaDonCode();
            var model = this._commonService.GetThongTinBooking(cthd.Hoadoncode);
            return View(model);
        }
    }
}

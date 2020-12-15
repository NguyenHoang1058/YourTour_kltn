using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;
using YourTour.Models.Validate;
using Microsoft.AspNetCore.Hosting;
using YourTour.Helpers;
using Microsoft.Extensions.Configuration;

namespace YourTour.Controllers
{
    public class DatTourController : Controller
    {
        private readonly DattourService _dattourService;
        private readonly HoaDonService _hoaDonService;
        private readonly TourService _tourService;
        private readonly CommonService _commonService;
        private readonly IConfiguration _configuration;
        public DatTourController(DattourService dattourService, TourService tourService, 
                                    IConfiguration configuration, HoaDonService hoaDonService,
                                    CommonService commonService)
        {
            this._dattourService = dattourService;
            this._tourService = tourService;
            this._configuration = configuration;
            this._hoaDonService = hoaDonService;
            this._commonService = commonService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BookTour(int? id)
        {
            if (id == null)
            {
                return View("/Views/Shared/Error.cshtml");
            }
            var model = this._tourService.ChiTietTour(id);
            if (model == null)
            {
                return null;
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult DatTour(DatTourValidation validation)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTour(validation);
                return RedirectToAction("ChiTietBooking", "DatTour");
                
            }
            ModelState.Clear();
            var model = _tourService.ChiTietTour(validation.TourID);
            return View("/Views/Tour/ChiTietTour.cshtml", model);
        }
        public IActionResult ChiTietBooking()
        {
            var cthd = this._hoaDonService.GetHoaDonCode();
            var model = this._commonService.GetThongTinBooking(cthd.Hoadoncode);
            return View(model);
        }
        public IActionResult ThanhToan()
        {
            var ptthanhtoan = this._hoaDonService.GetPTThanhToan();
            if (ptthanhtoan.Ptthanhtoan.Equals("Tiền mặt"))
            {
                return RedirectToAction("ThanhToanTienMat", "ThanhToan");
            }
            else if(ptthanhtoan.Ptthanhtoan.Equals("Thanh toán online"))
                    {

                return RedirectToAction("ThanhToanOnline", "ThanhToan");
            }
            else
            {
                return RedirectToAction("ThanhToanChuyenKhoan", "ThanhToan");
            }
        }
    }
}

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
using YourTour.Models.ViewModels;
using Microsoft.AspNetCore.Http;
//using Aspose.Pdf;
//using Aspose.Pdf.Text;
using System.Data;
using System.IO;

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
        public IActionResult DatTourMienNam(int? id)
        {
            var model = this._tourService.ChiTietTourMienNam(id);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }

            return View(model);
        }
        public IActionResult DatTourMienBac(int? id)
        {
            var model = this._tourService.ChiTietTourMienBac(id);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }

            return View(model);
        }
        public IActionResult DatTourMienTrung(int? id)
        {
            var model = this._tourService.ChiTietTourMienTrung(id);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }

            return View(model);
        }
        [HttpPost]
        public IActionResult DatTourMienNam(DatTourValidation validation)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTourMienNam(validation);
                return RedirectToAction("ChiTietBookingTourMienNam", "DatTour");
                
            }
            var model = _tourService.ChiTietTourMienNam(validation.TourID);
            return View(model);
        }
        [HttpPost]
        public IActionResult DatTourMienBac(DatTourValidation validation)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTourMienBac(validation);
                return RedirectToAction("ChiTietBookingTourMienBac", "DatTour");

            }
            var model = _tourService.ChiTietTourMienBac(validation.TourID);
            return View(model);
        }
        [HttpPost]
        public IActionResult DatTourMienTrung(DatTourValidation validation)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTourMienTrung(validation);
                return RedirectToAction("ChiTietBookingTourMienTrung", "DatTour");

            }
            var model = _tourService.ChiTietTourMienTrung(validation.TourID);
            return View(model);
        }
        public IActionResult DatTourTuyChon()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DatTourTuyChon(TourTuyChonViewModel tourTC)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTourTuyChon(tourTC);
                return View("/Views/Home/Index.cshtml");
            }
            return View();
        }

        // lấy chi tiết thông tin đặt tour miền Nam
        public IActionResult ChiTietBookingTourMienNam()
        {
            var cthd = this._hoaDonService.GetCTHoaDonTourMienNam();
            var model = this._commonService.GetThongTinBookingTourMienNam(cthd.Hoadoncode);
            return View(model);
        }

        // lấy thông tin đặt tour miền Bắc
        public IActionResult ChiTietBookingTourMienBac()
        {
            var cthd = this._hoaDonService.GetCTHoaDonTourMienBac();
            var model = this._commonService.GetThongTinBookingTourMienBac(cthd.Hoadoncode);
            return View(model);
        }

        //lấy thông tin đặt tour miền Trung
        public IActionResult ChiTietBookingTourMienTrung()
        {
            var cthd = this._hoaDonService.GetCTHoaDonTourMienTrung();
            var model = this._commonService.GetThongTinBookingTourMienTrung(cthd.Hoadoncode);
            return View(model);
        }

        //export hóa đơn
    }
}

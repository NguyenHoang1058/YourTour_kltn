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
using YourTour.Models.Validation;

namespace YourTour.Controllers
{
    public class DatTourController : Controller
    {
        private readonly DattourService _dattourService;
        private readonly HoaDonService _hoaDonService;
        private readonly TourService _tourService;
        private readonly CommonService _commonService;
        private readonly IConfiguration _configuration;
        private readonly DiaDiemService _diaDiemService;
        private readonly KhachSanService _khachSanService;
        public DatTourController(DattourService dattourService, TourService tourService,
                                    IConfiguration configuration, HoaDonService hoaDonService,
                                    CommonService commonService, DiaDiemService diaDiemService,
                                    KhachSanService khachSanService)
        {
            this._dattourService = dattourService;
            this._tourService = tourService;
            this._configuration = configuration;
            this._hoaDonService = hoaDonService;
            this._commonService = commonService;
            this._diaDiemService = diaDiemService;
            this._khachSanService = khachSanService;
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

        //đặt tour tự chọn
        public IActionResult DatTourTuChon(int id)
        {
            var model = this._khachSanService.ChiTietKS(id);
            if(model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult DatTourTuChon(TourTuChonValidation validation)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTourTuChon(validation);
                return RedirectToAction("ChiTietBookingTourTuChon", "DatTour");
            }
            return View("/Views/Shared/PageNotFound.cshtml");
        }

        //chi tiết booking tour tự chọn
        public IActionResult ChiTietBookingTourTuChon()
        {
            var cthd = this._hoaDonService.GetCTHoaDonTourTuChon();
            var model = this._commonService.GetThongTinBookingTourTuChon(cthd.Hoadoncode);
            return View(model);
        }

    }
}

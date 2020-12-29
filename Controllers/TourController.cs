using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.Commands;
using YourTour.Models.db;
using YourTour.Models.ViewModels;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly TravelService _travelService;
        private readonly YourTourContext _db;

        public TourController(TourService tourService, YourTourContext db, TravelService travelService)
        {
            this._tourService = tourService;
            this._travelService = travelService;
            this._db = db;
        }
        public IActionResult TourTrongNuoc()
        {
            var model = this._tourService.TourTrongNuoc();
            return View(model);
        }
        public IActionResult TourMienNam(int? id)
        {
            if (id == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            var model = this._tourService.ChiTietTourMienNam(id);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult TourMienBac(int? id)
        {
            if (id == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            var model = this._tourService.ChiTietTourMienBac(id);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult TourMienTrung(int? id)
        {
            if (id == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            var model = this._tourService.ChiTietTourMienTrung(id);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult ShowAllTourMienBac()
        {
            var model = this._tourService.ShowAllTourMienBac();
            if(model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult ShowAllTourMienTrung()
        {
            var model = this._tourService.ShowAllTourMienTrung();
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult ShowAllTourMienNam()
        {
            var model = this._tourService.ShowAllTourMienNam();
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult TourNgoaiNuoc()
        {
            return View();
        }
        public IActionResult ChiTietTour(int? id)
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
        [HttpGet]
        public IActionResult XoaTour(int id)
        {
            var model = this._travelService.SeeTour(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult TimTour(string diemDen, DateTime ngayDi)
        {
            var model = this._tourService.TimTour(diemDen, ngayDi);
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
        public IActionResult XoaTour(InsertTourCommand viewModel)
        {
            if (viewModel.ID == null)
            {
                return View("/Views/Shared/Error.cshtml");
            }
            this._tourService.XoaTour(viewModel);
            return RedirectToAction("ShowAllTour", "Admin");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class TourController : Controller
    {
        private readonly TourService _tourService;
        private readonly YourTourContext _db;

        public TourController(TourService tourService, YourTourContext db)
        {
            this._tourService = tourService;
            this._db = db;
        }
        public IActionResult TourTrongNuoc()
        {
            var model = this._tourService.TourTrongNuoc();
            return View(model);
        }
        public IActionResult ThongTinChiTietTour(int? id)
        {
            if(id == null)
            {
                return View("/Views/Shared/Error.cshtml");
            }
            var model = this._tourService.ChiTietTour(id);
            if(model == null)
            {
                return null;
            }
            return View(model);
        }
        public IActionResult TourNgoaiNuoc()
        {
            return View();
        }
    }
}

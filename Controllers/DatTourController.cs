using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;
using YourTour.Models.Validate;

namespace YourTour.Controllers
{
    public class DatTourController : Controller
    {
        private readonly DattourService _dattourService;
        private readonly TourService _tourService;
        public DatTourController(DattourService dattourService, TourService tourService)
        {
            this._dattourService = dattourService;
            this._tourService = tourService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DatTour(DatTourValidation validation)
        {
            if (ModelState.IsValid)
            {
                this._dattourService.DatTour(validation);
                return RedirectToAction("Index", "Home");
            }
            var model = _tourService.ChiTietTour(validation.TourID);
            return View("/Views/Tour/ChiTietTour.cshtml", model);
        }
    }
}

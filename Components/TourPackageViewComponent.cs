using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourTour.Models.db;
using YourTour.Service;

namespace YourTour.Components
{
    public class TourPackageViewComponent : ViewComponent
    {
        private readonly TourService _tourService;
        public TourPackageViewComponent(TourService tourService)
        {
            this._tourService = tourService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._tourService.TourNoiBat();
            return View(model);
        }
    }
}

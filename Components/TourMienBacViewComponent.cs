using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;

namespace YourTour.Components
{
    public class TourMienBacViewComponent : ViewComponent
    {
        private readonly TourService _tourService;
        public TourMienBacViewComponent(TourService tourService)
        {
            this._tourService = tourService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._tourService.TourMienBac();
            return View(model);
        }
    }
}

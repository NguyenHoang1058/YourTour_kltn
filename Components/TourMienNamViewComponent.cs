using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourTour.Service;

namespace YourTour.Components
{
    public class TourMienNamViewComponent : ViewComponent
    {
        private readonly TourService _tourService;
        public TourMienNamViewComponent(TourService tourService)
        {
            this._tourService = tourService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._tourService.TourMienNam();
            return View(model);
        }
    }
}

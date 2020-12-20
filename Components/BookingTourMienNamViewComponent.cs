using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourTour.Service;

namespace YourTour.Components
{
    public class BookingTourMienNamViewComponent : ViewComponent
    {
        private readonly CommonService _commonService;
        public BookingTourMienNamViewComponent(CommonService commonService)
        {
            this._commonService = commonService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._commonService.GetAllThongTinBookingTourMienNam();
            return View(model);
        }
    }
}

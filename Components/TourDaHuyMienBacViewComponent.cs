using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourTour.Service;

namespace YourTour.Components
{
    public class TourDaHuyMienBacViewComponent : ViewComponent
    {
        private readonly AdminService _adminService;
        public TourDaHuyMienBacViewComponent(AdminService adminService)
        {
            this._adminService = adminService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._adminService.GetAllTourDaHuyMienBac();
            return View(model);
        }
    }
}

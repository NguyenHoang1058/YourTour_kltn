using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YourTour.Service;

namespace YourTour.Components
{
    public class TourDaHuyMienTrungViewComponent : ViewComponent
    {
        private readonly AdminService _adminService;
        public TourDaHuyMienTrungViewComponent(AdminService adminService)
        {
            this._adminService = adminService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._adminService.GetAllTourDaHuyMienTrung();
            return View(model);
        }
    }
}

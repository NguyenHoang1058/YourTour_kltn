using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;

namespace YourTour.Components
{
    public class DiaDiemMienTrungViewComponent : ViewComponent
    {
        private readonly DiaDiemService _diaDiemService;
        public DiaDiemMienTrungViewComponent(DiaDiemService diaDiemService)
        {
            this._diaDiemService = diaDiemService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = this._diaDiemService.DiadiemMienTrung();
            if(model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;

namespace YourTour.Components
{
    public class DiaDiemMienNamViewComponent : ViewComponent
    {
        private readonly DiaDiemService _diaDiemService;
        public DiaDiemMienNamViewComponent(DiaDiemService diaDiemService)
        {
            this._diaDiemService = diaDiemService;
        }
        public IViewComponentResult Invoke()
        {
            var model = this._diaDiemService.DiadiemMienNam();
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
    }
}

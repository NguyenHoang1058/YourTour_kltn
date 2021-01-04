using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class KhachSanController : Controller
    {
        private readonly KhachSanService _khachSanService;
        public KhachSanController(KhachSanService khachSanService)
        {
            this._khachSanService = khachSanService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DiemDen()
        {
            return View();
        }
        public IActionResult KhachSanThuocDiaDiem(int id)
        {
            var model = this._khachSanService.KsMienTrung(id);
            if(model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            return View(model);
        }
    }
}

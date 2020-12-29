using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using X.PagedList;
using YourTour.Models;
using YourTour.Models.db;
using YourTour.Service;
using YourTour.Models.ViewModels;

namespace YourTour.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly KinhNghiemDuLichService _kinhNghiemDuLichService;
        private readonly LienHeService _lienHeService;
        private readonly TinTucService _tinTucService;

        public HomeController(ILogger<HomeController> logger, KinhNghiemDuLichService kinhNghiemDuLichService,
            LienHeService lienHeService, TinTucService tinTucService)
        {
            _logger = logger;
            this._kinhNghiemDuLichService = kinhNghiemDuLichService;
            this._lienHeService = lienHeService;
            this._tinTucService = tinTucService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("/Views/Shared/PageNotFound.cshtml");
        }
        public IActionResult KinhNghiemDuLich(int? page)
        {
            if (page == null) page = 1;
            var model = this._kinhNghiemDuLichService.GetAll();
            if(model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            model.OrderByDescending(x => x.ID);
            int pagesize = 3;
            int pagenumber = (page ?? 1);
            return View(model.ToPagedList(pagenumber, pagesize));
        }
        public IActionResult TinTuc(int? page)
        {
            if (page == null) page = 1;
            var model = this._tinTucService.GetAll();
            if (model == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            model.OrderByDescending(x => x.ID);
            int pagesize = 3;
            int pagenumber = (page ?? 1);
            return View(model.ToPagedList(pagenumber, pagesize));
        }
        public IActionResult LienHe()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LienHe(LienHeViewModel lh)
        {
            if (ModelState.IsValid)
            {
                this._lienHeService.LienHe(lh);
                return View("/Views/Home/GuiThanhCong.cshtml");
            }
            return View();
        }
        public IActionResult GetDetail(int id)
        {
            if (id == null)
            {
                return View("/Views/Shared/PageNotFound.cshtml");
            }
            var model = this._tinTucService.GetDetail(id);
            if (model == null)
            {
                return null;
            }

            return View(model);
        }
    }
}

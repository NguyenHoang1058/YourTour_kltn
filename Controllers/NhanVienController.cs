using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class NhanVienController : Controller
    {
        private readonly StaffService _staffService;
        private readonly YourTourContext _db;

        public NhanVienController(StaffService staffService, YourTourContext db)
        {
            this._staffService = staffService;
            this._db = db;
        }
        public IActionResult ChiTietNhanvien(int? id)
        {
            if (id == null)
            {
                return View("/Views/Shared/Error.cshtml");
            }
            var model = this._staffService.ChiTietNhanVien(id);
            if (model == null)
            {
                return null;
            }

            return View(model);
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;

namespace YourTour.Controllers
{
    public class AdminController : Controller
    {
        private readonly YourTourContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AdminController(YourTourContext db, IHostingEnvironment hostingEnvironment)
        {
            this._db = db;
            this._hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            if(HttpContext.Session.GetString("Admin") == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                HttpContext.Session.Remove("Admin");
                return View();
            }
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            string strEmail = form["email"].ToString();
            string strPassword = form["password"].ToString();
            var check = _db.Taikhoans.FirstOrDefault(n => n.Email.Equals(strEmail) && n.Matkhau.Equals(strPassword));
            if (check != null && check.Vaitro.Equals("admin"))
            {
                HttpContext.Session.SetString("Admin", strEmail);
                return RedirectToAction("Index", "Admin");
            }
            else if(check != null && check.Vaitro.Equals("nv"))
            {
                HttpContext.Session.SetString("NV", strEmail);
                return RedirectToAction("Index", "NhanVien");
            }
            ViewBag.Error = "Đăng nhập không thành công";
            return View();
        }
    }
}

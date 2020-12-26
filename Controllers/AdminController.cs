using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using YourTour.Models.Commands;
using YourTour.Models.db;
using YourTour.Models.ViewModels;
using YourTour.Service;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace YourTour.Controllers
{
    public class AdminController : Controller
    {
        private readonly YourTourContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly TravelService _travelService;
        private readonly StaffService _staffService;
        private readonly LocationService _locationService;
        private readonly CommonService _commonService;
        private readonly AdminService _adminService;
        private readonly TourService _tourService;

        public AdminController(YourTourContext db, IHostingEnvironment hostingEnvironment,
            TravelService travelService, StaffService staffService, LocationService locationService,
            CommonService commonService, AdminService adminService, TourService tourService)
        {
            this._db = db;
            this._hostingEnvironment = hostingEnvironment;
            this._travelService = travelService;
            this._staffService = staffService;
            this._locationService = locationService;
            this._commonService = commonService;
            this._adminService = adminService;
            this._tourService = tourService;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Admin") == null)
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
            else if (check != null && check.Vaitro.Equals("nv"))
            {
                HttpContext.Session.SetString("NV", strEmail);
                return RedirectToAction("Index", "NhanVien");
            }
            ViewBag.Error = "Đăng nhập không thành công";
            return View();
        }

        public IActionResult InsertTour()
        {
            List<Diadiemdulich> listDiadiem = new List<Diadiemdulich>();
            listDiadiem = (from t in _db.Diadiemduliches select t).ToList();
            ViewBag.ListDiaDiem = listDiadiem;
            List<Mien> listMien = new List<Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            ViewBag.ListMien = listMien;
            return View();
        }
        [HttpPost]
        public IActionResult InsertTour(InsertTourCommand tourCommand, Diadiemdulich diadiem, Mien mien)
        {
            List<Diadiemdulich> listDiadiem = new List<Models.db.Diadiemdulich>();
            listDiadiem = (from t in _db.Diadiemduliches
                               //where t.MienID == SelectedValue2
                           select t).ToList();
            ViewBag.ListDiaDiem = listDiadiem;
            List<Mien> listMien = new List<Models.db.Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            ViewBag.ListMien = listMien;
            string getNameLichTrinh = null;
            string getNamePicture = null;
            if (ModelState.IsValid)
            {
                if (tourCommand != null)
                {
                    getNameLichTrinh = Path.GetFileName(tourCommand.Lichtrinh.FileName);
                    var uploadFolderLT = Path.Combine(this._hostingEnvironment.WebRootPath, "docs/lichtrinh");
                    var getLichtrinhToFolder = Path.Combine(uploadFolderLT, getNameLichTrinh);
                    getNamePicture = Path.GetFileName(tourCommand.Hinhanh.FileName);
                    var uploadFolder = Path.Combine(this._hostingEnvironment.WebRootPath, "images/tour_images");
                    var getPictureToFolder = Path.Combine(uploadFolder, getNamePicture);
                    if (System.IO.File.Exists(getPictureToFolder))
                    {
                        ViewBag.Picture = "Hinh anh da ton tai";
                        return View();
                    }
                    else
                    {
                        var filestream2 = new FileStream(getLichtrinhToFolder, FileMode.Create);
                        tourCommand.Lichtrinh.CopyTo(filestream2);
                        var filestream = new FileStream(getPictureToFolder, FileMode.Create);
                        tourCommand.Hinhanh.CopyTo(filestream);
                        var newTour = new Tour();
                        {
                            //newTour.ID = _db.Tours.Count() + 1;
                            newTour.Tentour = tourCommand.Tentour;
                            newTour.Code = tourCommand.Code;
                            newTour.Diadiemkhoihanh = tourCommand.Diadiemkhoihanh;
                            newTour.Diemden = tourCommand.Diemden;
                            newTour.Ngaydi = tourCommand.Ngaydi;
                            newTour.Thuocmien = tourCommand.Thuocmien;
                            if (tourCommand.Loaitour == "Trong nước")
                            {
                                newTour.Loaitour = "Trong nước";
                            }
                            else
                            {
                                newTour.Loaitour = "Nước ngoài";
                            }
                            newTour.Thoigiandi = tourCommand.Thoigiandi;
                            newTour.Lichtrinh = getNameLichTrinh;
                            newTour.Gianguoilon = tourCommand.Gianguoilon;
                            newTour.Hinhanh = getNamePicture /*+ DateTime.Now.ToString()*/;
                            newTour.Mota = tourCommand.Mota;
                            newTour.Songuoi = tourCommand.Songuoi;
                            //newTour.Loaitour = tourCommand.Loaitour;
                            newTour.TenHDV = tourCommand.TenHDV;
                            newTour.Trangthai = "Còn chỗ";
                            //foreach (var selectedId in tourCommand.MultiDiaDiem)
                            //{
                            //    _db.DiadiemTours.Add(new DiadiemTour
                            //    {
                            //        TourID = newTour.ID,
                            //        DiadiemdulichID = selectedId,
                            //    });
                            //}
                            //_db.SaveChanges();
                        }
                        _db.Tours.Add(newTour);
                        _db.SaveChanges();
                        RedirectToAction("Index", "Admin");
                    }
                }
            }
            return View();
        }

        public IActionResult ShowAllTour(int? page)
        {
            if (page == null) page = 1;
            var alltour = this._travelService.ShowAllTour();
            alltour.OrderByDescending(x => x.ID);
            int pagesize = 3;
            int pagenumber = (page ?? 1);
            return View(alltour.ToPagedList(pagenumber, pagesize));
        }

        [HttpGet]
        public IActionResult EditTour(int id)
        {
            List<Diadiemdulich> listDiadiem = new List<Diadiemdulich>();
            listDiadiem = (from t in _db.Diadiemduliches select t).ToList();
            ViewBag.ListDiaDiem = listDiadiem;
            List<Mien> listMien = new List<Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            ViewBag.ListMien = listMien;
            var model = this._travelService.SeeTour(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditTour(TourViewModel command)
        {
            List<Diadiemdulich> listDiadiem = new List<Models.db.Diadiemdulich>();
            listDiadiem = (from t in _db.Diadiemduliches
                               //where t.MienID == SelectedValue2
                           select t).ToList();
            ViewBag.ListDiaDiem = listDiadiem;
            List<Mien> listMien = new List<Models.db.Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            ViewBag.ListMien = listMien;
            var model = this._travelService.SeeTour(command.ID);
            model.Tentour = command.Tentour;
            model.Thuocmien = command.Thuocmien;
            model.Diadiemkhoihanh = command.Diadiemkhoihanh;
            model.Diemden = command.Diemden;
            model.Thoigiandi = command.Thoigiandi;
            //model.Hinhanh = command.Hinhanh;
            // model.Lichtrinh = command.Lichtrinh;
            model.Mota = command.Mota;
            model.Ngaydi = command.Ngaydi;
            model.Songuoi = command.Songuoi;
            model.TenHDV = command.TenHDV;
            model.Gianguoilon = command.Gianguoilon;

            if (ModelState.IsValid)
            {
                this._travelService.EditTour(command);
                return RedirectToAction("ShowAllTour", "Admin");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStaff(NhanvienViewModel command, Taikhoan taikhoan)
        {
            if (ModelState.IsValid)
            {
                this._staffService.AddStaff(command, taikhoan);
                return RedirectToAction("AllStaff", "Admin");
            }
            return View();
        }
        public IActionResult AllStaff()
        {
            var model = this._staffService.AllStaff();
            return View(model);
        }
        public IActionResult EditStaff(int id)
        {
            var model = this._staffService.SeeStaff(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditStaff(NhanvienViewModel command)
        {
            var model = this._staffService.SeeStaff(command.ID);
            model.Hoten = command.Hoten;
            model.Gioitinh = command.Gioitinh;
            model.Email = command.Email;
            model.Matkhau = command.Matkhau;
            model.Sdt = command.Sdt;
            model.Vaitro = command.Vaitro;
            if (ModelState.IsValid)
            {
                this._staffService.EditStaff(command);
                return RedirectToAction("AllStaff", "Admin");
            }
            return View(model);
        }
        public IActionResult AllLocation()
        {
            var model = this._locationService.AllLocation();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddLocation()
        {
            //ViewBag.Tinh = new SelectList(_db.Tinhs.Where(row => row.ID).ToList());
            //List<Tinh> lsTinh = new List<Tinh>();
            //var lsTinh = _db.Tinhs.ToList();
            //ViewBag.msg = lsTinh;
            List<Mien> listMien = new List<Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            //listMien.Insert(0, new Mien { ID = 0, Tenmien = "Chọn miền" });
            ViewBag.ListMien = listMien;
            return View();
        }
        [HttpPost]
        public IActionResult AddLocation(LocationCommand command, Mien mien)
        {
            //ViewBag.Tinh = new SelectList(_db.Miens.ToList());
            if (ModelState.IsValid)
            {
                this._locationService.AddLocation(command);
                return RedirectToAction("AllLocation", "Admin");
            }
            //if (command.ID == 0)
            //{
            //    ModelState.AddModelError("", "Chọn miền");
            //}
            int SelectValue = mien.ID;
            ViewBag.SelectedValue = mien.ID;
            List<Mien> listMien = new List<Models.db.Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            //listMien.Insert(0, new Mien { ID = 0, Tenmien = "Chọn miền" });
            ViewBag.ListMien = listMien;
            return View();
        }
        public IActionResult EditLocation(int id)
        {
            List<Mien> listMien = new List<Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            ViewBag.ListMien = listMien;
            var model = this._locationService.SeeLocation(id);
            return View(model);
        }
        [HttpPost]
        public IActionResult EditLocation(LocationCommand command, Mien mien)
        {
            int SelectValue = mien.ID;
            ViewBag.SelectedValue = mien.ID;
            List<Mien> listMien = new List<Models.db.Mien>();
            listMien = (from t in _db.Miens select t).ToList();
            //listMien.Insert(0, new Mien { ID = 0, Tenmien = "Chọn miền" });
            ViewBag.ListMien = listMien;
            var model = this._locationService.SeeLocation(command.ID);
            model.Tendiadiem = command.Tendiadiem;
            model.Mota = command.Mota;
            if (ModelState.IsValid)
            {
                this._locationService.EditLocation(command);
                return RedirectToAction("AllLocation", "Admin");
            }
            return View(model);
        }
        public IActionResult ShowAllBookingTour()
        {
            var model = this._commonService.GetAllThongTinBookingTourMienNam();
            if (model == null)
            {
                return null;
            }
            return View(model);
        }
        public IActionResult ShowChiTietThongTinBooking(int id)
        {
            var model = this._commonService.GetChiTietThongTinBookingTourMienBac(id);
            if (model == null)
            {
                return null;
            }
            return View(model);
        }
        public IActionResult HuyBookingTour(int id)
        {
            var model = this._commonService.HuyBookingTour(id);
            return RedirectToAction("ShowAllBookingTour", "Admin");
        }

        //hiển thị danh sách khách đặt tour tùy chọn
        public IActionResult DanhSachTourTuyChon()
        {
            var model = this._adminService.GetTourTuyChon();
            return View(model);
        }
        //xác nhận đặt tour tùy chọn

        public IActionResult XacNhanDatTourTuyChon(int id)
        {
            var tour = this._tourService.GetTourTuyChon(id);
            tour.Xacnhan = 1;
            _db.TourTuyChons.Update(tour);
            _db.SaveChanges();
            return RedirectToAction("DanhSachTourTuyChon", "Admin");
        }
        public IActionResult DanhSachTourTuyChonDaXacNhan()
        {
            var model = this._adminService.GetTourTuyChonDaXacNhan();
            return View(model);
        }
    }
}

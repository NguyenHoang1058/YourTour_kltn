using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class ThanhToanController : Controller
    {
        private readonly HoaDonService _hoaDonService;
        public ThanhToanController (HoaDonService hoaDonService)
        {
            this._hoaDonService = hoaDonService;
        }
        public IActionResult Index()
        {
            return View();
        }
        // lấy phương thức thanh toán trong hóa đơn để hiển thị trang tương ứng
        public IActionResult ThanhToan()
        {
            var ptthanhtoan = this._hoaDonService.GetPTThanhToan();
            if (ptthanhtoan.Ptthanhtoan.Equals("Tiền mặt"))
            {
                return RedirectToAction("ThanhToanTienMat", "ThanhToan");
            }
            else if (ptthanhtoan.Ptthanhtoan.Equals("Thanh toán online"))
            {

                return RedirectToAction("ThanhToanOnline", "ThanhToan");
            }
            else
            {
                return RedirectToAction("ThanhToanChuyenKhoan", "ThanhToan");
            }
        }
        public IActionResult ThanhToanTienMat()
        {
            return View();
        }
        public IActionResult ThanhToanChuyenKhoan()
        {
            return View();
        }
        public IActionResult ThanhToanOnline()
        {
            return View();
        }
    }
}

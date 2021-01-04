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
        // lấy phương thức thanh toán trong hóa đơn để hiển thị trang tương ứng của tour miền Nam
        public IActionResult ThanhToanTourMienNam()
        {
            var ptthanhtoan = this._hoaDonService.GetPTThanhToan();
            if (ptthanhtoan.Ptthanhtoan.Equals("Tiền mặt"))
            {
                return RedirectToAction("ThanhToanTienMat", "ThanhToan");
            }
            else if (ptthanhtoan.Ptthanhtoan.Equals("Thanh toán online"))
            {

                return RedirectToAction("ThanhToanTourMienNam", "OnePay");
            }
            else
            {
                return RedirectToAction("ThanhToanChuyenKhoan", "ThanhToan");
            }
        }
        // lấy phương thức thanh toán trong hóa đơn để hiển thị trang tương ứng của tour miền Bác
        public IActionResult ThanhToanTourMienBac()
        {
            var ptthanhtoan = this._hoaDonService.GetPTThanhToan();
            if (ptthanhtoan.Ptthanhtoan.Equals("Tiền mặt"))
            {
                return RedirectToAction("ThanhToanTienMat", "ThanhToan");
            }
            else if (ptthanhtoan.Ptthanhtoan.Equals("Thanh toán online"))
            {

                return RedirectToAction("ThanhToanTourMienBac", "OnePay");
            }
            else
            {
                return RedirectToAction("ThanhToanChuyenKhoan", "ThanhToan");
            }
        }

        // lấy phương thức thanh toán trong hóa đơn để hiển thị trang tương ứng của tour miền Trung
        public IActionResult ThanhToanTourMienTrung()
        {
            var ptthanhtoan = this._hoaDonService.GetPTThanhToan();
            if (ptthanhtoan.Ptthanhtoan.Equals("Tiền mặt"))
            {
                return RedirectToAction("ThanhToanTienMat", "ThanhToan");
            }
            else if (ptthanhtoan.Ptthanhtoan.Equals("Thanh toán online"))
            {

                return RedirectToAction("ThanhToanTourMienTrung", "OnePay");
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
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using YourTour.Models.db;
using YourTour.Payment;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class OnePayController : Controller
    {
        private readonly HoaDonService _hoaDonService;
        private readonly YourTourContext _db;
        public OnePayController(HoaDonService hoaDonService, YourTourContext db)
        {
            this._hoaDonService = hoaDonService;
            this._db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OnePay()
        {
            var hd = _hoaDonService.GetTotal();
            string total = (hd.Tongtien* 100).ToString();
            string url = RedirectToOnpay("Thanh toán đặt tour", total, "190.168.0.1");
            return Redirect(url);
        }
        public IActionResult OnePayResponse()
        {
            string hashValidateResult = "";

            //khởi tạo lớp thư viện
            VPCRequest conn = new VPCRequest(OnePayProperties.URL_ONEPAY_TEST);
            conn.SetSecureSecret(OnePayProperties.HASH_CODE);

            //lấy kết quả từ url được trả về từ cổng thanh toán
            hashValidateResult = conn.Process3rdPartyResponse(HttpUtility.ParseQueryString(Request.QueryString.ToString()));

            //lấy tham số trả về từ cổng thanh toán
            string vpc_TxnResponseCode = conn.GetResponseData("vpc_TxnResponseCode");
            string amount = conn.GetResponseData("vpc_Amount");
            string localed = conn.GetResponseData("vpc_Locale");
            string command = conn.GetResponseData("vpc_Command");
            string version = conn.GetResponseData("vpc_Version");
            string cardType = conn.GetResponseData("vpc_Card");
            string orderInfo = conn.GetResponseData("vpc_OrderInfo");
            string merchantID = conn.GetResponseData("vpc_Merchant");
            string authorizeID = conn.GetResponseData("vpc_AuthorizeId");
            string merchTxnRef = conn.GetResponseData("vpc_MerchTxnRef");
            string transactionNo = conn.GetResponseData("vpc_TransactionNo");
            string acqResponseCode = conn.GetResponseData("vpc_AcqResponseCode");
            string txnResponseCode = vpc_TxnResponseCode;
            string message = conn.GetResponseData("vpc_Message");
            if(hashValidateResult == "CORRECTED" && txnResponseCode.Trim() == "0")
            {
                var hd = _hoaDonService.GetTotal();
                hd.Tinhtrang = 1;
                _db.Hoadons.Update(hd);
                _db.SaveChanges();
                return View("/Views/OnePay/ThanhToanThanhCong.cshtml");
            }
            else if(hashValidateResult == "INVALIDATED" && txnResponseCode.Trim() == "0")
            {
                return View("/Views/OnePay/ThanhToanDangGiaiQuyet.cshtml");
            }
            else
            {
                return View("/Views/OnePay/ThanhToanKhongThanhCong.cshtml");
            }    

        }
        public string RedirectToOnpay(string codeInvoice, string amount, string ip)
        {
            //khởi tạo lớp thư viện
            VPCRequest conn = new VPCRequest(OnePayProperties.URL_ONEPAY_TEST);
            conn.SetSecureSecret(OnePayProperties.HASH_CODE);

            //truyền các thông số để chuyển sang cổng onepay
            conn.AddDigitalOrderField("AgainLink", OnePayProperties.AGAIN_LINK);
            conn.AddDigitalOrderField("Title", "Online Payment With OnePay");
            conn.AddDigitalOrderField("vpc_Locale", OnePayProperties.PAYGATE_LANGUAGE);
            conn.AddDigitalOrderField("vpc_Version", OnePayProperties.VERSION);
            conn.AddDigitalOrderField("vpc_Command", OnePayProperties.COMMAND);
            conn.AddDigitalOrderField("vpc_Merchant", OnePayProperties.MERCHANT_ID);
            conn.AddDigitalOrderField("vpc_AccessCode", OnePayProperties.ACCESS_CODE);
            conn.AddDigitalOrderField("vpc_MerchTxnRef", RandomString());
            conn.AddDigitalOrderField("vpc_Currency", "VND");
            conn.AddDigitalOrderField("vpc_OrderInfo", codeInvoice);
            conn.AddDigitalOrderField("vpc_Amount", amount);
            conn.AddDigitalOrderField("vpc_ReturnURL", Url.Action("OnepayResponse", "OnePay", null, Request.Scheme, null));

            //thông tin khách hàng
            conn.AddDigitalOrderField("vpc_SHIP_Street01", "");
            conn.AddDigitalOrderField("vpc_SHIP_Provice", "");
            conn.AddDigitalOrderField("vpc_SHIP_City", "");
            conn.AddDigitalOrderField("vpc_SHIP_Country", "");
            conn.AddDigitalOrderField("vpc_Customer_Phone", "");
            conn.AddDigitalOrderField("vpc_Customer_Email", "");
            conn.AddDigitalOrderField("vpc_Customer_Id", "");
            conn.AddDigitalOrderField("vpc_TicketNo", ip);
            string url = conn.Create3rdPartyQueryString();
            return url;
        }
        private string RandomString()
        {
            var str = new StringBuilder();
            var random = new Random();
            for (int i = 0; i <= 8; i++)
            {
                var c = Convert.ToChar(Convert.ToInt32(random.Next(65, 68) + Convert.ToInt32(random.Next(48,57))));
                str.Append(c);
            }
            return str.ToString().ToLower();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;
using YourTour.Models.Validate;

namespace YourTour.Models.db
{
    public class Khachhang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Hoten { get; set; }
        public string Cmnd { get; set; }
        public string  Diachi { get; set; }
        public string Sdt { get; set; }
        public string Email{ get; set; }
        public ICollection<Hoadon> Hoadons { get; set; }
        public Khachhang() { }
        public Khachhang(KhachhangViewModel khachhangViewModel)
        {
            this.ID = khachhangViewModel.ID;
            this.Hoten = khachhangViewModel.Hoten;
            this.Cmnd = khachhangViewModel.Cmnd;
            this.Diachi = khachhangViewModel.Diachi;
            this.Sdt = khachhangViewModel.Sdt;
            this.Email = khachhangViewModel.Email;
        }
        public Khachhang(DatTourValidation validation)
        {
            this.Hoten = validation.Hoten;
            this.Cmnd = validation.Cmnd;
            this.Diachi = validation.Diachi;
            this.Sdt = validation.Sdt;
            this.Email = validation.Email;
        }
    }
}

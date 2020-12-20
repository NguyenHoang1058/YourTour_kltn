using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class TourTuyChon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TenKH { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Mien { get; set; }
        public int Songuoidi { get; set; }
        public byte Xacnhan { get; set; }
        public DateTime Ngaykhoihanh { get; set; }
        public string Ghichu { get; set; }

        public TourTuyChon() { }
        public TourTuyChon(TourTuyChonViewModel tourTuyChonViewModel)
        {
            this.ID = tourTuyChonViewModel.ID;
            this.TenKH = tourTuyChonViewModel.TenKH;
            this.Email = tourTuyChonViewModel.Email;
            this.Sdt = tourTuyChonViewModel.Sdt;
            this.Mien = tourTuyChonViewModel.Mien;
            this.Songuoidi = tourTuyChonViewModel.Songuoidi;
            this.Ngaykhoihanh = tourTuyChonViewModel.Ngaykhoihanh;
            this.Ghichu = tourTuyChonViewModel.Ghichu;
            this.Xacnhan = tourTuyChonViewModel.Xacnhan;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;

namespace YourTour.Models.ViewModels
{
    public class DiadiemViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên địa điểm không được để trống")]
        public string Tendiadiem { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Mota { get; set; }
        public string Hinhanh { get; set; }
        public int MienID { get; set; }
        //public int TourID { get; set; }
        //public Tinh Tinh { get; set; }
    }
}

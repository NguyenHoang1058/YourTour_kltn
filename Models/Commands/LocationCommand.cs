using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.Commands
{
    public class LocationCommand
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Tên địa điểm không được để trống")]
        public string Tendiadiem { get; set; }
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Mota { get; set; }
        //public int TinhID { get; set; }
        public int MienID { get; set; }
    }
}

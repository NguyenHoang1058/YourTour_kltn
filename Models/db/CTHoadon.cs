using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class CTHoadon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Hotenkhachhang { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public int Songuoidi { get; set; }
        public string Ptthanhtoan { get; set; }
        public int HoadonID { get; set; }
        public int TourID { get; set; }
        public Hoadon Hoadon { get; set; }
        public Tour Tour { get; set; }
    }
}

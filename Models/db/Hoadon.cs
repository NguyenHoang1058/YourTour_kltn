using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Hoadon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public DateTime Ngaylaphd { get; set; }
        public int Tongtien { get; set; }
        public byte Tinhtrang { get; set; }
        public int KhachHangID { get; set; }
        public Khachhang Khachhang { get; set; }
        public ICollection<CTHoadon> CTHoadons { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Khachhang
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public string Sdt { get; set; }
        public string Email{ get; set; }
        public ICollection<Hoadon> Hoadons { get; set; }
    }
}

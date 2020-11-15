using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.db
{
    public class Nguoidung
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public Taikhoan Taikhoan { get; set; }
    }
}

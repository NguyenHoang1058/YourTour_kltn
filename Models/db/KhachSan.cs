using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class KhachSan
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tenks { get; set; }
        public string Hinhanh { get; set; }
        public string Mota { get; set; }
        public string Diachi { get; set; }
        public int MyProperty { get; set; }
        public int Gia { get; set; }
        public int DiaDiemID { get; set; }
        public Diadiemdulich Diadiemdulich { get; set; }
    }
}

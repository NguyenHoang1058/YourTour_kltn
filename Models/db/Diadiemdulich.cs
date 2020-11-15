using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Diadiemdulich
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tendiadiem { get; set; }
        public string Mota { get; set; }
        public int TinhID { get; set; }
        public Tinh Tinh { get; set; }
        public ICollection<Diadiemtour> Diadiemtours { get; set; }
    }
}

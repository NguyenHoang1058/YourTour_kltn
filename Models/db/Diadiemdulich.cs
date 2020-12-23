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
        public int MienID { get; set; }
        public Mien Mien { get; set; }
        public ICollection<Tour> Tours { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Mien
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tenmien { get; set; }
        public ICollection<Tour> Tours { get; set; }
        public ICollection<Diadiemdulich> Diadiemduliches{ get; set; }
        
    }
}

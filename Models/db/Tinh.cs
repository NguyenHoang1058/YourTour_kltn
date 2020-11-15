using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Tinh
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Tentinh { get; set; }
        public int MienID { get; set; }
        public Mien Mien { get; set; }
        public ICollection<Diadiemdulich> Diadiemduliches{ get; set; }
    }
}

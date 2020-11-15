using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Diadiemtour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int TourID { get; set; }
        public int DiadiemdulichID { get; set; }
        public Tour Tour { get; set; }
        public Diadiemdulich Diadiemdulich { get; set; }
    }
}

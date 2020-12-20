using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class DiadiemTour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        //[Key]
        public int DiadiemdulichID { get; set; }
        public Diadiemdulich Diadiemdulich { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int TourID { get; set; }
        public Tour Tour { get; set; }
    }
}
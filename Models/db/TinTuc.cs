using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

namespace YourTour.Models.db
{
    public class TinTuc
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string TieuDe { get; set; }
        public DateTime NgayDang { get; set; }
        public string HinhAnh { get; set; }
        public string NoiDung { get; set; }
        public TinTuc() { }
        public TinTuc(TinTucViewModel tt)
        {
            this.ID = tt.ID;
            this.TieuDe = tt.TieuDe;
            this.NgayDang = tt.NgayDang;
            this.HinhAnh = tt.HinhAnh;
            this.NoiDung = tt.NoiDung;
        }
    }
}

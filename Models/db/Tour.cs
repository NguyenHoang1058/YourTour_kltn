using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace YourTour.Models.db
{
    public class Tour
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID{ get; set; }
        public string Code { get; set; }
        public string Tentour { get; set; }
        public string Diadiemkhoihanh { get; set; }
        public string Diemden { get; set; }
        public DateTime Ngaydi { get; set; }
        public DateTime Ngayve { get; set; }
        public int Thoigiandi { get; set; }
        public string Hinhanh { get; set; }
        public string Lichtrinh { get; set; }
        public int Gianguoilon { get; set; }
        public int Giatreem { get; set; }
        public string Mota { get; set; }
        public byte Trongnuoc{ get; set; }
        public byte Tuychon { get; set; }

        public ICollection<Diadiemdulich> Diadiemduliches{ get; set; }

    }
}

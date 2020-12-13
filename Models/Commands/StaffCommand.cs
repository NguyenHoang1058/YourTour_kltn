using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.Commands
{
    public class StaffCommand
    {
        public int ID { get; set; }
        public string Hoten { get; set; }
        public string Gioitinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string Matkhau { get; set; }
        public string Vaitro { get; set; }
    }
}

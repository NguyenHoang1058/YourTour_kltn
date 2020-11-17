﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using YourTour.Models.ViewModels;

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
        public int Songuoi { get; set; }

        public ICollection<Diadiemdulich> Diadiemduliches{ get; set; }

        public Tour(TourViewModel tourViewModel)
        {
            this.ID = tourViewModel.ID;
            this.Code = tourViewModel.Code;
            this.Tentour = tourViewModel.Tentour;
            this.Diadiemkhoihanh = tourViewModel.Diadiemkhoihanh;
            this.Diemden = tourViewModel.Diemden;
            this.Ngaydi = tourViewModel.Ngaydi;
            this.Ngayve = tourViewModel.Ngayve;
            this.Hinhanh = tourViewModel.Hinhanh;
            this.Lichtrinh = tourViewModel.Lichtrinh;
            this.Gianguoilon = tourViewModel.Gianguoilon;
            this.Giatreem = tourViewModel.Giatreem;
            this.Mota = tourViewModel.Mota;
            this.Trongnuoc = tourViewModel.Trongnuoc;
            this.Tuychon = tourViewModel.Tuychon;
            this.Songuoi = tourViewModel.Songuoi;
        }
        public Tour()
        {

        }

    }
}

﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Threading.Tasks;

namespace YourTour.Models.db
{
    public class YourTourContext : DbContext
    {
        public YourTourContext(DbContextOptions<YourTourContext> options) : base(options)
        {
        }

        public DbSet<Nguoidung> Nguoidungs { get; set; }
        public DbSet<Taikhoan> Taikhoans { get; set; }
        public DbSet<Mien> Miens { get; set; }
        public DbSet<Diadiemdulich> Diadiemduliches { get; set; }
        public DbSet<LienHe> LienHes { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<Hoadon> Hoadons { get; set; }
        public DbSet<CTHoadonNam> CTHoadonNams { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<CTHoadonBac> CTHoadonBacs { get; set; }
        public DbSet<CTHoadonTrung> CTHoadonTrungs { get; set; }
        public DbSet<TourTuyChon> TourTuyChons { get; set; }
        public DbSet<KinhNghiemDuLich> KinhNghiemDuLiches { get; set; }
        public DbSet<TinTuc> TinTucs{ get; set; }
        public DbSet<KhachSan> KhachSans { get; set; }
        public DbSet<CTHoadonTuChon> CTHoadonTuChons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nguoidung>().ToTable("Nguoidung");
            modelBuilder.Entity<Taikhoan>().ToTable("Taikhoan");
            modelBuilder.Entity<Mien>().ToTable("Mien");
            modelBuilder.Entity<Diadiemdulich>().ToTable("Diadiemdulich");
            modelBuilder.Entity<KinhNghiemDuLich>().ToTable("KinhNghiemDuLich");
            modelBuilder.Entity<Khachhang>().ToTable("Khachhang");
            modelBuilder.Entity<Hoadon>().ToTable("Hoadon");
            modelBuilder.Entity<CTHoadonNam>().ToTable("CTHoadonNam");
            modelBuilder.Entity<Tour>().ToTable("Tour");
            modelBuilder.Entity<CTHoadonBac>().ToTable("CTHoadonBac");
            modelBuilder.Entity<CTHoadonTrung>().ToTable("CTHoadonTrung");
            modelBuilder.Entity<TourTuyChon>().ToTable("TourTuyChon");
            modelBuilder.Entity<LienHe>().ToTable("LienHe");
            modelBuilder.Entity<TinTuc>().ToTable("TinTuc");
            modelBuilder.Entity<KhachSan>().ToTable("KhachSan");
            modelBuilder.Entity<CTHoadonTuChon>().ToTable("CTHoadonTuChon");
        }
    }
}

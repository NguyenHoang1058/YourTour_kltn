using Microsoft.EntityFrameworkCore;
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
        public DbSet<Tinh> Tinhs { get; set; }
        public DbSet<Diadiemdulich> Diadiemduliches { get; set; }
        public DbSet<Khachhang> Khachhangs { get; set; }
        public DbSet<Hoadon> Hoadons { get; set; }
        public DbSet<CTHoadon> CTHoadons { get; set; }
        public DbSet<Tour> Tours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nguoidung>().ToTable("Nguoidung");
            modelBuilder.Entity<Taikhoan>().ToTable("Taikhoan");
            modelBuilder.Entity<Mien>().ToTable("Mien");
            modelBuilder.Entity<Tinh>().ToTable("Tinh");
            modelBuilder.Entity<Diadiemdulich>().ToTable("Diadiemdulich");
            modelBuilder.Entity<Khachhang>().ToTable("Khachhang");
            modelBuilder.Entity<Hoadon>().ToTable("Hoadon");
            modelBuilder.Entity<CTHoadon>().ToTable("CTHoadon");
            modelBuilder.Entity<Tour>().ToTable("Tour");
        }
    }
}

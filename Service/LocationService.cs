using Dapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.Commands;
using YourTour.Models.db;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class LocationService
    {
        private readonly YourTourContext _db;
        public LocationService(YourTourContext db)
        {
            this._db = db;
        }
        public void AddLocation(LocationCommand locationCommand)
        {
            //var newStaff = new Nguoidung();
            var newLocation = new Diadiemdulich();
            {
                newLocation.Tendiadiem = locationCommand.Tendiadiem;
                newLocation.Mota = locationCommand.Mota;
                newLocation.MienID = locationCommand.MienID;
            }
            _db.Diadiemduliches.Add(newLocation);
            _db.SaveChanges();
        }
        public List<LocationCommand> AllLocation()
        {
            var listLocation = new List<LocationCommand>();
            using (var connection = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();
                listLocation = connection.Query<LocationCommand>(@"Select * From Diadiemdulich").ToList();
                connection.Close();
            }
            return listLocation;
        }
        public DiadiemViewModel SeeLocation(int id)
        {
            DiadiemViewModel viewModel = new DiadiemViewModel();
            var listLocation = _db.Diadiemduliches.FirstOrDefault(n => n.ID == id);
            //var listStaff2 = _db.Taikhoans.FirstOrDefault(e => e.Email == listStaff.Email);
            {
                viewModel.ID = listLocation.ID;
                viewModel.Tendiadiem = listLocation.Tendiadiem;
                viewModel.Mota = listLocation.Mota;
                //viewModel.TinhID = listLocation.TinhID;
                //viewModel.Email = listStaff.Email;
                //viewModel.Matkhau = listStaff2.Matkhau;
                //viewModel.Vaitro = listStaff2.Vaitro;
            }
            return viewModel;
        }
        public void EditLocation(LocationCommand command)
        {
            var checkLocation = _db.Diadiemduliches.FirstOrDefault(n => n.ID == command.ID);
            //var checkAccount = _db.Taikhoans.FirstOrDefault(a => a.Email == checkStaff.Email);
            {
                checkLocation.Tendiadiem = command.Tendiadiem;
                checkLocation.Mota = command.Mota;
                //checkLocation.TinhID = command.TinhID;
                //checkStaff.Email = command.Email;
                //checkAccount.Matkhau = command.Matkhau;
                //checkAccount.Vaitro = command.Vaitro;
            }
            _db.SaveChanges();
        }
        //public DiadiemViewModel ChiTietDiaDiem(int? id)
        //{
        //    var ddId = new List<DiadiemViewModel>();

        //    using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
        //    {
        //        conn.Open();
        //        ddId = conn.Query<DiadiemViewModel>(@"select * from Taikhoan join Nguoidung on Taikhoan.Email = Nguoidung.Email where Nguoidung.ID=" + id).ToList();
        //        conn.Close();
        //    }

        //    return nvId.SingleOrDefault(n => n.ID == id);
        //}
    }
}

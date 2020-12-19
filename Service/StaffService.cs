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
    public class StaffService
    {
        private readonly YourTourContext _db;
        public StaffService(YourTourContext db)
        {
            this._db = db;
        }
        public void AddStaff(NhanvienViewModel nhanvien, Taikhoan taikhoan)
        {
            var newStaff = new Nguoidung();
            var newaccount = new Taikhoan();
            {
                newStaff.Hoten = nhanvien.Hoten;
                newStaff.Sdt = nhanvien.Sdt;
                newStaff.Email = nhanvien.Email;
                newStaff.Gioitinh = nhanvien.Gioitinh;
                newaccount.Email = newStaff.Email;
                newaccount.Matkhau = taikhoan.Matkhau;
                newaccount.Vaitro = taikhoan.Vaitro;
            }
            _db.Taikhoans.Add(newaccount);
            _db.Nguoidungs.Add(newStaff);
            _db.SaveChanges();
        }
        public List<NhanvienViewModel> AllStaff()
        {
            var listStaff = new List<NhanvienViewModel>();
            using (var connection = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                connection.Open();
                listStaff = connection.Query<NhanvienViewModel>(@"Select * From Nguoidung").ToList();
                connection.Close();
            }
            return listStaff;
        }
        public NhanvienViewModel SeeStaff(int id)
        {
            NhanvienViewModel viewModel = new NhanvienViewModel();
            var listStaff = _db.Nguoidungs.FirstOrDefault(n => n.ID == id);
            var listStaff2 = _db.Taikhoans.FirstOrDefault(e => e.Email == listStaff.Email);
            {
                viewModel.ID = listStaff.ID;
                viewModel.Hoten = listStaff.Hoten;
                viewModel.Gioitinh = listStaff.Gioitinh;
                viewModel.Sdt = listStaff.Sdt;
                viewModel.Email = listStaff.Email;
                viewModel.Matkhau = listStaff2.Matkhau;
                viewModel.Vaitro = listStaff2.Vaitro;
            }
            return viewModel;
        }
        public void EditStaff(NhanvienViewModel command)
        {
            var checkStaff = _db.Nguoidungs.FirstOrDefault(n => n.ID == command.ID);
            var checkAccount = _db.Taikhoans.FirstOrDefault(a => a.Email == checkStaff.Email);
            {
                checkStaff.Hoten = command.Hoten;
                checkStaff.Sdt = command.Sdt;
                checkStaff.Gioitinh = command.Gioitinh;
                checkStaff.Email = command.Email;
                checkAccount.Matkhau = command.Matkhau;
                checkAccount.Vaitro = command.Vaitro;
            }
            _db.SaveChanges();
        }
        public NhanvienViewModel ChiTietNhanVien(int? id)
        {
            var nvId = new List<NhanvienViewModel>();

            using (var conn = new SqlConnection(this._db.Database.GetDbConnection().ConnectionString))
            {
                conn.Open();
                nvId = conn.Query<NhanvienViewModel>(@"select * from Taikhoan join Nguoidung on Taikhoan.Email = Nguoidung.Email where Nguoidung.ID=" + id).ToList();
                conn.Close();
            }

            return nvId.SingleOrDefault(n => n.ID == id);
        }
    }
}

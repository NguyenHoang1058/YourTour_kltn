using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;
using YourTour.Models.Commands;
using System.IO;

namespace YourTour.Service
{
    public class TravelService
    {
        private readonly YourTourContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        public TravelService(YourTourContext db, IHostingEnvironment hostingEnvironment)
        {
            this._db = db;
            this._hostingEnvironment = hostingEnvironment;
        }
        //public List<ContractDetailViewModel> ListTravel()
        //{
        //    var listTravelDb = from c in _db.ContractDetails
        //                       join t in _db.Tours on c.TourId equals t.Id
        //                       join ct in _db.Contracts on c.ContractId equals ct.Id
        //                       join cs in _db.Customers on ct.CustomerId equals cs.Id
        //                       select new { t.Code, c.NameTour, cs.Name, ct.BeginDate, ct.Paid, t.Cost, c.Id };
        //    var listTravel = new List<ContractDetailViewModel>();
        //    foreach (var item in listTravelDb)
        //    {
        //        ContractDetailViewModel viewModel = new ContractDetailViewModel();
        //        viewModel.Id = item.Id;
        //        viewModel.Code = item.Code;
        //        viewModel.NameTour = item.NameTour;
        //        viewModel.NameCustomer = item.Name;
        //        viewModel.BeginDate = item.BeginDate;
        //        viewModel.Paid = item.Paid;
        //        viewModel.Cost = item.Cost;
        //        listTravel.Add(viewModel);
        //    }
        //    return listTravel;
        //}
        public IQueryable<TourViewModel> ShowAllTour()
        {
            var tours = from t in _db.Tours
                        select new { t.ID, t.Code, t.Tentour, t.Diadiemkhoihanh, t.Diemden, t.Ngaydi, t.Lichtrinh, t.Hinhanh, t.Gianguoilon, t.TenHDV, t.Mota, t.Trangthai, t.Songuoi };

            var tourView = new List<TourViewModel>();
            foreach (var item in tours)
            {
                TourViewModel tourViewModel = new TourViewModel();
                tourViewModel.ID = item.ID;
                tourViewModel.Code = item.Code;
                tourViewModel.Tentour = item.Tentour;
                tourViewModel.Diadiemkhoihanh = item.Diadiemkhoihanh;
                tourViewModel.Diemden = item.Diemden;
                tourViewModel.Ngaydi = item.Ngaydi;
                //tourViewModel.Ngayve = item.Ngayve;
                tourViewModel.Lichtrinh = item.Lichtrinh;
                tourViewModel.Hinhanh = item.Hinhanh;
                tourViewModel.Gianguoilon = item.Gianguoilon;
                //tourViewModel.Giatreem = item.Giatreem;
                tourViewModel.TenHDV = item.TenHDV;
                tourViewModel.Mota = item.Mota;
                tourViewModel.Trangthai = item.Trangthai;
                tourViewModel.Songuoi = item.Songuoi;
                tourView.Add(tourViewModel);
            }
            return tourView.AsQueryable();
        }
        public InsertTourCommand SeeTour(int id)
        {
            InsertTourCommand tourViewModel = new InsertTourCommand();
            var item = _db.Tours.FirstOrDefault(n => n.ID == id);
            {
                tourViewModel.ID = item.ID;
                tourViewModel.Code = item.Code;
                tourViewModel.Tentour = item.Tentour;
                tourViewModel.Diadiemkhoihanh = item.Diadiemkhoihanh;
                tourViewModel.Diemden = item.Diemden;
                tourViewModel.Ngaydi = item.Ngaydi;
                tourViewModel.Thoigiandi = item.Thoigiandi;
                //tourViewModel.Ngayve = item.Ngayve;
                //tourViewModel.Lichtrinh = item.Lichtrinh;
                //tourViewModel.Hinhanh = item.Hinhanh;
                tourViewModel.Gianguoilon = item.Gianguoilon;
                //tourViewModel.Giatreem = item.Giatreem;
                tourViewModel.TenHDV = item.TenHDV;
                tourViewModel.Mota = item.Mota;
                tourViewModel.Trangthai = item.Trangthai;
                tourViewModel.Songuoi = item.Songuoi;
                tourViewModel.Thuocmien = item.Thuocmien;
            }
            return tourViewModel;
        }
        public void EditTour(TourViewModel command)
        {
            var checkTour = _db.Tours.FirstOrDefault(n => n.ID == command.ID);
            {
                checkTour.Tentour = command.Tentour;
                checkTour.Diadiemkhoihanh = command.Diadiemkhoihanh;
                checkTour.Diemden = command.Diemden;
                checkTour.Thuocmien = command.Thuocmien;
                checkTour.Songuoi = command.Songuoi;
                checkTour.Gianguoilon = command.Gianguoilon;
                //checkTour.Giatreem = command.Giatreem;
                checkTour.Mota = command.Mota;
                checkTour.Ngaydi = command.Ngaydi;
                //checkTour.Ngayve = command.Ngayve;
                checkTour.TenHDV = command.TenHDV;
                checkTour.Thoigiandi = command.Thoigiandi;
                //checkTour.Trangthai = command.Trangthai;
            }
            _db.SaveChanges();
        }
        public void DeleteTour(InsertTourCommand command)
        {
            var checkTour = _db.Tours.FirstOrDefault(n => n.ID == command.ID);
            _db.Remove(checkTour);
            _db.SaveChanges();
        }
        //public ContractDetailViewModel SeeContractDeTail(int? id)
        //{
        //    var listTravelDb = from c in _db.ContractDetails
        //                       join t in _db.Tours on c.TourId equals t.Id
        //                       join ct in _db.Contracts on c.ContractId equals ct.Id
        //                       join cs in _db.Customers on ct.CustomerId equals cs.Id
        //                       where c.Id == id
        //                       select new { t.Code, c.NameTour, cs.Name, ct.BeginDate, ct.Paid, t.Cost, t.Picture, c.PeopleGo };
        //    var detailBookTour = new ContractDetailViewModel();
        //    foreach (var item in listTravelDb)
        //    {
        //        detailBookTour.Code = item.Code;
        //        detailBookTour.NameTour = item.NameTour;
        //        detailBookTour.NameCustomer = item.Name;
        //        detailBookTour.BeginDate = item.BeginDate;
        //        detailBookTour.Paid = item.Paid;
        //        detailBookTour.Cost = item.Cost;
        //        detailBookTour.Picture = item.Picture;
        //        detailBookTour.PeopleGo = item.PeopleGo;
        //    }
        //    return detailBookTour;
        //}
        //public void DeleteContractDetail(int? id)
        //{
        //    var deleteContractDetail = _db.ContractDetails.FirstOrDefault(n => n.Id == id);
        //    _db.ContractDetails.Remove(deleteContractDetail);
        //    _db.SaveChanges();
        //}
    }
}

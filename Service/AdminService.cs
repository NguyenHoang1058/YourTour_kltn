using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Models.ViewModels;

namespace YourTour.Service
{
    public class AdminService
    {
        private readonly YourTourContext _db;
        private readonly AdminService _adminService;
        public AdminService (YourTourContext db, AdminService adminService)
        {
            this._db = db;
            this._adminService = adminService;
        }

    }
}

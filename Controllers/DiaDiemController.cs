using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YourTour.Models.db;
using YourTour.Service;

namespace YourTour.Controllers
{
    public class DiaDiemController : Controller
    {
        private readonly LocationService _locationService;
        private readonly YourTourContext _db;

        public DiaDiemController(LocationService locationService, YourTourContext db)
        {
            this._locationService = locationService;
            this._db = db;
        }
    }
}

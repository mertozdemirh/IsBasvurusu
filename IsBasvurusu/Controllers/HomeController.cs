using IsBasvurusu.Models;
using IsBasvurusu.Models.data;
using IsBasvurusu.Models.entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IsBasvurusu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UygulamaDbContext _db;

        public HomeController(ILogger<HomeController> logger, UygulamaDbContext db)
        {
            _logger = logger;
           _db = db;
        }

        public IActionResult Index()
        {
            List<SehirlerModel> sehirler = _db.Sehirler.Select(x => new SehirlerModel
            {
                SehirId = x.Id,
                SehirAd = x.Ad,
                SeciliMi = false
            }).ToList();            

            HomeViewModel vm = new HomeViewModel();
            vm.sehirlerModel = sehirler;
            return View(vm);
        }
        [HttpPost,ValidateAntiForgeryToken]
        public IActionResult Index(HomeViewModel viewModel)
        {
            var result = viewModel;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

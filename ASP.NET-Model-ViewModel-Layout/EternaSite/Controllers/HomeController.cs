using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EternaSite.Models;
using System.Linq;
using EternaSite.DAL;
using EternaSite.ViewModels;

namespace EternaSite.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();

            HomeViewModel serviceVM = new HomeViewModel
            {
                Services = services
            };

            return View(serviceVM);
        }

        public IActionResult About()
        {
            return View();
        }



        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Pricing()
        {
            return View();
        }
    }
}

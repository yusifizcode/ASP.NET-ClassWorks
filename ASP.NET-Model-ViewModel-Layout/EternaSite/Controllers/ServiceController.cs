using EternaSite.DAL;
using EternaSite.Models;
using EternaSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaSite.Controllers
{
    public class ServiceController : Controller
    {
        private AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Service> services = _context.Services.ToList();

            ServiceViewModel serviceVM = new ServiceViewModel {
                Services = services
            };
            return View(serviceVM);
        }

        public IActionResult ServiceDetail(int id)
        {

            Service service = _context.Services.FirstOrDefault(x => x.Id == id);

            return View(service);
        }
    }
}

using EternaSite.DAL;
using EternaSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EternaSite.Controllers
{
    public class PortFolioController : Controller
    {
        private AppDbContext _context;

        public PortFolioController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Portfolio()
        {
            PortfolioViewModel portfolioVM = new PortfolioViewModel
            {
                Portfolios = _context.Portfolios.Include(x => x.Category).ToList(),
                Categories = _context.Categories.ToList()
            };

            return View(portfolioVM);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace EternaSite.Controllers
{
    public class PortFolioController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}

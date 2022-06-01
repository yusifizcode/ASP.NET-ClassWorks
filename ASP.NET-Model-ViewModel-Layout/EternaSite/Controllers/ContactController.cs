using Microsoft.AspNetCore.Mvc;

namespace EternaSite.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}

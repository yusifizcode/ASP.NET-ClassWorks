using Microsoft.AspNetCore.Mvc;

namespace EternaSite.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}

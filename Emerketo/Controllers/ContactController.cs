using Microsoft.AspNetCore.Mvc;

namespace Emerketo_webapp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

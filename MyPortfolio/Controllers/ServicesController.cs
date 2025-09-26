using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

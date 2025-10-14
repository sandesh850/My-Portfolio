using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class LogoutController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index","Home");
        }
    }
}

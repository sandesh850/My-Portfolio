using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

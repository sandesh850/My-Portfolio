using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class AddNewProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

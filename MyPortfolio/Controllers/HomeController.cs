using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;  

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View(new ContactViewModel());
        }


        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {

            if(!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }

                
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
using MyPortfolio.Models.ViewModels;  
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        // My DPI
        private readonly AppDb _AppDb;

        public HomeController(ILogger<HomeController> logger, AppDb appDb)
        {
            _logger = logger;
            _AppDb = appDb;
        }


        [HttpGet]
        public IActionResult Index()
        {

            var model = new HomeViewModel
            {
                TblPersonal_Project_Details = _AppDb.TblPersonal_Project_Details.ToList()
            };
            

            return View(model);
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

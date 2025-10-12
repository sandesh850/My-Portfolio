using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class AddNewServicesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddNewServicesViewModel());
        }

        [HttpPost]
        public IActionResult Index(AddNewServicesViewModel model)
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
    }
}

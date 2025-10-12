using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class AddNewProjectsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddNewProjectsViewModel());
        }

        [HttpPost]
        public IActionResult Index(AddNewProjectsViewModel Model)
        {
            if(!ModelState.IsValid)
            {
                return View(Model);
            }
            else
            {
                return RedirectToAction("Index","Home");
            }    
        }
    }
}

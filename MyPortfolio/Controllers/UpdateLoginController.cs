using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class UpdateLoginController : Controller
    {
        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult Index(ExistingAndNewLoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Message", "Please Enter the all details (username/password)");
            }
            else
            {
                ModelState.AddModelError("SuccessMessage", "Login Success");
            }

            return View(model);
        }
    }
}

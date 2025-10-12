using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class AddLoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddLoginViewModel());
        }


        [HttpPost]
        public IActionResult Index(AddLoginViewModel Model)
        {

            if(!ModelState.IsValid)
            {
                return View(Model);
            }
            else if(Model.TbxNewPassword != Model.TbxConfirmPassword)
            {
                ModelState.AddModelError("MsgPasswordChecking", "The password & confirm password do not match");

                return View(Model);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

            
        }
    }
}

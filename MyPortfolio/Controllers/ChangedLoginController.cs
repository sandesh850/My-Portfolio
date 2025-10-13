using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class ChangedLoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ChangeLoginViewModel());
        }

        [HttpPost]
        public IActionResult Index(ChangeLoginViewModel model)
        {
            string? changeUsername = Request.Form["tbxChangeUsername"];
            string? changePassword = Request.Form["tbxchangePassword"];
            string? CMP = Request.Form["tbxCmonfirmPW"];

            if(changeUsername == string.Empty || changePassword == string.Empty || CMP == string.Empty)
            {
                ModelState.AddModelError("ErrorMessage","Please fill all the fields");
            }
            else if(changePassword != CMP)
            {
                ModelState.AddModelError("ConfirmPWAndPWCheckingMessage", "The Password & Confirm Password do not match");
            }
            else
            {
                ModelState.AddModelError("Mgsuccess", "SUCCESS");
                ModelState.AddModelError("Mgsuccess02", "Login Details are successfully updated");
            }

            return View();
        }
    }
}

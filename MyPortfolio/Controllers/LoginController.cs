using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel Model)
        {
            if(Model == null)
            {
                return View("Error");
            }
            else
            {
                Model.TbxUserName = Model.TbxPassword;
                // Clear the previous ModelState for TbxPassword
                ModelState.Remove("TbxUserName"); // removing specific ModelState

               // Removing all ModelStates
               //ModelState.Clear();

                return View(Model);
            }

            
        }
    }
}

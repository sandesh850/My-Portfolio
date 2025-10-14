using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models.ViewModels;
using Microsoft.AspNetCore.Http;

namespace MyPortfolio.Controllers
{
    public class LoginController : Controller
    {
        // DPI
        private readonly AppDb _AppDb;

        public LoginController(AppDb appDb)
        {
            _AppDb = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel Model)
        {
            if(!ModelState.IsValid)
            {
                return View(Model);
            }
            else
            {
                var TblLogin = _AppDb.TblLogins.ToList();

                string? Username = null;
                string? password = null;

                if (TblLogin != null)
                {
                    Username = TblLogin[0].UserName;
                    password = TblLogin[0].Password;
                }

                if(Model.TbxUserName == Username && Model.TbxPassword == password)
                {
                    HttpContext.Session.SetString("Login","true");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("ErrorMg", "Incorrect username or password");
                    return View(Model);
                }

                
            }

                

            ///
            /// The following code is correct, but it used for testing
            ///

            //if (Model == null)
            //{
            //    return View("Error");
            //}
            //else
            //{
            //    Model.TbxUserName = Model.TbxPassword;
            //    // Clear the previous ModelState for TbxPassword
            //    ModelState.Remove("TbxUserName"); // removing specific ModelState

            //    // Removing all ModelStates
            //    //ModelState.Clear();

            //    return View(Model);
            //}


        }
    }
}

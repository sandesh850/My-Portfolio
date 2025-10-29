using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
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

        // dependency injection
        private readonly AppDb _AppDb;

        public UpdateLoginController(AppDb appDb)
        {
            _AppDb = appDb;
        }


        [HttpPost]
        public IActionResult Index(ExistingAndNewLoginViewModel model)
        {
            // This list use to check existing login details with user input details
            List<TblLogin> LstExistingLogin = new List<TblLogin>();



            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Message", "Please Enter the all details (username/password)");
            }
            else
            {
                LstExistingLogin = _AppDb.TblLogins.ToList();

                string? Username = null;
                string? password = null;

                if (LstExistingLogin != null)
                {
                    Username = LstExistingLogin[0].UserName;
                    password = LstExistingLogin[0].Password;
                }

                if(model.current_username  == Username && model.current_password == password)
                {
                    HttpContext.Session.SetString("UpdateModal", "true");
                    ModelState.AddModelError("SuccessMessage", "The details are correct");
                }
                else
                {
                    HttpContext.Session.SetString("UpdateModal", "false");
                    ModelState.AddModelError("Message", "Incorrect Username or Password");
                }

                
            }

            return View(model);
        }
    }
}

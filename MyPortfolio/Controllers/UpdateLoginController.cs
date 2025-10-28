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
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Message", "Please Enter the all details (username/password)");
            }
            else
            {
                model.LstExistingLogin = _AppDb.TblLogins.ToList();

                string? Username = null;
                string? password = null;

                if (model.LstExistingLogin != null)
                {
                    Username = model.LstExistingLogin[0].UserName;
                    password = model.LstExistingLogin[0].Password;
                }

                if(model.current_username  == Username && model.current_password == password)
                {
                    HttpContext.Session.SetString("UpdateModal", "true");
                    ModelState.AddModelError("SuccessMessage", "The details are correct");
                }
                else
                {
                    ModelState.AddModelError("Message", "Incorrect Username or Password");
                }

                
            }

            return View(model);
        }
    }
}

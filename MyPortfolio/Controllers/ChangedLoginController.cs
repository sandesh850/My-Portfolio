using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
using MyPortfolio.Models.ViewModels;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class ChangedLoginController : Controller
    {
        // dependency injection
        private readonly AppDb _AppDb;

        public ChangedLoginController(AppDb appDb)
        {
            _AppDb = appDb;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View(new ChangeLoginViewModel());
        }

        public List<TblLogin>? current_login { get; set; } = new();

        [HttpPost]
        public async Task<IActionResult> Index(ChangeLoginViewModel model,ExistingAndNewLoginViewModel model02)
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

                current_login = _AppDb.TblLogins.ToList();

                current_login[0].UserName = changeUsername;
                current_login[0].Password = changePassword;

                await _AppDb.SaveChangesAsync();
               
                ModelState.AddModelError("Mgsuccess", "SUCCESS");
                ModelState.AddModelError("Mgsuccess02", "Login Details are successfully updated");
            }

            return View();
        }
    }
}

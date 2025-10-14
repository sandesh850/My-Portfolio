using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
using MyPortfolio.Models.ViewModels;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class AddLoginController : Controller
    {
        // dependency injection
        private readonly AppDb _AppDb;

        public AddLoginController(AppDb appDb)
        {
            _AppDb = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddLoginViewModel());
        }


        [HttpPost]
        public async Task<IActionResult> Index(AddLoginViewModel Model)
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
                var TblExisting_detail =  _AppDb.TblLogins.ToList();

                if(TblExisting_detail.Count > 0)
                {
                    ModelState.AddModelError("ErrorMessageIfLoginExist", "You can't add another login");
                    return View(Model);
                }
                else
                {
                    var TblLogin = new TblLogin
                    {
                        UserName = Model.TbxNewUserName,
                        Password = Model.TbxNewPassword,
                    };

                    _AppDb.TblLogins.Add(TblLogin);
                    await _AppDb.SaveChangesAsync();

                    return RedirectToAction("Index", "Home");
                }

                   
            }

            
        }
    }
}

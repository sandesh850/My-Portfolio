using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models.ViewModels;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class AddNewProjectsController : Controller
    {
        //DPI
        private readonly AppDb _AppDb;

        public AddNewProjectsController(AppDb appDb)
        {
            _AppDb = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddNewProjectsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(AddNewProjectsViewModel Model)
        {
            if(!ModelState.IsValid)
            {
                return View(Model);
            }
            else
            {
                var TblPersonalProjectsDetails = new TblPersonal_Project_Details
                {
                    ProjectName = Model.TbxProjectName,
                    ProjectDescription = Model.TbxDescription
                };

                _AppDb.TblPersonal_Project_Details.Add(TblPersonalProjectsDetails);
                await _AppDb.SaveChangesAsync();

                return RedirectToAction("Index","Home");
            }    
        }
    }
}

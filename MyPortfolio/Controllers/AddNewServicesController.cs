using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
using MyPortfolio.Models.ViewModels;
using System.Threading.Tasks;

namespace MyPortfolio.Controllers
{
    public class AddNewServicesController : Controller
    {
        // DPI
        private readonly AppDb _AppDb;

        public AddNewServicesController(AppDb appDb)
        {
            _AppDb = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddNewServicesViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(AddNewServicesViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            else
            {
                byte[]? ImgBytes = null;

                if (model.img != null)
                {
                    using (var inputImg = new MemoryStream())
                    {
                        await model.img.CopyToAsync(inputImg);
                        ImgBytes = inputImg.ToArray();
                    }

                }

                var TblNewServices = new TblServices_Details
                {
                    img = ImgBytes,
                    ServiceName = model.tbxservicename,
                    ServiceDescription = model.tbxService_Description
                };


                _AppDb.TblServices_Details.Add(TblNewServices);
                await _AppDb.SaveChangesAsync();

                return RedirectToAction("Index","Home");
            }    
        }
    }
}

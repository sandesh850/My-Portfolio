using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Data;
using MyPortfolio.Models.EntityModels;
using MyPortfolio.Models.ViewModels;

namespace MyPortfolio.Controllers
{
    public class ServicesController : Controller
    {
        private readonly AppDb _AppDb;

        public ServicesController(AppDb appDb)
        {
            _AppDb = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var servicesModel = new ServicesViewModel
            {
                lst_Services = _AppDb.TblServices_Details.ToList()
            };

            return View(servicesModel);
        }
    }
}

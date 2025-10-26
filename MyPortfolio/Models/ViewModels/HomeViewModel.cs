using MyPortfolio.Models.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class HomeViewModel
    {
        
        public List<TblPersonal_Project_Details> TblPersonal_Project_Details { get; set; } = new ();

    }
}

using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class AddNewServicesViewModel
    {
        [Required(ErrorMessage ="Please Select a Image")]
        public IFormFile? img {  get; set; }

        [Required(ErrorMessage ="Please Enter the Service Name")]
        public string? tbxservicename { get; set; }

        [Required(ErrorMessage ="Please Enter the Description")]
        public string? tbxService_Description { get; set; }
    }
}

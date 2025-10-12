using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class ExistingAndNewLoginViewModel
    {
        [Required(ErrorMessage ="Please Enter the Current Username")]
        public string? current_username {  get; set; }

        [Required(ErrorMessage = "Please Enter the Current Password")]
        public string? current_password { get; set; }

        public string? Message { get; set; }

        public string? SuccessMessage { get; set; }
    }
}

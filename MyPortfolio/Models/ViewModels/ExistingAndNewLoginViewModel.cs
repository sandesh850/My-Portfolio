using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class ExistingAndNewLoginViewModel
    {
        [Required]
        public string? current_username {  get; set; }

        [Required]
        public string? current_password { get; set; }

        public string? Message { get; set; }

        public string? SuccessMessage { get; set; }


       
    }
}

using MyPortfolio.Models.EntityModels;
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

        // This list use to check existing login details with user input details
        public List<TblLogin> LstExistingLogin { get; set; } = new List<TblLogin>();


        [Required]
        public string? New_username { get; set; }

        [Required]
        public string? New_password { get; set; }


    }
}

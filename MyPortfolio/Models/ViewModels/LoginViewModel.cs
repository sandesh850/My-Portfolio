using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please Enter the Username")]
        public string? TbxUserName { get; set; }

        [Required(ErrorMessage ="Please Enter the Password")]
        public string? TbxPassword { get; set; }
    }
}

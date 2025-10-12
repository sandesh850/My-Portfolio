using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class AddLoginViewModel
    {
        [Required(ErrorMessage ="Please Enter the Username")]
        public string? TbxNewUserName { get; set; }

        [Required(ErrorMessage = "Please Enter the Password")]
        public string? TbxNewPassword { get; set; }

        [Required(ErrorMessage = "Please Enter the Confirm Password")]
        public string? TbxConfirmPassword { get; set; }

        public string? MsgPasswordChecking {  get; set; }
    }
}

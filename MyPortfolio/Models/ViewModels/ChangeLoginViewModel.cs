using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class ChangeLoginViewModel
    {
        //[Required]
        //public string? ChangedUsername { get; set; }

        //[Required]
        //public string? ChangedPassword { get; set; }

        //[Required]
        //public string? ChangedConfirmPassword { get; set; }

        public string? ErrorMessage { get; set; }

        public string? ConfirmPWAndPWCheckingMessage { get; set; }

        public string? Mgsuccess { get; set; }


        public string? Mgsuccess02 { get; set; }
    }
}

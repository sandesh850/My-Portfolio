using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please enter the full name")]
        public string? FullName { get; set; }

        [Required(ErrorMessage ="Please enter the contact number")]
        public string? ContactNo { get; set; }

        [Required(ErrorMessage = "Please enter the message")]
        public string? Message { get; set; }
    }
}

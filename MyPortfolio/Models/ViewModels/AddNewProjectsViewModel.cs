using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models.ViewModels
{
    public class AddNewProjectsViewModel
    {
        [Required(ErrorMessage ="Please Enter the Project Name")]
        public string? TbxProjectName { get; set; }

        [Required(ErrorMessage = "Please Enter the Description")]
        public string? TbxDescription { get; set; }


    }
}

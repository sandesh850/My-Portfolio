using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.Models.EntityModels
{
    public class TblPersonal_Project_Details
    {
        [Key]
        public int Id { get; set; }

        [Required,Column(TypeName ="Varchar(100)")]
        public string? ProjectName { get; set; }

        [Required, Column(TypeName = "Varchar(500)")]
        public string? ProjectDescription { get; set; }

    }
}

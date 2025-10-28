using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.Models.EntityModels
{
    public class TblContact
    {
        [Key]
        public int Id { get; set; }

        [Required,Column(TypeName ="Varchar(100)")]
        public string? Full_Name { get; set; }

        [Required,Column(TypeName ="Varchar(20)")]
        public string? ContactNO { get; set; }

        [Required, Column(TypeName = "Varchar(max)")]
        public string? message { get; set; }
    }
}

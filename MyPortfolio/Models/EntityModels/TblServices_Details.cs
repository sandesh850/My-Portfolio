using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.Models.EntityModels
{
    public class TblServices_Details
    {
        [Key]
        public int Id { get; set; }

        [Required,Column(TypeName ="Varbinary(MAX)")]
        public byte[]? img { get; set; }

        [Required,Column(TypeName ="Varchar(100)")]
        public string? ServiceName { get; set; }

        [Required,Column(TypeName ="Varchar(500)")]
        public string? ServiceDescription { get; set; }


    }
}

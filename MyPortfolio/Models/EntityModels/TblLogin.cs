using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPortfolio.Models.EntityModels
{
    public class TblLogin
    {
        [Key]
        public int Id { get; set; }

        [Required,Column(TypeName ="varchar(100)")]
        public string? UserName { get; set; }

        [Required,Column(TypeName ="varchar(10)")]
        public string? Password { get; set; }
    }
}

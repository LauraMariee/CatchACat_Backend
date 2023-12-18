using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class CatTypeDbo
    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string cat_type_name { get; set; }

        [Required]
        [MaxLength(50)]
        public required string weakness { get; set; }

    }
}

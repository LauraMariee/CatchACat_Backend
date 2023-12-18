using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class CatNameDbo
    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Name_EN { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Name_DE { get; set; }

    }
}

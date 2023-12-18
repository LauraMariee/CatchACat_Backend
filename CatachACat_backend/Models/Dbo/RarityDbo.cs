using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class RarityDbo
    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Rarity_Name_EN { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Rarity_Name_DE { get; set; }

    }
}

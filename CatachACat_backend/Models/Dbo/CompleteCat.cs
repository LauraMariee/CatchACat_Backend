using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class CompleteCatDbo
    {
        [Required]
        [Key]
        public required int Id { get; set; }

        [MaxLength(50)]
        public required string model_name { get; set; }

        [MaxLength(50)]
        public required string cat_type_name { get; set; }

        [MaxLength(50)]
        public required string weakness { get; set; }

        [MaxLength(50)]
        public required string name_en { get; set; }

        [MaxLength(50)]
        public required string name_de { get; set; }

        [MaxLength(50)]
        public required string rarity_name_en { get; set; }

        [MaxLength(50)]
        public required string rarity_name_de { get; set; }

    }
}

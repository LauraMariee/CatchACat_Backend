using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class CatDbo
    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required int cat_type_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public required int name_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public required int rarity_ID { get; set; }

        [Required]
        [MaxLength(50)]
        public required string model_name { get; set; }

    }
}

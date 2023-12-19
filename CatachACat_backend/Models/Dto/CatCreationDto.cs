using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dto
{
    public class CatCreationDto
    {
        [Required]
        public required int cat_type_ID { get; set; }

        [Required]
        public required int name_ID { get; set; }

        [Required]
        public required int rarity_ID { get; set; }

        [Required]
        public required string model_name { get; set; }

    }
}

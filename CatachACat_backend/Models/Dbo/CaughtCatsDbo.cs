using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class CaughtCatsDbo

    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required int cat_ID { get; set; }
    }
}

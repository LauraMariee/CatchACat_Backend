using System.ComponentModel.DataAnnotations;

namespace CatachACat_backend.Models.Dbo
{
    public class PlayerDbo
    {
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Player_name { get; set; }
    }
}

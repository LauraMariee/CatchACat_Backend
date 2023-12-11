using System.ComponentModel.DataAnnotations;

namespace CatchACat_backend.Models
{
	public class CatType
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

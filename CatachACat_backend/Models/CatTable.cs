using System.ComponentModel.DataAnnotations;

namespace CatchACat_backend.Models
{
	public class CatTable
	{
        [Key]
        public required int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string CatType { get; set; }

        [Required]
        [MaxLength(50)]
		public required string Nickname { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Rarity { get; set; }

        [Required]
        [MaxLength(50)]
        public required string ModelID { get; set; }

    }
}

using System.Text.Json;
using System.Text.Json.Serialization;

namespace CatchACat_backend.Models
{
	public class CatType
	{
		public required string Id { get; set; }
		public required string Name_EN { get; set; }
		public required string Name_DE { get; set; }

		public override string ToString() => JsonSerializer.Serialize<CatType>(this); 
		//[JsonPropertyName("img")]


	}
}

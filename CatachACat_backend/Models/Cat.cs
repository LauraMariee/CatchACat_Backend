using System.Text.Json;
using System.Text.Json.Serialization;

namespace CatachACat_backend.Models
{
	public class Cat
	{
		public required string Id { get; set; }

		public override string ToString() => JsonSerializer.Serialize<Cat>(this); 
		//[JsonPropertyName("img")]


	}
}

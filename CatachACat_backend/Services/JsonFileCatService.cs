using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CatachACat_backend.Models.Dbo;
using Microsoft.AspNetCore.Hosting;

namespace CatchACat_backend.Services
{
    public class JsonFileCatService(IWebHostEnvironment webHostEnvironment)
	{
		public IWebHostEnvironment WebHostEnvironment { get; } = webHostEnvironment;

		private string JsonFileName
		{
			get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "cat.json"); }
		}

		public IEnumerable<CatTypeDbo> GetProducts()
		{
			using var jsonFileReader = File.OpenText(JsonFileName);
			return JsonSerializer.Deserialize<CatTypeDbo[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = false
				}) ;
		}
	}
}
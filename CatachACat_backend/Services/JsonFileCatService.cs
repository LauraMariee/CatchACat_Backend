using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using CatchACat_backend.Models;
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

		public IEnumerable<CatType> GetProducts()
		{
			using var jsonFileReader = File.OpenText(JsonFileName);
			return JsonSerializer.Deserialize<CatType[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = false
				}) ;
		}
	}
}
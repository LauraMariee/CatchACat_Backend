using CatachACat_backend.Models;
using CatachACat_backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CatachACat_backend.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public JsonFileCatService CatService;

		public IEnumerable<Cat> Cats { get; private set; }

		public IndexModel(ILogger<IndexModel> logger, 
			   JsonFileCatService catService)
		{
			_logger = logger;
			CatService = catService;
		}

		public void OnGet()
		{
			Cats = CatService.GetProducts();
		}
	}
}

using CatchACat_backend.Models;
using CatchACat_backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CatchACat_backend.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		public JsonFileCatService CatService;
		public DatabaseService DatabaseService;

		public IEnumerable<CatType> Cats { get; private set; }

		public IndexModel(ILogger<IndexModel> logger,
               JsonFileCatService catService, DatabaseService databaseService)
        {
            _logger = logger;
            CatService = catService;
			DatabaseService = databaseService;

        }

        public void OnGet()
		{
			Cats = CatService.GetProducts();
		}



    }
}

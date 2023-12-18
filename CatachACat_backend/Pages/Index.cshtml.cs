using CatachACat_backend.api;
using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CatchACat_backend.Pages
{
    public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
        public DatabaseService DatabaseService;

        public IndexModel(ILogger<IndexModel> logger,
               DatabaseService databaseService)
        {
            _logger = logger;
            DatabaseService = databaseService;
        }

        public IEnumerable<CatTypeDbo> Cats { get; private set; }

        public void OnGet()
		{
			
		}



    }
}

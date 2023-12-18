using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatachACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaughtCatsController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/GetCats
        [HttpGet]
        public ActionResult<IEnumerable<CaughtCatsDbo>> GetCats()
        {
            return _context.Caught.ToList();
        }
    }
}

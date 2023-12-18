using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatachACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RarityController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/GetRarity
        [HttpGet]
        public ActionResult<IEnumerable<RarityDbo>> GetCats()
        {
            return _context.Rarity.ToList();
        }
    }
}

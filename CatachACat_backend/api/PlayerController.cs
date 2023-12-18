using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatachACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/Player
        [HttpGet]
        public ActionResult<IEnumerable<PlayerDbo>> GetCats()
        {
            return _context.Player.ToList();
        }
    }
}

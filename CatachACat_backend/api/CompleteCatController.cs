using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatchACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompleteCatController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/GetCats
        [HttpGet]
        public ActionResult<IEnumerable<CompleteCatDbo>> GetCats()
        {
            return _context.CompleteCat.ToList();
        }

        // GET: api/GetCat
        [HttpGet("{id}")]
        public ActionResult<CompleteCatDbo> GetCat(int id)
        {
            var cat = _context.CompleteCat.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return cat;
        }
    }
}

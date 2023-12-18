using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatachACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatTypeController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/GetCats
        [HttpGet]
        public ActionResult<IEnumerable<CatTypeDbo>> GetCats()
        {
            return _context.CatType.ToList();
        }

        // GET: api/GetCat
        [HttpGet("{id}")]
        public ActionResult<CatTypeDbo> GetCat(int id)
        {
            var cat = _context.CatType.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return cat;
        }

        // POST: api/CreateCat
        [HttpPost]
        public ActionResult<CatTypeDbo> CreateCat(CatTypeDbo cat)
        {
            if (cat == null)
            {
                return BadRequest();
            }
            _context.CatType.Add(cat);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCat), new { id = cat.Id }, cat);
        }
    }
}

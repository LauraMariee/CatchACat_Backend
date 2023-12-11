using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatachACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatTableController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/GetCats
        [HttpGet]
        public ActionResult<IEnumerable<CatTable>> GetCats()
        {
            return _context.CatTable.ToList();
        }

        // GET: api/GetCat
        [HttpGet("{id}")]
        public ActionResult<CatTable> GetCat(int id)
        {
            var cat = _context.CatTable.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return cat;
        }

        // POST: api/CreateCat
        [HttpPost]
        public ActionResult<CatTable> CreateCat(CatTable cat)
        {
            if (cat == null)
            {
                return BadRequest();
            }
            _context.CatTable.Add(cat);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCat), new { id = cat.Id }, cat);
        }
    }
}

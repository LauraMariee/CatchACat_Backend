using CatachACat_backend.Models.Dbo;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatchACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatNameController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/GetCats
        [HttpGet]
        public ActionResult<IEnumerable<CatNameDbo>> GetCats()
        {
            return _context.CatName.ToList();
        }

        // GET: api/GetCat
        [HttpGet("{id}")]
        public ActionResult<CatNameDbo> GetCat(int id)
        {
            var cat = _context.CatName.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return cat;
        }

        // POST: api/CreateCat
        [HttpPost]
        public ActionResult<CatTypeDbo> CreateCat(CatNameDbo cat)
        {
            if (cat == null)
            {
                return BadRequest();
            }
            _context.CatName.Add(cat);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCat), new { id = cat.Id }, cat);
        }
    }
}

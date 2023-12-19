using CatachACat_backend.Models.Dbo;
using CatachACat_backend.Models.Dto;
using CatchACat_backend.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatachACat_backend.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/Cat
        [HttpGet]
        public ActionResult<IEnumerable<CompleteCatDbo>> GetCats()
        {
            return _context.CompleteCat.ToList();
        }

        // GET: api/Cat/{index}
        [HttpGet("{id}")]
        public ActionResult<CompleteCatDbo> GetCatByID(int id)
        {
            var cat = _context.CompleteCat.Find(id);
            if (cat == null)
            {
                return NotFound();
            }
            return cat;
        }

        // POST: api/
        [HttpPost]
        public ActionResult<CatDbo> CreateCat([FromForm]CatCreationDto cat)
        {
            if (cat == null)
            {
                return BadRequest();
            }

            CatCreationDto catCreation = cat;
            var newCatData = new CatDbo()
            {
                Id = 0, //Not set anywhere - auto generated
                cat_type_ID = catCreation.cat_type_ID,
                name_ID = catCreation.name_ID,
                rarity_ID = catCreation.rarity_ID,
                model_name = catCreation.model_name,
            }; 

            //send to database
            _context.Cat.Add(newCatData);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCatByID), new { id = newCatData.Id }, newCatData);

        }
    }
}

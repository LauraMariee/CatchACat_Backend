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
        public ActionResult<CompleteCatDbo> CreateCat([FromForm]CatCreationDto cat)
        {
            if (cat == null)
            {
                return BadRequest();
            }

            //get database to create IDs
            //Change catcreationdto to catdbo
            //Save the data in catDBO
            //


            /*send to database
            _context.Cat.Add(cat);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetCatByID), new { id = cat.Id }, cat);
            */
            return null; 
        }
    }
}

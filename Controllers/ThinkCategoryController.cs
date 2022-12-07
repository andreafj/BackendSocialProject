/*using BackendSocialProject.Models.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BackendSocialProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThinkCategoryController : ControllerBase
    {
        private readonly DemoContext _db;
        public ThinkCategoryController(DemoContext db)
        {
            _db= db;
        }

        [HttpGet]
        public async Task<ActionResult> GetCategories()
        {
            var lista = await _db.Categories.OrderBy(c => c.Name).ToListAsync();

            return Ok(lista);
        }

        //Este id tiene que ser el mismo que el del metodo
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var categoryByID = await _db.Categories.FirstOrDefaultAsync(c => c.Id == id);
            if(categoryByID == null)
            {
                return NotFound();
            }
            return Ok(categoryByID);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] Category category)
        {
            if(category == null)
            {
                return BadRequest(ModelState);
            }
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);    
            }

            await _db.Categories.AddAsync(category);
            await _db.SaveChangesAsync();

            return Ok();
        }
    }
}*/

using BackendSocialProject.Models.Data;
using BackendSocialProject.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendSocialProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [ActionName(nameof(GetCategoriesAsync))]
        public IEnumerable<Category> GetCategoriesAsync()
        {
            return _categoryRepository.GetCategories();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetCategoryById))]
        public ActionResult<Category> GetCategoryById(int id)
        {
            var categoryByID = _categoryRepository.GetCategoryById(id);
            if (categoryByID == null)
            {
                return NotFound();
            }
            return categoryByID;
        }

        [HttpPost]
        [ActionName(nameof(CreateCategoryAsync))]
        public async Task<ActionResult<Category>> CreateCategoryAsync(Category category)
        {
            await _categoryRepository.CreateCategoryAsync(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdateCategory))]
        public async Task<ActionResult> UpdateCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            await _categoryRepository.UpdateCategoryAsync(category);

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeleteCategory))]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = _categoryRepository.GetCategoryById(id);
            if (category == null)
            {
                return NotFound();
            }

            await _categoryRepository.DeleteCategoryAsync(category);

            return NoContent();
        }
    }
}

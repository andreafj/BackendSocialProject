using BackendSocialProject.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendSocialProject.Models.Repository
{
    public class CategoryRepository: ICategoryRepository
    {
        protected readonly DemoContext _context;
        public CategoryRepository(DemoContext context) => _context = context;

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }
        public async Task<Category> CreateCategoryAsync(Category category)
        {
            await _context.Set<Category>().AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            _context.Entry(category).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteCategoryAsync(Category category)
        {
            //var entity = await GetByIdAsync(id);
            if (category is null)
            {
                return false;
            }
            _context.Set<Category>().Remove(category);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

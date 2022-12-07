using BackendSocialProject.Models.Data;

namespace BackendSocialProject.Models.Repository
{
    public interface ICategoryRepository
    {
        Task<Category> CreateCategoryAsync(Category category);
        Task<bool> DeleteCategoryAsync(Category category);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetCategories();
        Task<bool> UpdateCategoryAsync(Category category);
    }
}

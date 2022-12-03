using BackendSocialProject.Models.Data;

namespace BackendSocialProject.Models.Repository
{
    public interface IPlantRepository
    {
        Task<Plant> CreatePlantAsync(Plant plant);
        Task<bool> DeletePlantAsync(Plant plant);
        Plant GetPlantById(int id);
        IEnumerable<Plant> GetPlants();
        Task<bool> UpdatePlantAsync(Plant plant);
    }
}

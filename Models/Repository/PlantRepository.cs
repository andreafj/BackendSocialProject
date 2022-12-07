using BackendSocialProject.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace BackendSocialProject.Models.Repository
{
    public class PlantRepository : IPlantRepository
    {
        protected readonly DemoContext _context;
        public PlantRepository(DemoContext context) => _context = context;

        public IEnumerable<Plant> GetPlants()
        {
            return _context.Plants.ToList();
            //return _context.Plants.Include(p=>p.category).ToList();
        }
        public Plant GetPlantById(int id)
        {
            return _context.Plants.Find(id);
        }
        public async Task<Plant> CreatePlantAsync(Plant plant)
        {
            await _context.Set<Plant>().AddAsync(plant);
            await _context.SaveChangesAsync();
            return plant;
        }
        public async Task<bool> UpdatePlantAsync(Plant plant)
        {
            _context.Entry(plant).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeletePlantAsync(Plant plant)
        {
            //var entity = await GetByIdAsync(id);
            if (plant is null)
            {
                return false;
            }
            _context.Set<Plant>().Remove(plant);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}

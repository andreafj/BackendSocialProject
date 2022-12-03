using BackendSocialProject.Models.Data;
using BackendSocialProject.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendSocialProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private IPlantRepository _plantRepository;

        public PlantController(IPlantRepository plantRepository)
        {
            _plantRepository = plantRepository;
        }

        [HttpGet]
        [ActionName(nameof(GetPlantsAsync))]
        public IEnumerable<Plant> GetPlantsAsync()
        {
            return _plantRepository.GetPlants();
        }

        [HttpGet("{id}")]
        [ActionName(nameof(GetPlantById))]
        public ActionResult<Plant> GetPlantById(int id)
        {
            var plantByID = _plantRepository.GetPlantById(id);
            if (plantByID == null)
            {
                return NotFound();
            }
            return plantByID;
        }

        [HttpPost]
        [ActionName(nameof(CreatePlantAsync))]
        public async Task<ActionResult<Plant>> CreatePlantAsync(Plant plant)
        {
            await _plantRepository.CreatePlantAsync(plant);
            return CreatedAtAction(nameof(GetPlantById), new { id = plant.Id }, plant);
        }

        [HttpPut("{id}")]
        [ActionName(nameof(UpdatePlant))]
        public async Task<ActionResult> UpdatePlant(int id, Plant plant)
        {
            if (id != plant.Id)
            {
                return BadRequest();
            }

            await _plantRepository.UpdatePlantAsync(plant);

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ActionName(nameof(DeletePlant))]
        public async Task<IActionResult> DeletePlant(int id)
        {
            var plant = _plantRepository.GetPlantById(id);
            if (plant == null)
            {
                return NotFound();
            }

            await _plantRepository.DeletePlantAsync(plant);

            return NoContent();
        }
    }
}

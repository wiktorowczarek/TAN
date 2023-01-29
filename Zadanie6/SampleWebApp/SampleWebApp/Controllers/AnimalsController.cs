using Microsoft.AspNetCore.Mvc;
using SampleWebApp.Models;
using SampleWebApp.Services;
using System.Threading.Tasks;

namespace SampleWebApp
{
    [Route("api/animals")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {

        private readonly IDatabaseService _dbService;

        public AnimalsController(IDatabaseService dbService)
        {
            _dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetAnimals()
        {
            return Ok(_dbService.GetAnimals());
        }

        [HttpGet("proc")]
        public async Task<IActionResult> GetAnimalsByProc()
        {
            return Ok(await _dbService.GetAnimalsByStoredProcedureAsync());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAnimals()
        {
            return Ok(await _dbService.ChangeAnimalAsync());
        }

        [HttpGet("async")]
        public async Task<IActionResult> GetAnimals2()
        {
            return Ok(await _dbService.GetAnimalsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnimal([FromBody] Animal animal)
        {
            return Ok(await _dbService.CreateAnimal(animal));
        }

        [HttpDelete("{animalID}")]
        public async Task<IActionResult> DeleteAnimal([FromRoute] int animalID)
        {
            return Ok(await _dbService.DeleteAnimal(animalID));
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNet7.Models;
using SuperHeroDotNet7.Services.SuperHeroService;

namespace SuperHeroDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return Ok(superHeroes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleHeroe(int id)
        {
            var hero =  superHeroes.Find(h => h.Id == id);

            if(hero is null) return NotFound("Sorry, but this hero doesn't exist.");

            return Ok(hero);
        }

        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return Ok(superHeroes);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateHero(SuperHero request)
        {
            var hero =  superHeroes.Find(h => h.Id == request.Id);
            if(hero is null) return NotFound("Sorry, but this hero doesn't exist.");

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Name = request.Name;
            hero.Place = request.Place;

            return Ok(superHeroes);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result is null) return NotFound("Hero not found.");

            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNet7.Models;

namespace SuperHeroDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
            {
                new SuperHero{
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                },
                new SuperHero{
                    Id = 2,
                    Name = "Iron Man",
                    FirstName = "Tony",
                    LastName = "Stark",
                    Place = "Malibu"
                }
            };

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
            var hero = superHeroes.Find(h => h.Id == id);
            if (hero is null) return NotFound("Sorry, but this hero doesn't exist.");

            superHeroes.Remove(hero);

            return Ok(superHeroes);
        }
    }
}

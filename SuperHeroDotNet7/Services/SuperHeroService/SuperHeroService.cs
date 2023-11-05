using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNet7.Models;

namespace SuperHeroDotNet7.Services.SuperHeroService
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
    public class SuperHeroService : ISuperHeroService
    {
        public IActionResult AddHero(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public IActionResult DeleteHero(int id)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero> GetAllHeroes()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetSingleHeroe(int id)
        {
            throw new NotImplementedException();
        }

        public IActionResult UpdateHero(SuperHero request)
        {
            var hero = superHeroes.Find(h => h.Id == id);
            if (hero is null) return NotFound("Sorry, but this hero doesn't exist.");

            superHeroes.Remove(hero);

            return superHeroes;
        }
    }
}

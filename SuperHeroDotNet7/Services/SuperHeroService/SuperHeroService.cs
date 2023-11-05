using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNet7.Models;

namespace SuperHeroDotNet7.Services.SuperHeroService
{

    
    public class SuperHeroService : ISuperHeroService
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


        public IActionResult AddHero(SuperHero hero)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(h => h.Id == id);
            if (hero is null) return null;

            superHeroes.Remove(hero);

            return superHeroes;
        }

        public List<SuperHero> GetAllHeroes()
        {
            throw new NotImplementedException();
        }

        public IActionResult GetSingleHeroe(int id)
        {
            throw new NotImplementedException();
        }

        public List<SuperHero>? UpdateHero(SuperHero request)
        {
            var hero = superHeroes.Find(h => h.Id == request.Id);
            if (hero is null) return null;

            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Name = request.Name;
            hero.Place = request.Place;

            return superHeroes;
        }
    }
}

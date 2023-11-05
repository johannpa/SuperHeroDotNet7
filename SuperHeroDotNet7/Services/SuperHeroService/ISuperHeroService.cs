using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNet7.Models;

namespace SuperHeroDotNet7.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        IActionResult GetSingleHeroe(int id);
        IActionResult AddHero(SuperHero hero);
        Task<List<SuperHero>> UpdateHero(int id, SuperHero request);
        Task<List<SuperHero>> DeleteHero(int id);
    }
}

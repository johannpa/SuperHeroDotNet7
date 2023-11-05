using Microsoft.AspNetCore.Mvc;
using SuperHeroDotNet7.Models;

namespace SuperHeroDotNet7.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        IActionResult GetSingleHeroe(int id);
        IActionResult AddHero(SuperHero hero);
        IActionResult UpdateHero(SuperHero request);
        IActionResult DeleteHero(int id);
    }
}

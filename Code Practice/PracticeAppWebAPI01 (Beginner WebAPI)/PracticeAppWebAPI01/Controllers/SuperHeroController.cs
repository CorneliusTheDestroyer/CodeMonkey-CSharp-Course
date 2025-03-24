using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PracticeAppWebAPI01.Data;
using PracticeAppWebAPI01.Entities;

namespace PracticeAppWebAPI01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly DataContext _context;

        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            var heroes = await _context.SuperHeroes.ToListAsync();

            return Ok(heroes);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<SuperHero>> GetHero(int Id)
        {
            var hero = await _context.SuperHeroes.FindAsync(Id);

            if (hero == null)
            {
                return NotFound("Hero not found.");
            }

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero updatedHero)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(updatedHero.Id);

            if (dbHero == null)
            {
                return NotFound("Hero not found.");
            }

            dbHero.Name = updatedHero.Name;
            dbHero.FirstName = updatedHero.FirstName;
            dbHero.LastName = updatedHero.LastName;
            dbHero.Place = updatedHero.Place;

            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int Id)
        {
            var dbHero = await _context.SuperHeroes.FindAsync(Id);

            if (dbHero == null)
            {
                return NotFound("Hero not found.");
            }

            _context.SuperHeroes.Remove(dbHero);

            await _context.SaveChangesAsync();

            return Ok(await _context.SuperHeroes.ToListAsync());
        }
    }
}

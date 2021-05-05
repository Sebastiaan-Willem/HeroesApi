using HeroesApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public class HeroesService : IHeroesService
    {
        private HeroesContext _context;
        public HeroesService(HeroesContext context)
        {
            _context = context;
        }

        public async Task<List<Hero>> GetHeroes()
        {
            return await _context.Heroes.ToListAsync();
        }

        public async Task<Hero> GetHero(int id)
        {
            return await _context.Heroes.FindAsync(id);
        }

        public async Task AddHero(Hero hero)
        {
            await _context.Heroes.AddAsync(hero);
            await _context.SaveChangesAsync();
        }

        public void UpdateHero(Hero hero)
        {
            //no async method for update
            _context.Heroes.Update(hero);
            _context.SaveChangesAsync();
        }

        public void DeleteHero(Hero hero)
        {
            // no async method for delete 
            _context.Heroes.Remove(hero);
            _context.SaveChangesAsync();
        }
    }
}

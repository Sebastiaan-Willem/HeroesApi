using HeroesApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public class SuperPowerService : ISuperPowerService
    {
        private HeroesContext _context;
        public SuperPowerService(HeroesContext context)
        {
            _context = context;
        }

        public async Task<List<SuperPower>> GetSuperPowers()
        {
            return await _context.SuperPowers.ToListAsync();
        }

        public async Task<SuperPower> GetSuperPower(int id)
        {
            return await _context.SuperPowers.FindAsync(id);
        }

        public async Task AddSuperPower(SuperPower superpower)
        {
            await _context.SuperPowers.AddAsync(superpower);
        }

        public void UpdateSuperPower(SuperPower superpower)
        {
            //no async method for update
            _context.SuperPowers.Update(superpower);
        }

        public void DeleteSuperPower(SuperPower superpower)
        {
            // no async method for delete 
            _context.SuperPowers.Remove(superpower);
        }
    }
}

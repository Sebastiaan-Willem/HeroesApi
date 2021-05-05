using HeroesApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi
{
    public class HeroesContext: DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<SuperPower> SuperPowers { get; set; }

        public HeroesContext(DbContextOptions options):base(options)
        {

        }
    }
}

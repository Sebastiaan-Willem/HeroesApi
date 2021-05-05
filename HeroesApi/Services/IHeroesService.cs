using HeroesApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public interface IHeroesService
    {
        Task AddHero(Hero hero);
        void DeleteHero(Hero hero);
        Task<Hero> GetHero(int id);
        Task<List<Hero>> GetHeroes();
        void UpdateHero(Hero hero);
    }
}
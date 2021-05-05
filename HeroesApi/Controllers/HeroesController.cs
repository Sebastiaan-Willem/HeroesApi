using HeroesApi.Entities;
using HeroesApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeroesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController
    {
        private IHeroesService _service;
        public HeroesController(IHeroesService heroesService)
        {
            _service = heroesService;
        }

        [HttpGet]
        public async Task<IEnumerable<Hero>> GetHeroesAsync()
        {
            return await _service.GetHeroes();
        }

        [HttpGet("{id}")]
        public async Task<Hero> GetHeroAsync(int id)
        {
            return await _service.GetHero(id);
        }

        [HttpPost]
        public async Task PostHeroAsync(Hero hero)
        {
            await _service.AddHero(hero); 
        }

        [HttpPut]
        public void PutHero(Hero hero)
        {
            _service.UpdateHero(hero);
        }

        [HttpDelete]
        public void DeleteHero(Hero hero)
        {
             _service.DeleteHero(hero);
        }

    }
}

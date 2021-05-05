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
    public class SuperPowerController
    {
        private ISuperPowerService _service;
        public SuperPowerController(ISuperPowerService superPowerService)
        {
            _service = superPowerService;
        }

        [HttpGet]
        public async Task<IEnumerable<SuperPower>> GetSuperPowersAsync()
        {
            return await _service.GetSuperPowers();
        }

        [HttpGet("{id}")]
        public async Task<SuperPower> GetSuperPowerAsync(int id)
        {
            return await _service.GetSuperPower(id);
        }

        [HttpPost]
        public async Task PostSuperPowerAsync(SuperPower superpower)
        {
            await _service.AddSuperPower(superpower);
        }

        [HttpPut]
        public void PutSuperPower(SuperPower superpower)
        {
            _service.UpdateSuperPower(superpower);
        }

        [HttpDelete]
        public void DeleteHero(SuperPower superpower)
        {
            _service.DeleteSuperPower(superpower);
        }
    }
}

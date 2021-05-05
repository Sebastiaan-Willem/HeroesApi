using HeroesApi.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HeroesApi.Services
{
    public interface ISuperPowerService
    {
        Task AddSuperPower(SuperPower superpower);
        void DeleteSuperPower(SuperPower superpower);
        Task<SuperPower> GetSuperPower(int id);
        Task<List<SuperPower>> GetSuperPowers();
        void UpdateSuperPower(SuperPower superpower);
    }
}
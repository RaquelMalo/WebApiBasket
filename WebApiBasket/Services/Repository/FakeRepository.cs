using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Services.Repository
{
    public class FakeRepository : IRepository
    {
        public Task<IEnumerable<Jugadores>> GetPlayers()
        {
            return null; // Simula error conexión API
        }
    }
}
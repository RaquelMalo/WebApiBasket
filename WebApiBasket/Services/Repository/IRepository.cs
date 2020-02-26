using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Services.Repository
{
    public interface IRepository
    {
        Task<IEnumerable<Jugadores>> GetPlayers();
    }
}

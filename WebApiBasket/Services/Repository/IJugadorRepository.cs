using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiBasket.Domain.Models;
using WebApiBasket.ViewModels;

namespace WebApiBasket.Services.Repository
{
    public interface IJugadorRepository : IEfGenericRepository<Jugadores>
    {
        Task<IEnumerable<Equipos>> TeamList();
    }
}

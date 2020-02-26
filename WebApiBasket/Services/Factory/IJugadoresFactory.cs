using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Services.Factory
{
    public interface IJugadoresFactory
    {
        IEnumerable<Jugadores> ValidPlayers(IEnumerable<Jugadores> jugadores);
    }
}

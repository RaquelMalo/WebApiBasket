using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Services.Persistence
{
    public interface IPersistence
    {
        Task SavePlayersBd(IEnumerable<Jugadores> jugadores);
    }
}

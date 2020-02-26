using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Services.Specification
{
    public class Specification : ISpecification
    {
        public bool IsSatisfiedBy(Jugadores player)
        {
            return (!player.NombreJugador.StartsWith("Z") && !player.NombreJugador.StartsWith("z")) &&
                   (player.Dorsal < 100 && player.Dorsal > -1) &&
                   (player.Pais != "USA") &&
                   (player.Valoracion >= 1 && player.Valoracion <= 10);

        }
    }
}
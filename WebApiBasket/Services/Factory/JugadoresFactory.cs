using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApiBasket.Domain.Models;
using WebApiBasket.Services.Specification;
using WebApiBasket.Transversal.Exceptions;

namespace WebApiBasket.Services.Factory
{
    public class JugadoresFactory : IJugadoresFactory
    {
        private ISpecification _specification;

        public JugadoresFactory(ISpecification specification)
        {
            _specification = specification;
        }

        public IEnumerable<Jugadores> ValidPlayers(IEnumerable<Jugadores> jugadores)
        {
            var jugadoresValidos = new List<Jugadores>();

            try
            {
                foreach(var item in jugadores)
                {
                    if (_specification.IsSatisfiedBy(item))
                    {
                        jugadoresValidos.Add(item);
                    }
                }
            }
            catch(Exception ex)
            {
                throw new FactoryException("Fallo al crear la lista de jugadores válidos", ex);
            }

            return jugadoresValidos;
        }
    }
};
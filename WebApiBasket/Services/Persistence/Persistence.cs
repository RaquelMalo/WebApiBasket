using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using WebApiBasket.Domain;
using WebApiBasket.Domain.Models;
using WebApiBasket.Services.Factory;
using WebApiBasket.Services.Repository;
using WebApiBasket.Transversal.Exceptions;

namespace WebApiBasket.Services.Persistence
{
    public class Persistence : IPersistence
    {
        private IJugadorRepository _repository;
        private IJugadoresFactory _factory;

        public Persistence(IJugadorRepository repository, IJugadoresFactory factory)
        {
            _repository = repository;
            _factory = factory;
        }

        public async Task SavePlayersBd(IEnumerable<Jugadores> jugadores)
        {
            DeleteBd();
            var okPlayers = _factory.ValidPlayers(jugadores);
            try
            {
                foreach (var jugador in okPlayers)
                {
                    await _repository.Insert(jugador).ConfigureAwait(false);
                }
            }
            catch (DbException ex)
            {
                throw new PersistenceException("Excepción al insertar en la BD", ex);
            }
        }

        private void DeleteBd()
        {
            try
            {
                _repository.TruncateDb();
            }
            catch (DbException ex)
            {
                throw new PersistenceException("Excepción al borrar la BD", ex);
            }
        }
    }
}
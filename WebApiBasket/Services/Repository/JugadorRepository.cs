using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApiBasket.Domain.Models;
using WebApiBasket.ViewModels;

namespace WebApiBasket.Services.Repository
{
    public class JugadorRepository : EfGenericRepository<Jugadores>, IJugadorRepository
    {
        /// <summary>
        /// Show all the valid teams: 3 players min and valuation average > 5
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Equipos>> TeamList()
        {
            //Mapper configuration
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Jugadores, JugadorViewModel>());
            var mapper = config.CreateMapper();
            //Get the players from de WebAPI and group by country
            await this.GetAll().ConfigureAwait(false);
            var playersByTeam = from j in DbContext.Jugadores
                group j by new{j.Pais, j.Valoracion} into pais
                select pais;
            var teams = new List<Equipos>();
            foreach (var grupo in playersByTeam)
            {
                var equipo = new Equipos(){Pais = grupo.Key.Pais};
                foreach (var objetoAgrupado in grupo)
                {
                    var player = mapper.Map<JugadorViewModel>(objetoAgrupado);
                    equipo.Jugadores.Add(player);
                }
                teams.Add(equipo);
            }

            return teams;
        }
    }
}
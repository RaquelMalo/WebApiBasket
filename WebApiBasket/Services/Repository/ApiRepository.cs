using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Services.Repository
{
    public class ApiRepository : IRepository
    {
        private const string Url = "https://webbasketapi.azurewebsites.net/api/jugadores";

        public async Task<IEnumerable<Jugadores>> GetPlayers()
        {
            //Read web API
            try
            {
                var miArray = await ApiRequestHelper.GetJsonRequest<List<Jugadores>>(Url).ConfigureAwait(false);
                return miArray;
            }
            catch (Exception ex) //Error API conexión
            {
                return null;
            }
        }
    }
}

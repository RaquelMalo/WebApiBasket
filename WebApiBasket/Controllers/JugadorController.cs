using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using WebApiBasket.Services.Persistence;
using WebApiBasket.Services.Repository;
using WebApiBasket.Transversal.Exceptions;

namespace WebApiBasket.Controllers
{
    public class JugadorController : Controller
    {
        private readonly IJugadorRepository _bdRepository;
        private readonly IRepository _apiRepository;
        private readonly IPersistence _persistence;

        public JugadorController(IJugadorRepository bdRepository, IRepository apiRepository, IPersistence persistence)
        {
            _bdRepository = bdRepository;
            _apiRepository = apiRepository;
            _persistence = persistence;
        }

        public async Task<ActionResult> Index()
        {
            try
            {
                var apiResult = await _apiRepository.GetPlayers().ConfigureAwait(false);
                if (apiResult != null)
                {
                    await _persistence.SavePlayersBd(apiResult).ConfigureAwait(false);
                }

                var validPlayers = await _bdRepository.GetAll().ConfigureAwait(false);
                return Content(JsonConvert.SerializeObject(validPlayers, Formatting.Indented));
            }
            catch (Exception ex)
            {
                throw new ControllerException("Excepción al recuperar los jugadores", ex);
            }
        }

        public async Task<ActionResult> Equipos()
        {
            try
            {
                var validTeams = await _bdRepository.TeamList().ConfigureAwait(false);
                return Content(JsonConvert.SerializeObject(validTeams, Formatting.Indented));
            }
            catch (Exception ex)
            {
                throw new ControllerException("Excepción al recuperar los equipos", ex);
            }
        }
    }
}
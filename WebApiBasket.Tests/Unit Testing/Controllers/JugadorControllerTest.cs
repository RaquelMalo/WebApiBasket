using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiBasket.Controllers;
using WebApiBasket.Services.Factory;
using WebApiBasket.Services.Persistence;
using WebApiBasket.Services.Repository;
using WebApiBasket.Services.Specification;
using WebApiBasket.Transversal.Exceptions;

namespace WebApiBasket.Tests.Unit_Testing.Controllers
{
    [TestClass]
    public class JugadorControllerTest
    {
        private IRepository _apiRepository;
        private IJugadorRepository _bdRepository;
        private IPersistence _persistence;
        private ISpecification _specification;
        private IJugadoresFactory _jugadoresFactory;

        [TestInitialize]
        public void SetupVariables() 
        {
            _bdRepository = new JugadorRepository();
            _specification = new Specification();
            _jugadoresFactory = new JugadoresFactory(_specification);
            _persistence = new Persistence(_bdRepository, _jugadoresFactory);
        }

        [TestMethod]
        public void IndexController()
        {
            //Arrange
            _apiRepository = new ApiRepository();
            var controller = new JugadorController(_bdRepository, _apiRepository, _persistence);
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is Task<ActionResult>);
        }

        [TestMethod]
        public void EquiposController()
        {
            //Arrange
            _apiRepository = new ApiRepository();
            var controller = new JugadorController(_bdRepository, _apiRepository, _persistence);
            //Act
            var result = controller.Equipos();
            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is Task<ActionResult>);
        }
    }
}

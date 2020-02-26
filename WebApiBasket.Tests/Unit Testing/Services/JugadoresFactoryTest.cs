using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiBasket.Domain.Models;
using WebApiBasket.Services.Factory;
using WebApiBasket.Services.Specification;
using WebApiBasket.Transversal.Exceptions;

namespace WebApiBasket.Tests.Unit_Testing.Services
{
    [TestClass]
    public class JugadoresFactoryTest
    {
        private ISpecification _specification;
        private IJugadoresFactory _factory;

        [TestInitialize]
        public void SetupVariables()
        {
            _specification = new Specification();
            _factory = new JugadoresFactory(_specification);
        }

        [TestMethod]
        public void CorrectFactory()
        {
            //Arrange
            var jugadores = new List<Jugadores>
            {
                new Jugadores()
                {
                    Id = 1,
                    NombreJugador = "Daniel",
                    Pais = "GER",
                    Dorsal = 24,
                    Valoracion = 0
                },
                new Jugadores()
                {
                    Id = 2,
                    NombreJugador = "Pau Gasol",
                    Pais = "ESP",
                    Dorsal = 21,
                    Valoracion = 10
                }
            };
            //var expected = new List<Jugadores>
            //{
            //    new Jugadores()
            //    {
            //        Id = 2,
            //        NombreJugador = "Pau Gasol",
            //        Pais = "ESP",
            //        Dorsal = 21,
            //        Valoracion = 10
            //    }
            //};
            //Act
            var validPlayers = _factory.ValidPlayers(jugadores);
            //Assert
            Assert.AreEqual(1, validPlayers.Count());
        }

        [TestMethod]
        public void IncorrectFactory()
        {
            //Arrange
            //Act and Assert
            Assert.ThrowsException<FactoryException>(() => _factory.ValidPlayers(null));
        }
    }
}

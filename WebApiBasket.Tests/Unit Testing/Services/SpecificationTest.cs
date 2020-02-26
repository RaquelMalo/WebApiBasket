using System;
using System.Data.Entity.Core.Common.EntitySql;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApiBasket.Domain.Models;
using WebApiBasket.Services.Specification;

namespace WebApiBasket.Tests.Unit_Testing.Services
{
    [TestClass]
    public class SpecificationTest
    {
        private readonly ISpecification _specification;

        public SpecificationTest()
        {
            _specification = new Specification();
        }

        [TestMethod]
        public void TrueSpecification()
        {
            //Arrange
            var player = new Jugadores(){
                Id = 1,
                NombreJugador = "Pedro",
                Pais = "ESP",
                Dorsal = 49,
                Valoracion = 8.5m};
            //Act and Assert
            Assert.IsTrue(_specification.IsSatisfiedBy(player));
        }

        [TestMethod]
        public void FalseNameSpecification()
        {
            //Arrange
            var player = new Jugadores()
            {
                Id = 1,
                NombreJugador = "Zacarías",
                Pais = "POR",
                Dorsal = 12,
                Valoracion = 7m
            };
            //Act and Assert
            Assert.IsFalse(_specification.IsSatisfiedBy(player));
        }

        [TestMethod]
        public void FalseCountrySpecification()
        {
            //Arrange
            var player = new Jugadores()
            {
                Id = 1,
                NombreJugador = "Smith",
                Pais = "USA",
                Dorsal = 1,
                Valoracion = 9m
            };
            //Act and Assert
            Assert.IsFalse(_specification.IsSatisfiedBy(player));
        }

        [TestMethod]
        public void FalseDorsalSpecification()
        {
            //Arrange
            var player = new Jugadores()
            {
                Id = 1,
                NombreJugador = "Mourihno",
                Pais = "BRA",
                Dorsal = 101,
                Valoracion = 6.5m
            };
            //Act and Assert
            Assert.IsFalse(_specification.IsSatisfiedBy(player));
        }

        [TestMethod]
        public void FalseValuationSpecification()
        {
            //Arrange
            var player = new Jugadores()
            {
                Id = 1,
                NombreJugador = "Daniel",
                Pais = "GER",
                Dorsal = 24,
                Valoracion = 0
            };
            //Act and Assert
            Assert.IsFalse(_specification.IsSatisfiedBy(player));
        }
    }
}

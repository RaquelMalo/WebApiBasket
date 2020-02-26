using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.ViewModels
{
    public class JugadorViewModel
    {
        public string NombreJugador { get; set; }
        public decimal Valoracion { get; set; }
        public int Dorsal { get; set; }
    }
}
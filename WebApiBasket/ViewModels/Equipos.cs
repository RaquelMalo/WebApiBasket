using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.ViewModels
{
    public class Equipos
    {
        public string Pais { get; set; }
        public List<JugadorViewModel> Jugadores { get; set; }
    }
}
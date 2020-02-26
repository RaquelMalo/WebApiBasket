using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiBasket.Domain.Models
{
    public class Jugadores
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string NombreJugador { get; set; }
        public string Pais { get; set; }
        public decimal Valoracion { get; set; }
        public int Dorsal { get; set; }
    }
}
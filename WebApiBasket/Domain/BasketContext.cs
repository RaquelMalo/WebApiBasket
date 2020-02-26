using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using WebApiBasket.Domain.Models;

namespace WebApiBasket.Domain
{
    public class BasketContext :DbContext
    {
        public BasketContext() : base("BasketContext")
        {
        }

        public DbSet<Jugadores> Jugadores { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
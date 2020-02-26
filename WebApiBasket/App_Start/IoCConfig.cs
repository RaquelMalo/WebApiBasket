using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using WebApiBasket.Domain;
using WebApiBasket.Services.Factory;
using WebApiBasket.Services.Persistence;
using WebApiBasket.Services.Repository;
using WebApiBasket.Services.Specification;

namespace WebApiBasket
{
    public class IoCConfig
    {
        public static void RegistrarControllers(ContainerBuilder builder)
        {
            builder.RegisterControllers
                (Assembly.GetExecutingAssembly());
        }

        public static void RegistrarClases(ContainerBuilder builder)
        {
            builder.RegisterType<JugadorRepository>()
                .As<IJugadorRepository>().InstancePerRequest();
            builder.RegisterType<ApiRepository>()
                .As<IRepository>().InstancePerRequest();
            builder.RegisterType<Specification>()
                .As<ISpecification>().InstancePerRequest();
            builder.RegisterType<JugadoresFactory>()
                .As<IJugadoresFactory>().InstancePerRequest();
            builder.RegisterType<Persistence>()
                .As<IPersistence>().InstancePerRequest();
        }

        public static void RegistrarContexto(ContainerBuilder builder)
        {
            builder.Register(z => new BasketContext()).
                InstancePerRequest();
        }
        public static void Configure()
        {
            var builder = new ContainerBuilder();

            RegistrarControllers(builder);
            RegistrarClases(builder);
            RegistrarContexto(builder);

            var contenedor = builder.Build();

            DependencyResolver.SetResolver
                (new AutofacDependencyResolver(contenedor));
        }
    }
}
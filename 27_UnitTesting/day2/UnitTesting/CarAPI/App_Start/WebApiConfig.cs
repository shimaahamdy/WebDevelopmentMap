using CarAPI.Entities;
using CarAPI.Payment;
using CarAPI.Repositories_DAL;
using CarAPI.Services_BLL;
using CarAPI.Unity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace CarAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            GlobalConfiguration.Configuration.Formatters
                   .JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling
                   = ReferenceLoopHandling.Ignore;

            var unityContainer = GetUnityContainer();
            config.DependencyResolver = new UnityResolver(unityContainer);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static IUnityContainer GetUnityContainer()
        {
            var unityContainer = new UnityContainer();
            unityContainer.RegisterType<ICarService, CarService>();
            unityContainer.RegisterType<IOwnerService, OwnerService>();
            unityContainer.RegisterType<ICarsRepository, CarsRepository>();
            unityContainer.RegisterType<IOwnerRepository, OwnerRepository>();
            unityContainer.RegisterType<IPaymentService, CashService>("CashService");
            unityContainer.RegisterType<IPaymentService, CreditCardService>("CreditCardService");
            unityContainer.RegisterType<InMemoryContext>();
            return unityContainer;
        }
    }
}

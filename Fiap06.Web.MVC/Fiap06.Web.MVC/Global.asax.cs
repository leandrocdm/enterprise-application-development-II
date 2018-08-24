using Fiap06.Web.MVC.Persistence;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Fiap06.Web.MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public object Databas { get; private set; }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            Database.SetInitializer(
                new DropCreateDatabaseAlways<PetshopContext>());
        }
    }
}

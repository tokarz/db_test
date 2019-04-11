using EntitiesPractice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EntitiesPractice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            DataBaseCreationActivator.InitializeDb();

            //testowy zapis do bazy!
            EncjeContext context = new EncjeContext();
            context.Users.Add(new Users { Id = 1, Name = "Michał", Password = "DupaDupa" });
            context.SaveChanges();
        }

        


    }
}

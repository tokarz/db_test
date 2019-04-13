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
            using (EncjeContext context = new EncjeContext())
            {
                context.Users.Add(new Users { Id = 1, Name = "Michał", Password = "DupaDupa" });
                context.SaveChanges();
            }

            EncjeContext context2 = new EncjeContext();

            using (DbContextTransaction tran = context2.Database.BeginTransaction())
            {
                try
                {
                    Role rola = new Role { Id = 1, Name = "Admin" };
                    context2.Roles.Add(rola);
                    context2.SaveChanges();
                  
                    context2.Users.Add(new Users { Id = 2, Name = "Maciek", Password = "KupaKupa", Role = rola });
                    context2.SaveChanges();

                    tran.Commit();
                }
                catch (Exception)
                {
                    tran.Rollback();
                }
                

            }

               
        }




    }
}

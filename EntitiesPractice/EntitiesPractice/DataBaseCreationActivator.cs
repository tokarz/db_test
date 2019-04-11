using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntitiesPractice
{
    public class DataBaseCreationActivator
    {
        public static void InitializeDb()
        {
            var context = new EncjeContext();
            var x = context.Database.CreateIfNotExists();
        }
    }
}
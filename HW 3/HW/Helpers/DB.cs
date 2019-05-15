using HW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Helpers
{
    class DB
    {
        public static void Update(GeneralData _generalData)
        {
            Context context = new Context();
            foreach (Station st in _generalData.Stations)
            {
                context.Stations.AddOrUpdate(station => station.Name, st);
            }
            context.SaveChanges();

            foreach (Route rou in _generalData.Routes)
            {
                context.Routes.AddOrUpdate(Route => Route.Name, rou);
            }

            context.SaveChanges();

            foreach (User us in _generalData.Users)
            {
                context.Users.AddOrUpdate(user => user.Login, us);
            }

            context.SaveChanges();
        }
    }
}

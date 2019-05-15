using HW2.Core.transport;
using HW2.Core.user;
using System.Data.Entity;
using static HW2.Core.transport.Route;

namespace HW2.Core
{
    public class Context : DbContext
    {
        public DbSet<Station> Stations { get; set; }

        public DbSet<PathElement> PathElements { get; set; }
        public DbSet<Route> Routes { get; set; }

        public DbSet<User> Users { get; set; }

        public Context()
            // To specify an explicit connection or DB name call the base class constructor
            : base("localsql")
        { }
    }

}

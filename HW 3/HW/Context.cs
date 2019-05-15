﻿using HW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW
{
    class Context : DbContext
    {
        public DbSet<Station> Stations { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<RouteStation> RouteStations { get; set; }

        public Context() : base("Hw3busDB")
        {

        }
    }
}

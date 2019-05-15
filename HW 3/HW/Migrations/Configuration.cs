namespace HW.Migrations
{
    using HW.Helpers;
    using HW.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HW.Context>
    {
        private GeneralData _generalData;
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HW.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            _generalData = Json.Reader();
            DB.Update(_generalData);
            
        }
    }
}

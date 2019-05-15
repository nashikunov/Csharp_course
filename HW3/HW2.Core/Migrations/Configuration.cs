namespace HW2.Core.Migrations
{
    using HW2.Core.json;
    using HW2.Core.transport;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static HW2.Core.transport.Route;

    internal sealed class Configuration : DbMigrationsConfiguration<HW2.Core.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HW2.Core.Context context)
        {
            RoutesWriter.Write();
            RoutesReader.Read();

            ////var school = new Station()
            ////{
            ////    Id = 1,
            ////    Name = "School"
            ////};
            ////var otradnoye = new Station()
            ////{
            ////    Id = 2,
            ////    Name = "Otradnoye"
            ////};
            ////var polyclinic = new Station()
            ////{
            ////    Id = 3,
            ////    Name = "Polyclinic"
            ////};
            ////var polarnaya = new Station()
            ////{
            ////    Id = 4,
            ////    Name = "Polarnaya"
            ////};
            ////var goncharova = new Station()
            ////{
            ////    Id = 5,
            ////    Name = "Goncharova"
            ////};
            ////var sovetskaya = new Station()
            ////{
            ////    Id = 6,
            ////    Name = "Sovetskaya"
            ////};
            ////var mira = new Station()
            ////{
            ////    Id = 7,
            ////    Name = "Mira"
            ////};
            ////var babushkinskaya = new Station()
            ////{
            ////    Id = 8,
            ////    Name = "Babushkinskaya"
            ////};
            ////var hospital = new Station()
            ////{
            ////    Id = 9,
            ////    Name = "Hospital"
            ////};
            ////var nauchnaya = new Station()
            ////{
            ////    Id = 10,
            ////    Name = "Nauchnaya"
            ////};
            ////var yasnaya = new Station()
            ////{
            ////    Id = 11,
            ////    Name = "Yasnaya"
            ////};
            ////var severnaya = new Station()
            ////{
            ////    Id = 12,
            ////    Name = "Severnaya"
            ////};
            ////var tverskaya = new Station()
            ////{
            ////    Id = 13,
            ////    Name = "Tverskaya"
            ////};
            ////var dekabristov = new Station()
            ////{
            ////    Id = 14,
            ////    Name = "Dekabristov"
            ////};
            ////var sviblovo = new Station()
            ////{
            ////    Id = 15,
            ////    Name = "Sviblovo"
            ////};
            ////var sadovaya = new Station()
            ////{
            ////    Id = 16,
            ////    Name = "Sadovaya"
            ////};
            ////var pervomayskaya = new Station()
            ////{
            ////    Id = 17,
            ////    Name = "Pervomayskaya"
            ////};
            ////var institutskaya = new Station()
            ////{
            ////    Id = 18,
            ////    Name = "Institutskaya"
            ////};
            ////var kirpichnaya = new Station()
            ////{
            ////    Id = 19,
            ////    Name = "Kirpichnaya"
            ////};

            //context.Stations.AddOrUpdate(d => d.Id/*, school,
            //    otradnoye,
            //    polyclinic,
            //    polarnaya,
            //    goncharova,
            //    sovetskaya,
            //    mira,
            //    babushkinskaya,
            //    hospital,
            //    nauchnaya,
            //    yasnaya,
            //    severnaya,
            //    tverskaya,
            //    dekabristov,
            //    sviblovo,
            //    sadovaya,
            //    pervomayskaya,
            //    institutskaya,
            //    kirpichnaya*/);

            //// !!!
            //context.SaveChanges();

            ////var route696 = new Route()
            ////{
            ////    Number = 696,
            ////    FirstDeparture = new DateTime().AddHours(5).AddMinutes(30),
            ////    LastDeparture = new DateTime().AddHours(23).AddMinutes(30),
            ////    Interval = 20
            ////};
            ////var route605 = new Route()
            ////{
            ////    Number = 605,
            ////    FirstDeparture = new DateTime().AddHours(6).AddMinutes(30),
            ////    LastDeparture = new DateTime().AddHours(01).AddMinutes(10),
            ////    Interval = 10
            ////};
            ////var route71 = new Route()
            ////{
            ////    Number = 71,
            ////    FirstDeparture = new DateTime().AddHours(7).AddMinutes(5),
            ////    LastDeparture = new DateTime().AddHours(23).AddMinutes(55),
            ////    Interval = 5
            ////};
            ////var route124 = new Route()
            ////{
            ////    Number = 124,
            ////    FirstDeparture = new DateTime().AddHours(12).AddMinutes(0),
            ////    LastDeparture = new DateTime().AddHours(3).AddMinutes(0),
            ////    Interval = 30
            ////};

            //context.Routes.AddOrUpdate(d => d.Number/*, route696,
            //    route605,
            //    route71,
            //    route124*/);

            //// !!!
            //context.SaveChanges();

            ////var route696_1 = new PathElement()
            ////{
            ////    Id = 1,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == school.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route696.Number),
            ////    Distance = 0
            ////};
            ////var route696_2 = new PathElement()
            ////{
            ////    Id = 2,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == otradnoye.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route696.Number),
            ////    Distance = 5
            ////};
            ////var route696_3 = new PathElement()
            ////{
            ////    Id = 3,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == polyclinic.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route696.Number),
            ////    Distance = 6
            ////};
            ////var route696_4 = new PathElement()
            ////{
            ////    Id = 4,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == polarnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route696.Number),
            ////    Distance = 4
            ////};
            ////var route696_5 = new PathElement()
            ////{
            ////    Id = 5,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == goncharova.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route696.Number),
            ////    Distance = 5
            ////};
            ////var route605_6 = new PathElement()
            ////{
            ////    Id = 6,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == otradnoye.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route605.Number),
            ////    Distance = 0
            ////};
            ////var route605_7 = new PathElement()
            ////{
            ////    Id = 7,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == yasnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route605.Number),
            ////    Distance = 8
            ////};
            ////var route605_8 = new PathElement()
            ////{
            ////    Id = 8,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == severnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route605.Number),
            ////    Distance = 3
            ////};
            ////var route605_9 = new PathElement()
            ////{
            ////    Id = 9,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == babushkinskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route605.Number),
            ////    Distance = 6
            ////};
            ////var route605_10 = new PathElement()
            ////{
            ////    Id = 10,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == tverskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route605.Number),
            ////    Distance = 5
            ////};
            ////var route605_11 = new PathElement()
            ////{
            ////    Id = 11,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == dekabristov.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route605.Number),
            ////    Distance = 7
            ////};
            ////var route71_12 = new PathElement()
            ////{
            ////    Id = 12,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == sovetskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 0
            ////};
            ////var route71_13 = new PathElement()
            ////{
            ////    Id = 13,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == polarnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 6
            ////};
            ////var route71_14 = new PathElement()
            ////{
            ////    Id = 14,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == mira.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 3
            ////};
            ////var route71_15 = new PathElement()
            ////{
            ////    Id = 15,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == babushkinskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 5
            ////};
            ////var route71_16 = new PathElement()
            ////{
            ////    Id = 16,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == hospital.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 4
            ////};
            ////var route71_17 = new PathElement()
            ////{
            ////    Id = 17,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == nauchnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 5
            ////};
            ////var route71_18 = new PathElement()
            ////{
            ////    Id = 18,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == sviblovo.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route71.Number),
            ////    Distance = 0
            ////};
            ////var route124_19 = new PathElement()
            ////{
            ////    Id = 19,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == babushkinskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route124.Number),
            ////    Distance = 3
            ////};
            ////var route124_20 = new PathElement()
            ////{
            ////    Id = 20,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == sadovaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route124.Number),
            ////    Distance = 2
            ////};
            ////var route124_21 = new PathElement()
            ////{
            ////    Id = 21,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == pervomayskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route124.Number),
            ////    Distance = 5
            ////};
            ////var route124_22 = new PathElement()
            ////{
            ////    Id = 22,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == institutskaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route124.Number),
            ////    Distance = 3
            ////};
            ////var route124_23 = new PathElement()
            ////{
            ////    Id = 23,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == nauchnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route124.Number),
            ////    Distance = 4
            ////};
            ////var route124_24 = new PathElement()
            ////{
            ////    Id = 24,
            ////    Station = context.Stations.FirstOrDefault(d => d.Id == kirpichnaya.Id),
            ////    Route = context.Routes.FirstOrDefault(d => d.Number == route124.Number),
            ////    Distance = 6
            ////};

            //context.PathElements.AddOrUpdate(d => d.Id/*, route696_1,
            //    route696_2,
            //    route696_3,
            //    route696_4,
            //    route696_5,
            //    route605_6,
            //    route605_7,
            //    route605_8,
            //    route605_9,
            //    route605_10,
            //    route605_11,
            //    route71_12,
            //    route71_13,
            //    route71_14,
            //    route71_15,
            //    route71_16,
            //    route71_17,
            //    route71_18,
            //    route124_19,
            //    route124_20,
            //    route124_21,
            //    route124_22,
            //    route124_23,
            //    route124_24*/);

            //// !!!
            //context.SaveChanges();

            //context.Users.AddOrUpdate(d => d.Id);

            //// !!!
            //context.SaveChanges();
        }
    }
}
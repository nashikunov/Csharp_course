using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using HW2.Core.transport;
using Newtonsoft.Json;
using static HW2.Core.transport.Route;

namespace HW2.Core.json
{
    public class RoutesReader : Reader
    {
        public static void Read()
        {
            var json = ReadFromFile("hw1.json");

            Content content = JsonConvert.DeserializeObject<Content>(json);

            using (var context = new Context())
            {
                //stations.Select(station => new Station()
                //{
                //    Id = station.Id,
                //    Name = station.Name
                //});
                //foreach (var station in stations)
                //{
                //    context.Stations.Add(new Station()
                //    {
                //        Id = station.Id,
                //        Name = station.Name
                //    });
                //}
                //context.SaveChanges();

                context.Stations.AddOrUpdate(d => d.Id, content.Stations.ToArray());
                context.SaveChanges();

                context.Routes.AddOrUpdate(d => d.Id, content.Routes.ToArray());
                context.SaveChanges();

                var array = content.Routes.SelectMany(route => route.Path).ToArray();
                
                context.PathElements.AddOrUpdate(d => d.Id, array);

                context.SaveChanges();

            }
        }
    }
}
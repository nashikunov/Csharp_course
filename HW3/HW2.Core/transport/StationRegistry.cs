using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HW2.Core.transport
{
    public class StationRegistry
    {
        private readonly List<Station> stations;
        private readonly Dictionary<int, List<Route>> stationToRoutes;

        public StationRegistry()
        {
            using (var context = new Context())
            {
                stations = context.Stations.ToList();
                stationToRoutes = new Dictionary<int, List<Route>>();
                foreach (var route in context.Routes.ToList())
                {

                    foreach (var pathElement in route.Path)
                    {
                        Console.WriteLine("CHLEN");
                        if (stationToRoutes.TryGetValue(pathElement.StationId, out List<Route> stationRoute))
                        {
                            stationRoute.Add(route);
                        }
                        else
                        {
                            stationToRoutes.Add(pathElement.StationId, new List<Route>() { route });
                        }
                    }
                }
            }
        }

        public List<Station> GetStations()
        {
            return stations;
        }

        public Station GetStationById(int id)
        {
            return stations.Find(station => station.Id == id);
        }

        public Station GetStationByName(string name)
        {
            return stations.Find(station => station.Name.Equals(name));
        }

        public List<Route> GetRoutesByStation(Station station)
        {
            List<Route> result = new List<Route>();
            Console.WriteLine(stationToRoutes);
            if (stationToRoutes.TryGetValue(station.Id, out result))
            {
                Console.WriteLine("Reult");
                return result;
            }
            else
            {
                Console.WriteLine("null");

                return null;
            }
        }
    }
}

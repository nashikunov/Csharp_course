using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katya
{
    class Program
    {
        
        static void ReadData(out List<Bus> buses, out List<Stop> stops, out List<Distance> distances, out List<Way> ways, out List<Path> pathes)
        {
            /* buses = new List<Bus>();
            stops = new List<Stop>();
            distances = new List<Distance>();
            ways = new List<Way>();
            pathes = new List<Path>();*/

            using (var sr = new StreamReader("Information.txt"))
            {
                buses = new List<Bus>();

                string line;
                string[] parts;

                int count = int.Parse(sr.ReadLine());
                Console.WriteLine(count);

                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var bus = new Bus
                    {
                        Id = int.Parse(parts[0]),
                        BusNumber = parts[1]
                    };
                    buses.Add(bus);
                }

                stops = new List<Stop>();

                count = int.Parse(sr.ReadLine());
                Console.WriteLine(count);
         
                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var stop = new Stop
                    {
                        Id = int.Parse(parts[0]),
                        StopName = parts[1]
                    };
                    stops.Add(stop);
                }

                distances = new List<Distance>();

                count = int.Parse(sr.ReadLine());
                Console.WriteLine(count);

                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var distance = new Distance
                    {
                        Id = int.Parse(parts[0]),
                        Time = int.Parse(parts[1])
                    };
                    distances.Add(distance);
                }

                ways = new List<Way>();

                count = int.Parse(sr.ReadLine());
                Console.WriteLine(count);

                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    List<int> stationsId = new List<int>();
                    for (int m = 1; m < parts.Length; ++m)
                    {
                        stationsId.Add(int.Parse(parts[m]));
                        
                    }
                    var way = new Way
                    {
                        Id = int.Parse(parts[0]),
                        Route = FindStop(stationsId, stops)
                        
                    };
                    ways.Add(way);
                }

                pathes = new List<Path>();

                count = int.Parse(sr.ReadLine());
                Console.WriteLine(count);

                for (int i = 0; i < count; i++)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    List<int> DistancesId = new List<int>();
                    int BusId = int.Parse(parts[0]);
                    int RouteId = int.Parse(parts[1]);
                    
                    for (int m = 4; m < parts.Length; ++m)
                    {
                        DistancesId.Add(int.Parse(parts[m]));
                        
                    }


                    var path = new Path
                    {
                        Bus = FindBus(buses, BusId),
                        StationsName = FindStations(ways, RouteId),
                        Start = DateTime.Parse(parts[2]),
                        Finish = DateTime.Parse(parts[3]),
                        Period = int.Parse(parts[4]),
                        Times = FindDistances(distances, DistancesId)

                    };
                    pathes.Add(path);
                    Console.WriteLine(path.Bus);
                    foreach (var station in path.StationsName)
                    {
                        Console.WriteLine(station);
                    }
                    foreach (var station in path.Times)
                    {
                        Console.WriteLine(station);
                    }
                   
                     
                }
            }
        }

        static List<int> FindDistances(List<Distance> distances, List<int> id)
        {
            List<int> Distance = new List<int>();
            for (int m = 0; m < id.Count; ++m)
            {
                int i = 0;
                while (i < distances.Count && (distances[i].Id != id[m]))
                    i++;
                if (i < distances.Count)
                    Distance.Add(distances[i].Time);
            }
            return Distance;
        }

        static string FindBus(List<Bus> Buses, int id)
        {
            int i = 0;
            while (i < Buses.Count && Buses[i].Id != id)
                i++;
            if (i < Buses.Count)
                return Buses[i].BusNumber;
            return null;
        }

        static List<string> FindStations(List<Way> Ways, int id)
        {
            int i = 0;
            
            while (i < Ways.Count && Ways[i].Id != id)
                i++;
            if (i < Ways.Count)
                return Ways[i].Route;
            return null;
           
        }

        static List<string> FindStop(List<int> StationsId, List<Stop> Stops)
        {
            List<string> NamesOfStops = new List<string>();
            for (int m = 0; m < StationsId.Count; ++m)
            {
                int i = 0;
                while (i < Stops.Count && (Stops[i].Id != StationsId[m]))
                    i++;
                if (i < Stops.Count)
                    NamesOfStops.Add(Stops[i].StopName);
            }
            return NamesOfStops;
        }

        //static Path Find

        static void Main(string[] args)
        {
            ReadData(out var bus, out var stop, out var distance, out var way, out var path);
        }
    }
}

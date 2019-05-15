
using System;
using System.Collections.Generic;
using System.IO;


namespace HomeWork
{
    internal class Program
    {   
        
        public static void Main(string[] args)
        {
            ReadData(out var busses, out var stops, out var routes);
            Program:
                Console.WriteLine("Enter station: ");
                string station = Console.ReadLine();
                List<Route> route = FindRoutes(routes, station);
            
                DateTime Time = DateTime.Now;
            
                int[] Minutes = new int[2*route.Count];

                List<Table> Table = GetTable(out Minutes, route, station, Time);
                        
                Array.Sort(Minutes);


                List<int> MinutesList = ToPutArrayInOrder(Minutes);

                FindAndPrintTable(Table, MinutesList,station);
                
            goto Program;
         
            //Console.ReadLine();
        }
        
        
        static void ReadData(out List<Bus> busses, out List<Stops> stops, out List<Route> routes)
        {
            using (var sr = new StreamReader("BusProgram.txt"))
            {
                busses = new List<Bus>();
                string line;
                string[] parts;
                int count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; ++i)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    var bus = new Bus
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Start = DateTime.Parse(parts[2]),
                        Finish = DateTime.Parse(parts[3]),
                        Interval = int.Parse(parts[4])

                    };
                    busses.Add(bus);
                }
                
                stops = new List<Stops>();
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; ++i)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    List<string> routeStops = new List<string>();
                    for (int m = 0; m < (parts.GetLength(0) - 1); ++m)
                    {
                        string RouteStops;
                        RouteStops = parts[m+1];
                        routeStops.Add(RouteStops);
                    }
                    var stop = new Stops
                    {
                        StopsId = int.Parse(parts[0]),
                        RouteStops = routeStops
                    };
                    stops.Add(stop);
                }
                

                routes = new List<Route>();
                count = int.Parse(sr.ReadLine());
                for (int i = 0; i < count; ++i)
                {
                    line = sr.ReadLine();
                    parts = line.Split(';');
                    int busId = int.Parse(parts[0]);
                    int stopsId = int.Parse(parts[1]);
                    Bus bus = FindBus(busses, busId);
                    Stops stop = FindStops(stops, stopsId);
                    List<int> distances = new List<int>();
                    for (int m = 0; m < (parts.GetLength(0) - 2); ++m)
                    {
                        int distance;
                        distance = int.Parse(parts[m+2]);
                        distances.Add(distance);
                    }
                    var route = new Route
                    {
                        Transport = bus,
                        Way = stop,
                        Distance = distances

                    };
                    routes.Add(route);
                }
            }
        }

        
        static Bus FindBus(List<Bus> Busses, int busid)
        {
            int i = 0;
            while (i < Busses.Count && (Busses[i].Id != busid))
                i++;
            if (i < Busses.Count)
                return Busses[i];
            return null;
        }
        
        
        static Stops FindStops(List<Stops> stops, int stopsId)
        {
            int i = 0;
            while (i < stops.Count && (stops[i].StopsId != stopsId))
                i++;
            if (i < stops.Count)
                return stops[i];
            return null;
        }

        
        static int GetMinutes1(Route route, int i, DateTime time) // едет в конец ->
        {
            int minutes = 0;
            int length = 0;
            

            for (int m = 0; m < i; ++m)
            {
                length += route.Distance[m];
            }
            
            
            bool a = true;
            int HowManyMinutesBeforeLastBus = (time.Hour * 60 + time.Minute - route.Transport.Start.Hour * 60 -
                                               route.Transport.Start.Minute) % route.Transport.Interval;

            if (length < HowManyMinutesBeforeLastBus)
            {
                minutes = route.Transport.Interval - HowManyMinutesBeforeLastBus + length;
                return minutes;
            } 
 
            do
            {
                if ((length - HowManyMinutesBeforeLastBus) >= 0)
                {
                    minutes = length - HowManyMinutesBeforeLastBus;
                    HowManyMinutesBeforeLastBus = HowManyMinutesBeforeLastBus + route.Transport.Interval;
                    
                }
                else
                {
                    a = false;
                }
                
            } while (a == true);
            
            return minutes; 

        }
        
        
        static int GetMinutes2(Route route, int i, DateTime time) // едет в начало  <-
        {
            int minutes = 0;
            int length = 0;
            

            for (int m = i; m < route.Distance.Count; ++m)
            {
                length += route.Distance[m];
            }
            
            
            bool a = true;
            int HowManyMinutesBeforeLastBus = (time.Hour * 60 + time.Minute - route.Transport.Start.Hour * 60 -
                                               route.Transport.Start.Minute) % route.Transport.Interval;

            if (length < HowManyMinutesBeforeLastBus)
            {
                minutes = route.Transport.Interval - HowManyMinutesBeforeLastBus + length;
                return minutes;
            } 
 
            do
            {
                if ((length - HowManyMinutesBeforeLastBus) >= 0)
                {
                    minutes = length - HowManyMinutesBeforeLastBus;
                    HowManyMinutesBeforeLastBus = HowManyMinutesBeforeLastBus + route.Transport.Interval;
                    
                }
                else
                {
                    a = false;
                }
                
            } while (a == true);
            
            return minutes; 

        }

        
        public static List<Table> GetTable(out int[] minutes, List<Route> route, string station, DateTime Time)
        {
            List<Table> Table = new List<Table>();
            int[] Minutes = new int[route.Count * 2];
            
            int index = 0;
            foreach (var Route in route)
            {

                int m = 0;
                int i = 0;
                while (i < Route.Way.RouteStops.Count && (Route.Way.RouteStops[i] != station))
                    i++;
                
                
                int minutes1destination = GetMinutes1(Route, i, Time);
                int minutes2destination = GetMinutes2(Route, i, Time);
                //Table.Add(minutes1destination);
                //Table.Add(minutes2destination);
                var table = new Table
                {
                    BusRoute = Route,
                    Minutes = minutes1destination,
                    DestinationIndex = true
                };
                
                Table.Add(table);
                Minutes[index] = minutes1destination;
                
                
                var table1 = new Table
                {
                    BusRoute = Route,
                    Minutes = minutes2destination,
                    DestinationIndex = false
                };
                
                
                Table.Add(table1);
                Minutes[index + 1] = minutes2destination;
                
                index += 2;                 

            }
            minutes = Minutes;
            return Table;
        }

        
        public static List<int> ToPutArrayInOrder(int[] Minutes)
        {
            List<int> MinutesList = new List<int>();
            int k = Minutes[0];
            for (int i = 0; i < Minutes.Length; ++i)
            {
                if (Minutes[i] == k)
                {
                    if (i == Minutes.Length - 1)
                        MinutesList.Add(k);
                    k = Minutes[i];
                }
                else
                {
                    MinutesList.Add(k);
                    k = Minutes[i];
                }
                if (i == Minutes.Length - 1)
                    MinutesList.Add(k);
                
               
            }
            return MinutesList;
        }
        
        
        static void FindAndPrintTable(List<Table> table, List<int> minute, string station) 
        {
            for (int i = 0; i < minute.Count; ++i)
            {
                
                foreach (var Table in table)
                {
                    if (Table.Minutes == minute[i])
                    {
                        
                        if (Table.DestinationIndex)
                            if (Table.BusRoute.Way.RouteStops[Table.BusRoute.Way.RouteStops.Count - 1] != station)
                            {

                                Console.WriteLine($"{Table.BusRoute.Transport.Name}, " +
                                                  $"destination {Table.BusRoute.Way.RouteStops[Table.BusRoute.Way.RouteStops.Count - 1]}," +
                                                  $" {Table.Minutes} min");
                            }
                        if (Table.DestinationIndex == false)
                            if (Table.BusRoute.Way.RouteStops[0] != station)
                            {
                                Console.WriteLine($"{Table.BusRoute.Transport.Name}, " +
                                                  $"destination {Table.BusRoute.Way.RouteStops[0]}," +
                                                  $" {Table.Minutes} min");
                            }


                    }
                    
                }
               
            }
        }

        
        static List<Route> FindRoutes(List<Route> routes, string Station)
        {
            
            int i = 0;
            int m = 0;
            List<Route> Route = new List<Route>();

            while (i < routes.Count)
            {               
                while (m < routes[i].Way.RouteStops.Count && (routes[i].Way.RouteStops[m] != Station))
                {
                    ++m;
                }
                if ((m < routes[i].Way.RouteStops.Count) && (routes[i].Way.RouteStops[m] == Station))
                {
                    Route.Add(routes[i]);
                    
                }
                m = 0;    
                ++i;

            }
            if (Route.Count == 0)            
                return null;
            
            return Route;

        }
          
    }
} 
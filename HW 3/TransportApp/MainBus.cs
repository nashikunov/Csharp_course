using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public interface IBus
    {
        List<Bus> GetBus(RoutesData route, string station);
    }
   

    public class Data : IBus
    {

        public List<Bus> GetBus(RoutesData route, string station)
        {
            ICalculator _calculator = new SimpleCalculator();
            int Min1;
            int Min2;
            DateTime time = DateTime.Now;
            List<Bus> Busses = new List<Bus>();
            if (station == route.RouteStops[0])
            {
                Min1 = _calculator.GetMinutes(route, route.RouteStops.IndexOf(station), time, true);
                Bus Vehicle1 = new Bus
                {
                    Route = route,
                    Minute = Min1,
                    LastStation = route.RouteStops[route.RouteStops.Count - 1],
                    SelectedStation = station
                };
                Busses.Add(Vehicle1);
            }
            if (station == route.RouteStops[route.RouteStops.Count - 1])
            {
                Min2 = _calculator.GetMinutes(route, route.RouteStops.IndexOf(station), time, false);
                Bus Vehicle2 = new Bus
                {
                    Route = route,
                    Minute = Min2,
                    LastStation = route.RouteStops[0],
                    SelectedStation = station
                };
                Busses.Add(Vehicle2);
            }


            if (station != route.RouteStops[route.RouteStops.Count - 1] && station != route.RouteStops[0])
            {
                Min1 = _calculator.GetMinutes(route, route.RouteStops.IndexOf(station), time, true);
                Min2 = _calculator.GetMinutes(route, route.RouteStops.IndexOf(station), time, false);
                Bus Vehicle1 = new Bus
                {
                    Route = route,
                    Minute = Min1,
                    LastStation = route.RouteStops[route.RouteStops.Count - 1],
                    SelectedStation = station
                };
                Bus Vehicle2 = new Bus
                {
                    Route = route,
                    Minute = Min2,
                    LastStation = route.RouteStops[0],
                    SelectedStation = station
                };
                Busses.Add(Vehicle1);
                Busses.Add(Vehicle2);
            }

            Busses = Busses.OrderBy(Bus => Bus.Minute).ToList();
            return Busses;
        }
    }
}

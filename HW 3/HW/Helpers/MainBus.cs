using HW.Helpers;
using HW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public interface IBus
    {
        List<Bus> GetBus(Route route, string station);
    }


    public class Data : IBus
    {

        public List<Bus> GetBus(Route route, string station)
        {
            ICalculator _calculator = new SimpleCalculator();
            int Min1;
            int Min2;
            DateTime time = DateTime.Now;
            List<Bus> Busses = new List<Bus>();
            List<string> st = new List<string>();
            foreach (var s in route.Stations)
                st.Add(s.Station.Name);
            if (station == route.Stations[0].Station.Name)
            {
                Min1 = _calculator.GetMinutes(route, st.IndexOf(station), time, true);
                Bus Vehicle1 = new Bus
                {
                    Route = route,
                    Minute = Min1,
                    LastStation = st[st.Count - 1],
                    SelectedStation = station
                };
                Busses.Add(Vehicle1);
            }
            if (station == route.Stations[route.Stations.Count - 1].Station.Name)
            {
                Min2 = _calculator.GetMinutes(route, st.IndexOf(station), time, false);
                Bus Vehicle2 = new Bus
                {
                    Route = route,
                    Minute = Min2,
                    LastStation = st[0],
                    SelectedStation = station
                };
                Busses.Add(Vehicle2);
            }


            if (station != st[st.Count - 1] && station != st[0])
            {
                Min1 = _calculator.GetMinutes(route, st.IndexOf(station), time, true);
                Min2 = _calculator.GetMinutes(route, st.IndexOf(station), time, false);
                Bus Vehicle1 = new Bus
                {
                    Route = route,
                    Minute = Min1,
                    LastStation = st[st.Count - 1],
                    SelectedStation = station
                };
                Bus Vehicle2 = new Bus
                {
                    Route = route,
                    Minute = Min2,
                    LastStation = st[0],
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

using System;
using System.Collections.Generic;
using System.Linq;

namespace HW2.Core.transport
{
    public class TimetableCalculator
    {
        private readonly StationRegistry _stationRegistry;

        public TimetableCalculator(StationRegistry stationRegistry)
        {
            _stationRegistry = stationRegistry;
        }

        public List<TimetableRecord> GetTimetableForStation(DateTime time, string stationName)
        {
            using (var context = new Context())
            {
                var station = _stationRegistry.GetStationByName(stationName);
                var routes = _stationRegistry.GetRoutesByStation(station);

                var result = new List<TimetableRecord>();

                if (routes == null) return null;

                var intTime = TimeUtil.ToInt(time);
                foreach (var route in routes)
                {
                    var path = context.Routes.Where(routeC => routeC.Number == route.Number).First().Path;
                    var pathElementIndex = route.FindPathElementIndex(station);
                    var pathElement = path[pathElementIndex];

                    var intTimeFromA = intTime;
                    if (route.IsCorrectionRequiredFromA(pathElement) && intTime < route.GetFirstDepartureFromA(pathElement))
                        intTimeFromA = TimeUtil.PlusOneDayToInt(time);

                    var intTimeFromZ = intTime;
                    if (route.IsCorrectionRequiredFromZ(pathElement) && intTime < route.GetFirstDepartureFromZ(pathElement))
                        intTimeFromZ = TimeUtil.PlusOneDayToInt(time);
                    
                    var lastIndex = path.Count - 1;
                    if (pathElementIndex != lastIndex)
                    {
                        var waitingTime = CalculateWaitingMinutes(
                            intTimeFromA,
                            route.GetFirstDepartureFromA(pathElement),
                            route.GetLastDepartureFromA(pathElement),
                            route.Interval
                        );

                        result.Add(new TimetableRecord(route.Number, _stationRegistry.GetStationById(path[lastIndex].StationId), waitingTime));
                    }

                    var firstIndex = 0;
                    if (pathElementIndex != firstIndex)
                    {
                        var waitingTime = CalculateWaitingMinutes(
                            intTimeFromZ,
                            route.GetFirstDepartureFromZ(pathElement),
                            route.GetLastDepartureFromZ(pathElement),
                            route.Interval
                        );

                        result.Add(new TimetableRecord(route.Number, _stationRegistry.GetStationById(path[firstIndex].StationId), waitingTime));
                    }
                }

                return result;
            }
        }

        private int CalculateWaitingMinutes(int currentTime,
            int firstDeparture,
            int lastDeparture,
            int delay)
        {
            if (firstDeparture < currentTime && currentTime < lastDeparture)
                return (delay - (currentTime - firstDeparture) % delay) % delay;

            var delta = firstDeparture - currentTime;

            if (delta < 0) return 24 * 60 + delta;

            return delta;
        }
    }
}
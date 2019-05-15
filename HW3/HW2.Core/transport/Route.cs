using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace HW2.Core.transport
{
    [Table("Routes")]
    public class Route
    {
        private bool _isInited = false;

        //public Route(int number,
        //    List<PathElement> path,
        //    DateTime firstDeparture,
        //    DateTime lastDeparture,
        //    int interval)
        //{
        //    _isInited = false;
        //    Number = number;
        //    Path = path;

        //    FirstDeparture = firstDeparture;
        //    LastDeparture = lastDeparture;

        //    Interval = interval;
        //}

        public int Id { get; set; }
        public int Number { get; set; }

        public virtual List<PathElement> Path { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime FirstDeparture { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime LastDeparture { get; set; }

        public int Interval { get; set; }

        private int FullInterval { get; set; }

        public int FindPathElementIndex(Station station)
        {
            Init();

            using (var context = new Context())
            {
                return context.Routes.Where(route => route.Number == Number).First().Path.FindIndex(delegate (PathElement pathElement) { return pathElement.StationId.Equals(station.Id); });
            }
        }

        public int GetFirstDepartureFromA(PathElement pathElement)
        {
            Init();
            return TimeUtil.ToInt(FirstDeparture.AddMinutes(pathElement.DistanceFromA));
        }

        public int GetLastDepartureFromA(PathElement pathElement)
        {
            Init();
            var lastDeparture = LastDeparture.AddMinutes(pathElement.DistanceFromA);

            return IsCorrectionRequiredFromA(pathElement)
                ? TimeUtil.PlusOneDayToInt(lastDeparture)
                : TimeUtil.ToInt(lastDeparture);
        }

        public int GetFirstDepartureFromZ(PathElement pathElement)
        {
            Init();
            return TimeUtil.ToInt(FirstDeparture.AddMinutes(FullInterval - pathElement.DistanceFromA));
        }

        public int GetLastDepartureFromZ(PathElement pathElement)
        {
            Init();
            var lastDeparture = LastDeparture.AddMinutes(FullInterval - pathElement.DistanceFromA);

            return IsCorrectionRequiredFromZ(pathElement)
                ? TimeUtil.PlusOneDayToInt(lastDeparture)
                : TimeUtil.ToInt(lastDeparture);
        }

        public bool IsCorrectionRequiredFromA(PathElement pathElement)
        {
            Init();
            var lastTimeInCurrentDay = TimeUtil.ToInt(LastDeparture.AddMinutes(pathElement.DistanceFromA));
            return lastTimeInCurrentDay < GetFirstDepartureFromZ(pathElement);
        }

        public bool IsCorrectionRequiredFromZ(PathElement pathElement)
        {
            Init();
            var lastTimeInCurrentDay =
                TimeUtil.ToInt(LastDeparture.AddMinutes(FullInterval - pathElement.DistanceFromA));
            return lastTimeInCurrentDay < GetFirstDepartureFromZ(pathElement);
        }

        private void Init()
        {
            using (var context = new Context())
            {
                if (_isInited) return;

                _isInited = true;

                var path = context.Routes.Where(route => route.Number == Number).First().Path;

                path[0].DistanceFromA = 0;

                for (var i = 1; i < path.Count; i++)
                {
                    var directPathElement = path[i];
                    var directInterval = directPathElement.Distance;
                    FullInterval = FullInterval + directInterval;

                    directPathElement.DistanceFromA = path[i - 1].DistanceFromA + directInterval;
                }
            }
        }

        public class PathElement
        {
            //public PathElement(int id, Station station, int distance)
            //{
            //    Id = id;
            //    Station = station;
            //    Distance = distance;
            //}

            public int Id { get; set; }
            
            public int StationId { get; set; }

            public int Distance { get; set; }

            [JsonIgnore]
            [ForeignKey("Route")]
            public virtual int RouteId { get; set; }

            [JsonIgnore]
            public virtual Route Route { get; set; }

            [NotMapped]
            internal int DistanceFromA { get; set; }
        }
    }
}
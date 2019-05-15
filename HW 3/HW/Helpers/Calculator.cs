using HW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Helpers
{
    public interface ICalculator
    {
        int GetMinutes(Route route, int i, DateTime time, bool x);
    }

    public class SimpleCalculator : ICalculator
    {
        public int GetMinutes(Route route, int i, DateTime time, bool x)
        {
            int minutes = 0;
            int length = 0;

            if (x)
            {
                length = route.Stations[i].TimeFromFin;
            }

            if (x == false)
            {
                length = route.Stations[i].TimeFromBeg;
            }

            if ((time.Hour > route.Finish.Hour && time.Hour < route.Start.Hour) ||
                (time.Hour == route.Finish.Hour && time.Minute > route.Finish.Minute) ||
                (time.Hour == route.Start.Hour) && (time.Minute < route.Start.Minute))
            {
                int betweenMinutes;
                if (time.Hour > route.Start.Hour)
                {
                    betweenMinutes = (1440 - time.Hour * 60 - time.Minute) + route.Start.Hour * 60 + route.Start.Minute;
                }
                else
                {
                    betweenMinutes = route.Start.Hour * 60 + route.Start.Minute - time.Hour * 60 - time.Minute;
                }
                minutes = length + betweenMinutes;
                return minutes;
            }

            bool a = true;
            int HowManyMinutesBeforeLastBus = (time.Hour * 60 + time.Minute - route.Start.Hour * 60 -
                                               route.Start.Minute) % route.Interval;

            if (length < HowManyMinutesBeforeLastBus)
            {
                minutes = route.Interval - HowManyMinutesBeforeLastBus + length;
                return minutes;
            }

            do
            {
                if ((length - HowManyMinutesBeforeLastBus) >= 0)
                {
                    minutes = length - HowManyMinutesBeforeLastBus;
                    HowManyMinutesBeforeLastBus = HowManyMinutesBeforeLastBus + route.Interval;

                }
                else
                {
                    a = false;
                }

            } while (a == true);

            return minutes;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace hw
{
    public class Bus
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }


        private int interval;
        public int Interval
        {
            get
            {
                return interval;
            }
            set
            {
                if (value == 0)
                    interval = null; //??
                if (value <= GetMinutesBetweenStartAndFinish())
                    interval = value;
                else
                    interval = null; // ???
            }
        } 

        public int GetMinutesBetweenStartAndFinish()
        {
            int minutes;

            if (Start.Hour <= Finish.Hour)
            {
                minutes = Finish.Hour * 60 + Finish.Minute - Start.Hour * 60 - Start.Minute;
                return minutes;
            }
            else
            {
                minutes = (1140 - Start.Hour * 60 - Start.Minute) + (Finish.Hour * 60 + Finish.Minute);
                return minutes;
            }

        }
    }
}
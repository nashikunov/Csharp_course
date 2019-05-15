
using System;



namespace HomeWork
{
    public class Bus
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int Interval { get; set; }

        /*
        private int? interval;
        public int? Interval
        {
            get
            {
                return interval;
            }
            set
            {
                if (value == 0)
                    interval = null; 
                if (value <= GetMinutesBetweenStartAndFinish())
                    interval = value;
                else
                    interval = null; 
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
        } */

    }
}
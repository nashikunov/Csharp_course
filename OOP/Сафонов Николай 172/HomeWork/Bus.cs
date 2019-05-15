
using System;



namespace HomeWork
{
    public class Bus
    {
        public string Name { get; set; }
        public int Id { get; set; }
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
                {
                    Console.WriteLine("Interval input error.");
                    Console.WriteLine("Change value in your text file.");
                    Console.ReadKey();
                    Environment.Exit(0);

                }
                    
                if (value <= GetMinutesBetweenStartAndFinish())
                    interval = value;
                else
                {
                    Console.WriteLine("Interval input error.");
                    Console.WriteLine("Change value in your text file.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                     
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
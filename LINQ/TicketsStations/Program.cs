using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsStations
{
    class Program
    {
        static void Main(string[] args)
        {
            Location locationOne = new Location(1, "School");
            Location locationTwo = new Location(2, "Shop");
            Location locationThree= new Location(3, "Bar");
            Location locationFour = new Location(4, "Park");
            List<Location> locations = new List<Location>();
            locations.Add(locationOne);
            locations.Add(locationTwo);
            locations.Add(locationThree);
            locations.Add(locationFour);

            TrainTicket busOne = new TrainTicket(1, 4, new DateTime(2018, 03, 14, 17, 30, 0), new DateTime(2018, 03, 14, 18, 45, 0));
            TrainTicket busTwo = new TrainTicket(2, 3, new DateTime(2018, 03, 14, 15, 35, 0), new DateTime(2018, 03, 14, 20, 20, 0));
            TrainTicket busThree = new TrainTicket(3, 1, new DateTime(2018, 03, 14, 13, 0, 0), new DateTime(2018, 03, 14, 22, 40, 0));
            List<TrainTicket> buses = new List<TrainTicket>();
            buses.Add(busOne);
            buses.Add(busTwo);
            buses.Add(busThree);
            var sortTrains = from bus in buses
                             where 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsStations
{
    class TrainTicket
    {
        public int DepartureId { get; set; }
        public int ArrivalId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public TrainTicket(int DepartureId, int ArrivalId, DateTime DepartureTime, DateTime ArrivalTime)
        {
            this.DepartureId = DepartureId;
            this.ArrivalId = ArrivalId;
            this.DepartureId = DepartureId;
            this.ArrivalId = ArrivalId;
        }

    }
}

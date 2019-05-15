namespace HW2.Core.transport
{
    public class TimetableRecord
    {
        public TimetableRecord(int routeNumber,
            Station destination,
            int waitintgTime)
        {
            RouteNumber = routeNumber;
            Destination = destination;
            WaitingTime = waitintgTime;
        }

        public int RouteNumber { get; }
        public Station Destination { get; }
        public int WaitingTime { get; }
    }
}
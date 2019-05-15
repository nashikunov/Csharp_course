using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class RoutesData
    {
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int Interval { get; set; }
        public List<string> RouteStops { get; set; }
        public List<int> Distance { get; set; }

    }
}

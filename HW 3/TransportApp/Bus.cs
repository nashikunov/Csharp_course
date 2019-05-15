using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Bus
    {
        public RoutesData Route { get; set; }
        public int Minute { get; set; }
        public string LastStation { get; set; }
        public string SelectedStation { get; set; }

    }
}

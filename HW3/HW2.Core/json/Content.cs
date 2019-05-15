using HW2.Core.transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2.Core.json
{
    class Content
    {
        public Content(List<Station> stations, List<Route> routes)
        {
            Stations = stations;
            Routes = routes;
        }

        public List<Station> Stations { get; set; }
        public List<Route> Routes { get; set; }
    }
}

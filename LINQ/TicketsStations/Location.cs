using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketsStations
{
    class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Location(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}

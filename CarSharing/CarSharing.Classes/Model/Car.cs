using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSharing.Classes.Model
{
    public class Car
    {
        [JsonIgnore]
        public Model Model { get; set; }
        public int ModelId { get; set; }
        public int Rating { get; set; }
        public bool IsAvailable { get; set; }
        public Location Location { get; set; }
        public double FuelLeft { get; set; }
    }
}

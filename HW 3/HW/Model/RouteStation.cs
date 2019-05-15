using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Model
{
    public class RouteStation
    {
        public int Id { get; set; }
        [JsonIgnore]
        public virtual Station Station { get; set; }
        [NotMapped]
        public int StationJsonId { get; set; }
        public int TimeFromBeg { get; set; }
        public int TimeFromFin { get; set; }
    }
}

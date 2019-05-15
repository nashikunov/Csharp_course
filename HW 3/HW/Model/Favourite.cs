using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW.Model
{
    public class Favourite
    {
        public int Id { get; set; }
        [NotMapped]
        public int StationJsonId { get; set; }
        [JsonIgnore]
        public virtual Station Station { get; set; }
        public string Description { get; set; }
    }
}

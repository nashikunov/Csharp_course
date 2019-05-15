using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW.Model
{
    public class Station
    {
        public int Id { get; set; }
        [NotMapped]
        public int StationJsonId { get; set; }
        public string Name { get; set; }
    }
}

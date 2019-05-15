using HW.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    public class Bus
    {
        public Route Route { get; set; }
        public int Minute { get; set; }
        public string LastStation { get; set; }
        public string SelectedStation { get; set; }

    }
}

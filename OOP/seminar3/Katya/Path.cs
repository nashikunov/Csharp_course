using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katya
{
    class Path
    {
        public string Bus { get; set; }
        public List<string> StationsName { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public int Period { get; set; }
        public List<int> Times { get; set; }
    }
}

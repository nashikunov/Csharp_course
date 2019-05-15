using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public interface IRoutesReader
    {
        List<RoutesData> JsonReader();
    }

    public class SimpleReader : IRoutesReader
    {
        public List<RoutesData> JsonReader()
        {
            JsonSerializer js = new JsonSerializer();
            List<RoutesData> UpdRoutes;
            using (StreamReader sr = new StreamReader("../../Busses.json"))
            {
                using (JsonTextReader jtr = new JsonTextReader(sr))
                {
                    UpdRoutes = js.Deserialize<List<RoutesData>>(jtr);
                }
            }           
            return UpdRoutes;
        }
    }
}

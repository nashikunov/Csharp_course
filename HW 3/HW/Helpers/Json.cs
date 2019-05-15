using HW.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HW.Helpers
{
    class Json
    {
        public static GeneralData Reader()
        {
            GeneralData _generalData;
            JsonSerializer js = new JsonSerializer(); //// Мне пришлось написать полностью путь к файлу, иначе прога не находит этот файл... 

            using (StreamReader sr = new StreamReader("C:/Users/A001/Desktop/HW/HW/Data/Info.json"))
            {
                using (JsonTextReader jtr = new JsonTextReader(sr))
                {
                    _generalData = js.Deserialize<GeneralData>(jtr);
                }
            }
            foreach (var route in _generalData.Routes)
                foreach (var st in route.Stations)
                {
                    st.Station = _generalData.Stations.First(s => s.StationJsonId == st.StationJsonId);

                }


            foreach (var user in _generalData.Users)
                foreach (var fav in user.Favourites)
                {
                    fav.Station = _generalData.Stations.First(s => s.StationJsonId == fav.StationJsonId);
                }
            return _generalData;
        }

        public static void Writer(GeneralData _generalData)
        {
            JsonSerializer js = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("C:/Users/A001/Desktop/HW/HW/Data/test.json"))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    js.Serialize(jtw, _generalData);
                }
            }
        }
    }
}

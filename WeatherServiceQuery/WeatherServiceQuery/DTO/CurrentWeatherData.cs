using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherServiceQuery.DTO
{
    class CurrentWeatherData
    {
        [JsonProperty("main")]
        public MainData Main { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

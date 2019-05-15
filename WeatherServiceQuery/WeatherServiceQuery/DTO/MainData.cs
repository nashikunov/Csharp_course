using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherServiceQuery.DTO
{
    class MainData
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        [JsonProperty("pressure")]
        public double Pressure { get; set; }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using WeatherServiceQuery.DTO;

namespace WeatherServiceQuery
{
	class Program
    {
		// INSERT YOUR OPENWEATHERMAP KEY BEFORE RUNNING THE PROGRAM
		const string AppId = "";

        static string BuildUrl(string baseUrl, IDictionary<string, string> parameters) {
            var sb = new StringBuilder(baseUrl);
            if (parameters?.Count > 0) {
                sb.Append('?');
                foreach (var p in parameters) {
                    sb.Append(p.Key);
                    sb.Append("=");
                    sb.Append(WebUtility.UrlEncode(p.Value));  // This is the important part - percent-encoding
                    sb.Append('&');
                }
                sb.Remove(sb.Length - 1, 1);    // Remove the last '&'
            }
            return sb.ToString();
        }

        static string MakeQuery(string city)
        {
            // Simple option
            // return $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={AppId}&units=metric";

            // A better option:
            return BuildUrl("http://api.openweathermap.org/data/2.5/weather", new Dictionary<string, string>
            {
                {"q", city },
                {"units", "metric" },
                {"appid", AppId }
            });
        }        

        static CurrentWeatherData GetWeather(string city)
        {
			using (var client = new HttpClient())
			{
				string result = client.GetStringAsync(MakeQuery(city)).Result;  // Blocking call!
				return JsonConvert.DeserializeObject<CurrentWeatherData>(result);
			}			
        }
        
        static void Main(string[] args)
        {
            Console.Write("Enter city name: ");                
            var city = Console.ReadLine();
            try
            {
                var weatherData = GetWeather(city);
                if (weatherData != null)
                    Console.WriteLine("Temp = {0}", weatherData.Main.Temp);
                else
                    Console.WriteLine("No data returned");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }            
        }
    }
}

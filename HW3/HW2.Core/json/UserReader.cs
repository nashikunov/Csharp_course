using System.Collections.Generic;
using HW2.Core.user;
using Newtonsoft.Json;

namespace HW2.Core.json
{
    public class UserReader : Reader
    {
        public static List<User> Read()
        {
            var json = ReadFromFile("../../../users.json");

            return JsonConvert.DeserializeObject<List<User>>(json);
        }
    }
}
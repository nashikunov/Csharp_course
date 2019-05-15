using System.Collections.Generic;
using HW2.Core.user;
using Newtonsoft.Json;

namespace HW2.Core.json
{
    public class UserWriter : Writer
    {
        public static void Write(List<User> users)
        {
            var json = JsonConvert.SerializeObject(users);

            WriteToFile("users.json", json);
        }
    }
}
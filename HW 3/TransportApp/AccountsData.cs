using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public class AccountsData
    {
        public string Login { get; set; }
        public string SecurityPassword { get; set; }
        public List<FavouriteData> FavRoutes { get; set; }
      
    }
    
}

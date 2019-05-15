using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportApp
{
    public interface IAccounts
    {
        List<AccountsData> DataUpd(List<AccountsData> Accounts);
    }

    public class JsonReading : IAccounts
    {
        public List<AccountsData> DataUpd(List<AccountsData> Accounts)
        {
            JsonSerializer js = new JsonSerializer();
            using (StreamWriter sw = new StreamWriter("../../accounts.json"))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    js.Serialize(jtw, Accounts);
                }
            }

            List<AccountsData> UpdAccounts;
            using (StreamReader sr = new StreamReader("../../accounts.json"))
            {
                using (JsonTextReader jtr = new JsonTextReader(sr))
                {
                    UpdAccounts = js.Deserialize<List<AccountsData>>(jtr);
                }
            }
            return UpdAccounts;
        }
    }
}

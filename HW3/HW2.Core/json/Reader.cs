using System.IO;

namespace HW2.Core.json
{
    public class Reader
    {
        protected static string ReadFromFile(string fileName)
        {
            var reader = new StreamReader(fileName);
            var json = reader.ReadLine();
            return json;
        }
    }
}
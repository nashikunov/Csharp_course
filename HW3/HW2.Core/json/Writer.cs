using System.IO;

namespace HW2.Core.json
{
    public class Writer
    {
        protected static void WriteToFile(string fileName, string json)
        {
            var file = new FileStream(fileName, FileMode.Create);
            var writer = new StreamWriter(file);
            writer.Write(json);
            writer.Close();
        }
    }
}
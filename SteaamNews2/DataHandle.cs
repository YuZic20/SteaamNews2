using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteaamNews2
{
    static public class DataHandle
    {
        static string path = Directory.GetCurrentDirectory() + @"\AppIDsData.txt";
        static public void SaveIds(List<int> IDs)
        {
            string json = JsonConvert.SerializeObject(IDs);
            System.IO.File.WriteAllText(path, json);
        }
        static public List<int> LoadIds()
        {
            List<int> Ids = new List<int>();
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                Ids = JsonConvert.DeserializeObject<List<int>>(text);
            }    


            return Ids;
        }
    }
}

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryJson
{
    internal class jsonInventoryMain
    {
        InventoryModel model = new InventoryModel();
        List<InventoryModel> list = new List<InventoryModel>();
        public void convert(string jFilePath)
        {
            using(StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
                foreach(var objects in items)
                {
                    Console.WriteLine(objects.Name + " " + objects.Price + " " + objects.Weight);
                }
            }
        }
    }
}

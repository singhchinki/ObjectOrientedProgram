using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccountMangement
{
    internal class StockInventoryMain
    {
        StockModel model = new StockModel();
        List<StockModel> list = new List<StockModel>();
        public void jsonConvert(string jFilePath)
        {
            using(StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var item = JsonConvert.DeserializeObject<List<StockModel>>(json);
                double TotalSstockValue = 0;
                foreach (var objects in item)
                {
                    double totalvalue = objects.NoOfShare * objects.SharePrice;
                    Console.WriteLine(objects.StockName + " " + objects.NoOfShare + " " + objects.SharePrice + " " + totalvalue);
                    TotalSstockValue += totalvalue;
                }
                Console.WriteLine("Total stock value is " + TotalSstockValue);
            }
        }
    }
}

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
        List<InventoryModelSecond> Rice;
        List<InventoryModelSecond> Wheat;
        List<InventoryModelSecond> Pulses;
        public void convert(string jFilePath)
        {
            using(StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                InventoryModel items = JsonConvert.DeserializeObject<InventoryModel>(json);
                Rice = items.Rice;
                Wheat = items.Wheat;
                Pulses = items.Pulses;
               Console.WriteLine("1.Rice\n2.Wheat\n3.Pulses");
               Console.WriteLine("Enter the option");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        foreach (var contact in Rice) Console.WriteLine(contact.Name + " -> " + contact.Price + " -> " + contact.Weight);
                        break;
                        case 2:
                        foreach (var contact in Wheat) Console.WriteLine(contact.Name + " -> " + contact.Price + " -> " + contact.Weight);
                        break;
                    case 3:
                        foreach (var contact in Pulses) Console.WriteLine(contact.Name + " -> " + contact.Price + " -> " + contact.Weight);
                        break;
                        default:
                        Console.WriteLine("Enter valid option");
                        break;

                }

            }
        }
    }
}

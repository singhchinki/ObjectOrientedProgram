using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryJson
{
    internal class InventoryModel
    {
        public List<InventoryModelSecond> Rice {get; set;}
        public List<InventoryModelSecond> Wheat { get; set; }
        public List<InventoryModelSecond> Pulses { get; set; }

    }
}

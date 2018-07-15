using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Item
    {
        public string Name { get; set; }
        public double ItemWeight { get; set; }
        public ItemCategory ItemType { get; set; }
    }
}

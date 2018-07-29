using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.BL;

namespace ObserverPattern
{
    class Order
    {
        public Beverage coffee = null;
        public string OrderName = string.Empty;
        public Order(string ordername,Beverage drink)
        {
            this.OrderName = ordername;
            this.coffee = drink;
        }
    }
}

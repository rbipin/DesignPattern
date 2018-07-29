using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.BL
{
    public abstract class Condiments : Beverage
    {
        public abstract new void AddIngridents(string itemName);

    }
}

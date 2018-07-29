using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.BL
{
    /// <summary>
    /// This is the base class of the decorator
    /// </summary>
    public abstract class Condiments : Beverage
    {
        public abstract new void AddIngridents(string itemName);

    }
}

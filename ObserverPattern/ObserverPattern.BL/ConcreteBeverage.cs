using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.BL
{
    public class ConcreteBeverage : Beverage
    {
        decimal itemPrice = 0;
        public ConcreteBeverage(Size drinkSize, string item,decimal itemPrice)
        {
            this.SetSize(drinkSize);
            AddIngridents(item);
            this.itemPrice = itemPrice;
        }

        public override decimal Cost()
        {
            return itemPrice;
        }
    }
}

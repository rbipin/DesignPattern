using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Context
    {
        IStrategy_Shipping shippingMethod = null;
        
        public void SetStrategy(IStrategy_Shipping newShippingMethod)
        {
            this.shippingMethod = newShippingMethod;
        }

        public void PrintShippingMethod()
        {
            Console.WriteLine(this.shippingMethod.PrintShippingMethod());
        }

        public void PrintShippingCost(List<Item> shippingItems)
        {
            Console.WriteLine(this.shippingMethod.CalculateShippingCost(shippingItems));
        }

    }
}

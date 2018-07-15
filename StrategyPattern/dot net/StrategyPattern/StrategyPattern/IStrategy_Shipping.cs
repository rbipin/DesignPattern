using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    interface IStrategy_Shipping
    {
        string PrintShippingMethod();
        decimal CalculateShippingCost(List<Item> ShippingItem);
    }
}

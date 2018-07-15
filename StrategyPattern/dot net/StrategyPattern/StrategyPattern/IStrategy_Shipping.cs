using System.Collections.Generic;

namespace StrategyPattern
{
    interface IStrategy_Shipping
    {
        string PrintShippingMethod();
        decimal CalculateShippingCost(List<Item> ShippingItem);
    }
}

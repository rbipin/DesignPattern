using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    class StrategyConcrete_FedexGroundShipping: IStrategy_Shipping
    {
        const decimal defaultCost = 10;
        public decimal CalculateShippingCost(List<Item> shippingItems)
        {
            decimal itemCatPrice = 0;
            if (shippingItems == null || shippingItems.Count == 0)
            {
                throw new Exception("No items found");
            }

            itemCatPrice = (from item in shippingItems
                            select GetItemCategoryPrice(item.ItemType)).Sum();

            return defaultCost + itemCatPrice;
        }

        private decimal GetItemCategoryPrice(ItemCategory itmCat)
        {
            switch (itmCat)
            {
                case ItemCategory.Documents:
                    return Convert.ToDecimal(3.15);
                case ItemCategory.Electronics:
                    return Convert.ToDecimal(5.20);
                case ItemCategory.Fragile:
                    return Convert.ToDecimal(7.30);
                default:
                    return Convert.ToDecimal(10);
            }
        }


        public string PrintShippingMethod()
        {
            return "FEDEX Ground Shipping";
        }
    }
}

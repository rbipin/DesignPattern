using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyConcrete_USPSShipping : IStrategy_Shipping
    {
        const decimal defaultCost = 3;
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
                    return 1;
                case ItemCategory.Electronics:
                    return Convert.ToDecimal(2.20);
                case ItemCategory.Fragile:
                    return Convert.ToDecimal(3.30);
                default:
                    return Convert.ToDecimal(4);
            }
        }

        public string PrintShippingMethod()
        {
            return "USPS Shipping";
        }
    }
}

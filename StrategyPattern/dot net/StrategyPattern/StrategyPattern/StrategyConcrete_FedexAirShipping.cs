﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategyPattern
{
    class StrategyConcrete_FedexAirShipping: IStrategy_Shipping
    {
        const decimal defaultCost = 100;
        
        public decimal CalculateShippingCost(List<Item> shippingItems)
        {
            decimal itemCatPrice = 0;
            if (shippingItems ==null || shippingItems.Count==0)
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
                    return 10;
                case ItemCategory.Electronics:
                    return Convert.ToDecimal(15.20);
                case ItemCategory.Fragile:
                    return Convert.ToDecimal(20.30);
                default:
                    return Convert.ToDecimal(50);
            }
        }


        public string PrintShippingMethod()
        {
            return "FEDEX Air Shipping";
        }
    }
}

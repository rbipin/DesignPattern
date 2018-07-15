using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> shippingItems = new List<Item>();
            shippingItems.Add(new Item { Name="Some Documents",ItemWeight=0.5,ItemType=ItemCategory.Documents });
            shippingItems.Add(new Item { Name = "Sony Viao Laptop", ItemWeight = 3, ItemType = ItemCategory.Electronics });
            shippingItems.Add(new Item { Name = "Flower Vace", ItemWeight = 5, ItemType = ItemCategory.Fragile });

            Context ctx = new Context();
            ctx.SetStrategy(new StrategyConcrete_USPSShipping());
            ctx.PrintShippingMethod();
            ctx.PrintShippingCost(shippingItems);

            ctx.SetStrategy(new StrategyConcrete_FedexGroundShipping());
            ctx.PrintShippingMethod();
            ctx.PrintShippingCost(shippingItems);

            ctx.SetStrategy(new StrategyConcrete_FedexAirShipping());
            ctx.PrintShippingMethod();
            ctx.PrintShippingCost(shippingItems);

            Console.ReadKey();
        }
    }
}

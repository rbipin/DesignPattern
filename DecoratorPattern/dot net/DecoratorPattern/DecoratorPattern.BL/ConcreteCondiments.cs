using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.BL
{
    public class ConcreteCondiments : Condiments
    {
        decimal itemPrice;
        Beverage drink = null;
        public ConcreteCondiments(Beverage drink,string itemName,decimal price)
        {
            this.drink = drink;
            this.itemPrice = price;
            AddIngridents(itemName);
        }
        public override decimal Cost()
        {
            return drink.Cost() + this.itemPrice;
        }

        public override void AddIngridents(string condimentItem)
        {
            this.ingrident = condimentItem + "- C"; 
        }

        public override List<string> GetIngridents()
        {
            List<string> ing = new List<string>();
            ing.AddRange(drink.GetIngridents());
            ing.Add(this.ingrident);
            return ing;
        }
    }
}

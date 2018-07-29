using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.BL
{
    public abstract class Beverage
    {
       public enum Size { TALL, GRANDE, VENTI};
        Size drinkSize = Size.TALL;
        public string ingrident = string.Empty;

        /// <summary>
        /// calculate cost
        /// </summary>
        /// <returns></returns>
        public abstract decimal Cost();

        /// <summary>
        /// set size of drink
        /// </summary>
        /// <param name="drinkSize"></param>
        public void SetSize(Size drinkSize)
        {
            this.drinkSize = drinkSize;
        }

        /// <summary>
        /// Return the size of the drink
        /// </summary>
        /// <returns></returns>
        public Size GetSize()
        {
            return this.drinkSize;
        }

        /// <summary>
        /// Return the ingridents in coffee
        /// </summary>
        /// <returns></returns>
        public virtual List<string> GetIngridents()
        {
            return new List<string> { this.ingrident };
        }

        public virtual void AddIngridents(string drinkIngridents)
        {
            this.ingrident = drinkIngridents;
        }

    }
}

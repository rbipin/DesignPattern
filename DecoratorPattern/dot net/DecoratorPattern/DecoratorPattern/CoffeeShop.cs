using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObserverPattern.BL;

namespace ObserverPattern
{
    public partial class CoffeeShop : Form
    {
        decimal condimentPrice = 0;
        decimal coffeePrice = 0;
        decimal sizePrice = 0;
        Beverage.Size drinkSize = Beverage.Size.TALL;
        Order coffeeOrder = null;
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void cmdCoffee_Click(object sender, EventArgs e)
        {
            GetPrice();
            if (!string.IsNullOrEmpty(txtOrderName.Text))
            {
                ConcreteBeverage coffeeBeverage = new ConcreteBeverage(drinkSize, lstCoffee.SelectedItem.ToString(), coffeePrice+sizePrice);
                if (coffeeOrder==null)
                    coffeeOrder = new Order(txtOrderName.Text, coffeeBeverage);
            }
            UpdateOrder(coffeeOrder);
        }

        private void GetPrice()
        {
            switch(lstSize.SelectedIndex)
            {
                case 0:
                    sizePrice = 0.10m;
                    drinkSize = Beverage.Size.TALL;
                    break;
                case 1:
                    sizePrice = 0.20m;
                    drinkSize = Beverage.Size.GRANDE;
                    break;
                case 2:
                    sizePrice = 0.30m;
                    drinkSize = Beverage.Size.VENTI;
                    break;
                default:
                    sizePrice = 0.10m;
                    drinkSize = Beverage.Size.TALL;
                    break;
            }

            switch(lstCoffee.SelectedIndex)
            {
                case 0:
                    coffeePrice = 5.25m;
                    break;
                case 1:
                    coffeePrice = 4.30m;
                    break;
                case 2:
                    coffeePrice = 3.15m;
                    break;
                case 3:
                    coffeePrice = 1m;
                    break;
                default:
                    coffeePrice = 0m;
                    break;
            }
            
            switch(lstCondiments.SelectedIndex)
            {
                case 0:
                    condimentPrice = 1.50m;
                    break;
                case 1:
                    condimentPrice = 1.00m;
                    break;
                case 2:
                    condimentPrice = 0.50m;
                    break;
                case 3:
                    condimentPrice = 0.25m;
                    break;
                case 4:
                    condimentPrice = 0.15m;
                    break;
                case 5:
                    condimentPrice = 0.10m;
                    break;
                default:
                    condimentPrice = 0.10m;
                    break;
            }
        }

        private void cmdCondiments_Click(object sender, EventArgs e)
        {
            GetPrice();
            string condiment = lstCondiments.SelectedItem.ToString();
            if (coffeeOrder.coffee!=null)
            {
                ConcreteCondiments con = new ConcreteCondiments(coffeeOrder.coffee, condiment, condimentPrice+sizePrice);
                coffeeOrder.coffee = con;
            }
            UpdateOrder(coffeeOrder);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="drink"></param>
        private void UpdateOrder(Order ord)
        {
            lblOrderName.Text = ord.OrderName;
            lstvwOrderItems.Items.Clear();
            foreach (var ingridents in ord.coffee.GetIngridents())
            {
                lstvwOrderItems.Items.Add(ingridents);
            }
            lblOrderPrice.Text = ord.coffee.Cost().ToString();
        }
    }
}

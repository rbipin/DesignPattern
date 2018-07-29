using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupTour northEast = new GroupTour("North East Tour");
            northEast.AddLocations("Nagaland");
            northEast.AddLocations("Assam");
            northEast.UpdateTotalCost(Convert.ToDecimal(1200.00));

            Guest1 jack = new Guest1("Jack Hugeman");
            Guest2 sam = new Guest2("Samual Jackson");
            Guest3 brad = new Guest3("Brad Pitt");
            northEast.AddObserver(jack);
            northEast.AddObserver(sam);
            northEast.AddObserver(brad);

            northEast.AddLocations("Arunachal Pradesh");
            northEast.UpdateTotalCost(100);
            
            northEast.AddLocations("Mizoram");
            northEast.UpdateTotalCost(150);

            Console.Read();

        }
    }
}

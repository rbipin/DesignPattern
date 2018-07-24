using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupTour tour = new GroupTour("International");
            tour.AddLocations("Paris");
            tour.UpdateTotalCost(100);

            Guest g1 = new Guest("Sam");
            Guest g2 = new Guest("Mike");

            tour.AddObserver(g1);
            tour.AddObserver(g2);
            tour.AddLocations("Rome");
            tour.UpdateTotalCost(100);

            tour.RemoveObserver(g1);
            tour.AddLocations("Italy");
            tour.UpdateTotalCost(300);

            Console.Read();
        }
    }
}

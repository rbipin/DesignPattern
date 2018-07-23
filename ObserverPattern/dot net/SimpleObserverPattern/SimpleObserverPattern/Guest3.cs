using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{
    class Guest3 :IObserver
    {

        GroupTour tourData = null;
        string GuestName = string.Empty;

        public Guest3(string name)
        {
            GuestName = name;
        }

        public void Update(object data)
        {
            tourData = (GroupTour)data;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Tour Data is Guest Name: {GuestName}, Total Cost: {tourData.GetTotalCost()}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Guest : IObserver
    {
        string GuestName = string.Empty;
        GroupTour data = null;

        public Guest(string name)
        {
            GuestName = name;
        }

        //Pull Mechanishm
        public void Update(AObservable subject)
        {
            data = (GroupTour)subject;
            Display();
        }

        void Display()
        {
            Console.WriteLine($"Guest Name:{GuestName}, Tour Name: {data.GetTotalCost()}");
        }
    }
}

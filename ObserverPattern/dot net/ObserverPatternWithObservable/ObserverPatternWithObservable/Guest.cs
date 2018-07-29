using System;

namespace ConsoleApp1
{
    public class Guest : IObserver
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

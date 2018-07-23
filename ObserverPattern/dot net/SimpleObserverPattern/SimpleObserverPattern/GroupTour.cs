using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleObserverPattern
{

    //This acts as the data object and also the Subject
    class GroupTour
    {
        List<IObserver> Observers = new List<IObserver>();

        private List<string> Locations = new List<string>();
        private string TourName { get; set; }
        private decimal TotalCost { get; set; }

        
        public GroupTour(string GroupName)
        {
            TourName = GroupName;
        }

        public void AddObserver(IObserver obs)
        {
            Observers.Add(obs);
        }

        public void RemoveObserver(IObserver obs)
        {
            Observers.Remove(obs);
        }

        public void NotifyObserver()
        {
            if (Observers !=null && Observers.Count>=0)
            {
                foreach (IObserver guest in Observers)
                {
                    guest.Update(this);
                }
            }
        }

        public void AddLocations(string place)
        {
            Locations.Add(place);
            NotifyObserver();
        }

        public List<string> GetLocations()
        {
            return Locations;
        }

        public void UpdateTotalCost(decimal price)
        {
            TotalCost = TotalCost + price;
            NotifyObserver();
        }

        public string GetGroupName()
        {
            return TourName;
        }

        public decimal GetTotalCost()
        {
            return TotalCost;
        }
    }
}

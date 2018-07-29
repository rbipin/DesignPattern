using System.Collections.Generic;

namespace ConsoleApp1
{
    //This acts as the data object and also the Subject
    public class GroupTour : AObservable
    {
        List<IObserver> Observers = new List<IObserver>();

        private List<string> Locations = new List<string>();
        private string TourName { get; set; }
        private decimal TotalCost { get; set; }


        public GroupTour(string GroupName)
        {
            TourName = GroupName;
        }

        public void AddLocations(string place)
        {
            Locations.Add(place);
        }

        
        public List<string> GetLocations()
        {
            return Locations;
        }

        public void UpdateTotalCost(decimal price)
        {
            TotalCost = TotalCost + price;
            StateChanged();
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

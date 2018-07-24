using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using ConsoleApp1;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace TourApp
{
    /// <summary>
    /// Interaction logic for UserWindows.xaml
    /// </summary>
    public partial class UserWindows : Window, IObserver
    {
        public GroupTour TourData = null;
        public UserWindows()
        {
            InitializeComponent();

        }

        public void Update(AObservable subject)
        {
            UpdateDisplay(subject);
        }

        public void UpdateDisplay(AObservable data)
        {
            TourData = (GroupTour)data;
            lblTotalCost.Content = TourData.GetTotalCost();
            foreach (string location in TourData.GetLocations())
            {
                if (!lstvwlocations.Items.Contains(location))
                {
                    lstvwlocations.Items.Add(location);
                }
            }
        }
    }
}

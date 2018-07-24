using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConsoleApp1;

namespace TourApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GroupTour gt = null;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void btnCreateTour_Click(object sender, RoutedEventArgs e)
        {
            decimal defaultCost = 100;
            gt = new GroupTour(txtTourName.Text);
            gt.UpdateTotalCost(defaultCost);
            lblTourName.Content = txtTourName.Text;
            btnCreateTour.IsEnabled = false;
        }

        private void btnLocation_Click(object sender, RoutedEventArgs e)
        {
            gt.AddLocations(txtLocation.Text);
            gt.UpdateTotalCost(200);
            lstvwlocation.Items.Add(txtLocation.Text);
        }

        private void btnAddGuest_Click(object sender, RoutedEventArgs e)
        {
            lstvwGuests.Items.Add(txtGuestName.Text);
            UserWindows newGuest = new UserWindows();
            newGuest.lblGuestName.Content = txtGuestName.Text;
            newGuest.UpdateDisplay(gt);
            gt.AddObserver(newGuest);
            newGuest.Show();
        }

        private void Reset_Tour_Click(object sender, RoutedEventArgs e)
        {
            gt = null;
            lblTourName.Content = "Tour Name Here!";
            lstvwlocation.Items.Clear();
        }
    }
}

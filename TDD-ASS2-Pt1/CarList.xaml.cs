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
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace TDD_ASS2_Pt1
{
    /// <summary>
    /// Interaction logic for CarList.xaml
    /// </summary>
    public partial class CarList : MetroWindow
    {
        public static List<Vehicle> vehicleList = new List<Vehicle>();

        public CarList()
        {
            InitializeComponent();
            vehicleList = Vehicle.LoadVehicles();
            txtFileNameLabel.Text = Vehicle.GetFilePath();
            UpdateList();



        }

        private void UpdateList (int index = 0)
        {
            lvVehicleList.ItemsSource = vehicleList;
            lvVehicleList.Items.Refresh();
            txtRecordNumber.Text = string.Format("Record {0} of {1}", index + 1, vehicleList.Count); 
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClearSearch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvVehicleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lvVehicleList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void EditCompanyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteCompanyButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

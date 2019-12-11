using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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
using MahApps.Metro.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace TDD_ASS2_Pt1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public static List<Vehicle> vehicleList;
        public SeriesCollection lineData;
        

        public MainWindow()
        {
            InitializeComponent();

            vehicleList = Vehicle.LoadVehicles();
            VehiclesInformationCard.Title = "Vehicles";
            VehiclesInformationCard.BackgroundColour = "Purple";
            VehiclesInformationCard.ValueProperty = vehicleList.Count.ToString();

            lineData = new SeriesCollection
                {
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4 ,6 },
                    PointGeometry = null

                }
            };
            VehiclesInformationCard.SeriesData = lineData;

        }

       

        private void btn_toVehicleList_Click(object sender, RoutedEventArgs e)
        {
            CarList winCarList = new CarList();
            winCarList.ShowDialog();
            
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Add_Vehicle winAddVehicle = new Add_Vehicle();
            winAddVehicle.ShowDialog();
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void VehiclesInformationCard_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            CarList winList = new CarList();
            winList.ShowDialog();
        }
    }
}

using MahApps.Metro.Controls;
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

namespace TDD_ASS2_Pt1
{
    /// <summary>
    /// Interaction logic for Rent_The_Car.xaml
    /// </summary>
    public partial class Rent_The_Car : MetroWindow
    {
        public Rent_The_Car()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
           
            
        }
    }
}

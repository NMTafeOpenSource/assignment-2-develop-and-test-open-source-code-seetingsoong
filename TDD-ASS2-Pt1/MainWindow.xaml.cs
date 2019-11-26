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

namespace TDD_ASS2_Pt1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            FillTable();
        }

        public void FillTable(string searchTerm = "")
        {
            string connectionStr = "server=localhost;" +
                                    "user=hilarysoong;" +
                                    "database=nmt_cars;" +
                                    "port=3306;" +
                                    "password=SecretPassword123";
            string sql = "select id,make,model,release_year,registration,tank_size,fuel from vehicles";
            if (!string.IsNullOrEmpty(searchTerm))
            {
                sql += " where location_name like '%" + searchTerm.Trim() + "%'";
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionStr))
                {
                    connection.Open();

                    using (MySqlCommand cmSel = new MySqlCommand(sql, connection))
                    {
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(cmSel);
                        da.Fill(dt);
                        dataGrid.DataContext = dt;
                    }
                    connection.Close();
                }
                MessageTextBlock.Text = "Ready";
            }
            catch(Exception e)
            {
                MessageTextBlock.Text = e.Message;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Rent_The_Car winRent = new Rent_The_Car();
            winRent.ShowDialog();
            winRent.Owner = this;
            
        }

        private void Txtbx_Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            FillTable(txtbx_Search.Text);
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            Add_Vehicle winAdd = new Add_Vehicle();
            winAdd.ShowDialog();
            winAdd.Owner = this;
            FillTable(txtbx_Search.Text);
        }
    }
}

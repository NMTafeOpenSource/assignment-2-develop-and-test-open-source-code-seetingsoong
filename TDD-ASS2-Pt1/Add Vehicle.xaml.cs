using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using MySql.Data.MySqlClient;
using System;

namespace TDD_ASS2_Pt1
{
    /// <summary>
    /// Interaction logic for Add_Vehicle.xaml
    /// </summary>
    public partial class Add_Vehicle : MetroWindow
    {
        public Add_Vehicle()
        {
            InitializeComponent();
            OpenConnection();
          
        }

        MySqlConnection connection;
        private string connStr = "server=localhost;user=hilarysoong;database=nmt_cars;password=SecretPassword123";

        private void OpenConnection()
        {
            connection = new MySqlConnection(connStr);
            connection.Open();
        }

        private void CloseConnection()
        {
            connection.Close();
        }

        //insert data to vehicles table in Mysql database
        private bool AddVehicleToDB(string vMake, string vModel, string vYear, string vRego, string fuelType, string tankSize)
        {
            //string query = "INSERT INTO nmt_cars.vehicles(make, model, release_year, registration, fuel) VALUES('" + tbx_make.Text + "','" + tbx_model.Text + "','" + tbx_year.Text + "','" + tbx_rego.Text + "','" + tbx_fuel.Text + "')";
            string query = "INSERT INTO nmt_cars.vehicles(make, model, release_year, registration, fuel) VALUES('" + vMake + "','" + vModel + "','" + vYear + "','" + vRego + "','" + fuelType + "')";

            MySqlCommand command = new MySqlCommand(query, connection);
            try
            {
                command.ExecuteNonQuery();
                //if (command.ExecuteNonQuery() == 1)
                //{
                //    MessageBox.Show("Vehicle has been successfully added to the system");

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        //find if the data exist in the table
        private bool FindRegoInDB(string vRego)
        {
            string sql = "select 1 from vehicles where registration = '" + vRego + "'";
            using (MySqlCommand command = new MySqlCommand(sql,connection))
            {
                if(command.ExecuteScalar()!= null)
                {
                    return true;
                }               
            }
            return false;
        }

        private void ValidateVehicle(string vRego)
        {
            if (FindRegoInDB( vRego))
            {
               MessageBox.Show("Vehicle already exist in the system");
               
            }
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            CloseConnection();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {    //validate vehicle
            // add vehicle to system
            string make = tbx_make.Text.Trim();
            string model = tbx_model.Text.Trim();
            string year = tbx_year.Text.Trim();
            string rego = tbx_rego.Text.Trim();
            string fuel = tbx_fuel.Text.Trim();
            string tank = tbx_tank.Text.Trim();
            //string initial = tbx_initial.Text;

            ValidateVehicle(rego);

            if (AddVehicleToDB(make,model,year,rego,fuel,tank))
            {
                MessageBox.Show("Vehicle has been successfully added to the system");
                btn_Cancel_Click(sender, e);
            }
            else
            {
                MessageBox.Show("adding fail","Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

    }
}

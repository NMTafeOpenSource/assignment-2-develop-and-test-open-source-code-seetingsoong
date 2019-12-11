using System.Windows;
using System.Windows.Controls;
using MahApps.Metro.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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
            tb_regoError.Text = tb_makeError.Text = tb_yearError.Text = tb_modelError.Text = tb_ftError.Text
                = tb_tankError.Text = string.Empty;

        }
        
      
       

      
        //public void CreateVehicle(string make, string model, string rego, string year, string tank, string fuelType)
        //{
           
        //    if (ValidateVehicle(make, model, rego, year, tank, fuelType) == true)
        //    {
        //        newVehicle.manufacturer = make;
        //        newVehicle.model = model;
        //        newVehicle.registrationNumber = rego;
        //        newVehicle.makeYear = year;
        //        newVehicle.tankCapacity = tank;
        //        newVehicle.fuelType = fuelType;
        //    }
        //    else
        //    {
        //        throw new ArgumentException("The value was not valid");
        //    }
            
        //}

        private bool ValidateVehicle(string vRego, string vMake, string vYear, string vModel, string vTank, string vFuel)
        {
            bool output = true;
            if (string.IsNullOrEmpty(vRego))
            {
                tb_regoError.Text = "Rego is required";
                output = false;
            }
            else if (string.IsNullOrEmpty(vModel))
            {
                tb_modelError.Text = "Model is required";
                output = false;
            }
            else if (string.IsNullOrEmpty(vMake))
            {
                tb_makeError.Text = "Make is required";
                output = false;
            }
            else if (string.IsNullOrEmpty(vYear))
            {
                tb_yearError.Text = "Year is required";
                output = false;
            }
            else if (string.IsNullOrEmpty(vFuel))
            {
                tb_ftError.Text = "Fuel is required";
                output = false;
            }
            else if (string.IsNullOrEmpty(vTank))
            {
                tb_tankError.Text = "Tank is required";
                output = false;
            }
            return output;
        }

       
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {    //validate vehicle
             // add vehicle to system
            tb_regoError.Text = tb_makeError.Text = tb_yearError.Text = tb_modelError.Text = tb_ftError.Text
               = tb_tankError.Text = string.Empty;

            string make = tbx_make.Text.Trim();
            string model = tbx_model.Text.Trim();
            string year = tbx_year.Text.Trim();
            string rego = tbx_rego.Text.Trim();
            string fuel = tbx_fuel.Text.Trim();
            string tank = tbx_tank.Text.Trim();
            //string initial = tbx_initial.Text;

            if (string.IsNullOrEmpty(tbx_rego.Text) && string.IsNullOrEmpty(tbx_model.Text) && string.IsNullOrEmpty(tbx_make.Text) &&
               string.IsNullOrEmpty(tbx_year.Text) && string.IsNullOrEmpty(tbx_fuel.Text) && string.IsNullOrEmpty(tbx_tank.Text))
            {
                MessageBox.Show("Please enter details");
            }
            else
            {
                ValidateVehicle(rego, make, year, model, tank, fuel);
                
            }
 
            if (tb_regoError.Text.Length + tb_makeError.Text.Length + tb_yearError.Text.Length + tb_modelError.Text.Length + tb_tankError.Text.Length + tb_ftError.Text.Length == 0)

            {
                //if (AddVehicleToDB(make, model, year, rego, fuel, tank))
                //{
                //    MessageBox.Show("Vehicle has been successfully added to the system");
                //    btn_Cancel_Click(sender, e);
                //}
                //else
                //{
                //    MessageBox.Show("adding fail", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                //}

            }

           
        }

       
    }
}

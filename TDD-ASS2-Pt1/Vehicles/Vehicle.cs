using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using System.IO;

namespace TDD_ASS2_Pt1
{

    public class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string MakeYear { get; set; }
        public string RegistrationNumber { get; set; }
        public string FuelType { get; set; }
        public int OdometerReading { get; set; }
        public string TankCapacity { get; set; }
        public FuelPurchase FuelPurchase { get; set; }
        Rental vehicleRent = new Rental();
        //Service vehicleService = new Service();
        FuelPurchase vehicleFuelPurchase = new FuelPurchase();
        //created at
        //updated at

        private static string clusterFolder = "C4ProgS2_TDD_AS2";
        private static string mainFolder = "CarRental_Management";
        private static string vehicles_FileName = "vehiclesList.json";
        bool vListChanged = false;
      
        public Vehicle() { }
        

        /**
         * Class constructor specifying name of make (manufacturer), model and year
         * of make.
         * @param manufacturer
         * @param model
         * @param makeYear
         */

        public Vehicle(string manufacturer, string model, string makeYear,string rego, string fuel, string tank)
        {
          
           
        }

        // TODO Add missing getter and setter methods

        /**
         * Prints details for {@link Vehicle}
         */
        //public void PrintDetails()
        //{
        //    Console.WriteLine("Vehicle: " + makeYear + " " + manufacturer + " " + model +
        //        "/n" + "Registration No.: " + registrationNumber + "/n" +
        //        "Total Kilometres Travelled: " + vehicleRent.TotalKm + "/n" +
        //        //"Total services: " + vehicleService.ServiceCount + "/n" +
        //        "Revenue recorded: " + vehicleRent.RentalPerKm + "/n" +
        //        //"Kilometres since the last service: " + vehicleService.LastServiceOdometerKm + "/n" + 
        //        "Fuel Economy: " + vehicleFuelPurchase.FuelEconomy + "/n") ;
        //        //"Requires a service: " + vehicleService.RequiredService );

        //    // TODO Display additional information about this vehicle -Done!
        //}


        // TODO Create an addKilometers method which takes a parameter for distance travelled 
        // and adds it to the odometer reading. 

        public static void SaveVehicles(List<Vehicle> vehicleList) //convert JSon to string and write string to a file
        {
            using (StreamWriter file = File.CreateText(GetFilePath()))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, vehicleList);
            }
        }

       

        public static List<Vehicle> LoadVehicles() // convert JSON file to objects and put into list
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            if (File.Exists(GetFilePath()))
            {
                using (StreamReader file = File.OpenText(GetFilePath()))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    vehicleList = (List<Vehicle>)serializer.Deserialize(file, typeof(List<Vehicle>));
                }

            }
            else
            {
                vehicleList.Add(new Vehicle("Ariel", "Atom 4", "2019", "1ARI444 ", "Petrol", "40"));
                vehicleList.Add(new Vehicle("Ford", "Ranger XL", "2015", "1GVL526", "Diesel", "80"));
                vehicleList.Add(new Vehicle("Tesla", "Roadster", "2008", "8HDZ576", "Electric", "0"));
                vehicleList.Add(new Vehicle("Holden", "Commodore LT", "2018", "1GXI000", "Diesel", "61"));
                vehicleList.Add(new Vehicle("BMW", "Z4", "2019", "HMM B33R", "Petrol", "52"));
                vehicleList.Add(new Vehicle("Hyundai", "Sonata Premium", "2018", "ICTPRG40", "Gas", "70"));
                vehicleList.Add(new Vehicle("Chevrlet", "Cadillac", "1959", "C4D1LL4C", "Petrol", "79"));
                vehicleList.Add(new Vehicle("Ford", "Territory", "2014", "T3RR1TOR", "Petrol", "80"));
                vehicleList.Add(new Vehicle("Mitsubishi", "Pajero GLS", "2019", "2MCR657", "Diesel", "90"));
                vehicleList.Add(new Vehicle("Mitsubishi", "Eclipse Cross ES(2WD)", "2018", "1GGG292", "Petrol", "63"));
                vehicleList.Add(new Vehicle("Hyundai", "Santa Fe Highlander CRDi Satan Dark", "2019", "ICTPRG41", "Diesel", "71"));
                vehicleList.Add(new Vehicle("Bugatti", "Veyron 16.4 Super Sport", "2011", "1FST319", "Petrol", "100"));
                vehicleList.Add(new Vehicle("Toyota", "Yaris", "2019", "YGT427", "Petrol", "42"));
                vehicleList.Add(new Vehicle("Hyundai", "Elantra SR Turbo", "2017", "ICTPRG40", "Gas", "50"));
                vehicleList.Add(new Vehicle("Toyota", "Corolla Hatch", "2019", "CHT185", "Petrol", "50"));
                vehicleList.Add(new Vehicle("Land", "Rover Defender", "2015", "BCZ581", "Diesel", "60"));
                vehicleList.Add(new Vehicle("Ford", "escape titanium", "2019", "FR2917", "Diesel", "64"));
                vehicleList.Add(new Vehicle("Lamborghini", "Urus", "2019", "URU2K19", "Petrol", "85"));
            }
  
            return vehicleList;
        }




        public static string GetFilePath()//Locate vehicleList json file
        {
            string sReturn = "";
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + @clusterFolder + "\\" + @mainFolder;

            try
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                sReturn = directoryPath + "\\" + vehicles_FileName;
            }
            catch(Exception error)
            {
                Console.WriteLine("issues with file path", error);
            }

            return sReturn;
           
        }


    
       

    }

}

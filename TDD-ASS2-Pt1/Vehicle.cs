using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_ASS2_Pt1
{

    public class Vehicle
    {
        private String manufacturer;
        private String model;
        private int makeYear;
        private String registrationNumber;
        private int odometerReading;
        private double tankCapacity;
        private FuelPurchase fuelPurchase;
        Rental vehicleRent = new Rental();
        //Service vehicleService = new Service();
        FuelPurchase vehicleFuelPurchase = new FuelPurchase();

        // TODO add Registration Number -Done!
        // TODO add variable for OdometerReading (in KM), -Done!
        // TODO add variable for TankCapacity (in litres) -Done!

        

        /**
         * Class constructor specifying name of make (manufacturer), model and year
         * of make.
         * @param manufacturer
         * @param model
         * @param makeYear
         */

        public Vehicle(String manufacturer, String model, int makeYear)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.makeYear = makeYear;
            fuelPurchase = new FuelPurchase();
        }

        // TODO Add missing getter and setter methods

        /**
         * Prints details for {@link Vehicle}
         */
        public void printDetails()
        {
            Console.WriteLine("Vehicle: " + makeYear + " " + manufacturer + " " + model +
                "/n" + "Registration No.: " + registrationNumber + "/n" +
                "Total Kilometres Travelled: " + vehicleRent.TotalKm + "/n" +
                //"Total services: " + vehicleService.ServiceCount + "/n" +
                "Revenue recorded: " + vehicleRent.RentalPerKm + "/n" +
                //"Kilometres since the last service: " + vehicleService.LastServiceOdometerKm + "/n" + 
                "Fuel Economy: " + vehicleFuelPurchase.FuelEconomy + "/n") ;
                //"Requires a service: " + vehicleService.RequiredService );

            // TODO Display additional information about this vehicle -Done!
        }


        // TODO Create an addKilometers method which takes a parameter for distance travelled 
        // and adds it to the odometer reading. 

        // adds fuel to the car
        public void addFuel(double litres, double price)
        {
            fuelPurchase.purchaseFuel(litres, price);
        }

    }

}

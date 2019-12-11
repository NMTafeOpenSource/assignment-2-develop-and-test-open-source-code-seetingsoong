using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_ASS2_Pt1
{
    public class Rental
    {
        private double rentalPerKm = 1;
        private double rentalPerDay = 100;
        private double totalKm = 0;
        private double numberOfDay = 0;

        public double RentalPerKm
        {
            get { return rentalPerKm; }

        }

        public double RentalPerDay
        {
            get { return rentalPerDay; }
        }

        public double TotalKm
        {
            get { return totalKm; }
        }

        public double NumberOfDay
        {
            get { return numberOfDay; }
        }

       
        public void CalculateRentalByKm ()
        {
            double totalCostByKm = rentalPerKm * totalKm;
        }

        public void CalculateRentalByDay()
        {
            double totalCostByDay = rentalPerDay * numberOfDay;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_ASS2_Pt1
{

    public class Journey//Journey and Rental are combined
    {

        private double kilometers;

        /**
         * Class constructor
         */
        public Journey()
        {
            this.kilometers = 0;
        }

        /** 
         * Appends the distance parameter to {@link #kilometers}
         * @param kilometers the distance traveled 
         */
        public void addKilometers(double kilometers)
        {
            this.kilometers += kilometers;
        }



        /**
         * Getter method for total Kilometers traveled in this journey.
         * @return {@link #kilometers}
         */
        public double getKilometers()
        {
            return kilometers;
        }

    }

}

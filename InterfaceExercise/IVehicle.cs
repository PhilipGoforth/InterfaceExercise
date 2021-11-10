using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */
        public double EngineSize { get; set; }
        public int Mpg { get; set; }
        public string Color { get; set; }
        public bool IsAWD { get; set; }

    }
}

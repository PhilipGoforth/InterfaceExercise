using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : ICompany, IVehicle
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public string BedSize { get; set; }
        public int TowingCapacity { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }
        public double EngineSize { get; set; }
        public int Mpg { get; set; }
        public string Color { get; set; }
        public bool IsAWD { get; set; }

        public void DisplayTruck()
        {
            Console.WriteLine(@$"Vehicle Specs: 
                                 Make: {Logo}
                                Color: {Color}
                    Country of origin: {Country}
                               Is AWD: {IsAWD}
                          Engine Size: {EngineSize}
                     Miles per gallon: {Mpg}
                             Bed Size: {BedSize}
                 Towing Capacity(Lbs): {TowingCapacity}

                                ");
        }
    }
}

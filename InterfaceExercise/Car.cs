using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public string TrunkSize { get; set; }
        public string ConvertableColor { get; set; }
        public double EngineSize { get; set; }
        public int Mpg { get; set; }
        public string Color { get; set; }
        public bool IsAWD { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }

        public void DisplayCar()
        {
            Console.WriteLine(@$"Vehicle Specs: 
                                 Make: {Logo}
                                Color: {Color}
                    Country of origin: {Country}
                               Is AWD: {IsAWD}
                          Engine Size: {EngineSize}
                     Miles per gallon: {Mpg}
                    Convertable Color: {ConvertableColor}
                           Trunk Size: {TrunkSize}

                                ");
        }
    }
}

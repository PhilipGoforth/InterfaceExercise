using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        //In each of your car, truck, and suv classes

        /*Create 2 members that are specific to each class
         * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
         *
         * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
         * 
         */
        public string CargoHoldSize { get; set; }
        public bool HasThirdRow { get; set; }
        public string Logo { get; set; }
        public string Country { get; set; }
        public double EngineSize { get; set; }
        public int Mpg { get; set; }
        public string Color { get; set; }
        public bool IsAWD { get; set; }

        public void DisplaySUV()
        {
            Console.WriteLine(@$"Vehicle Specs: 
                                 Make: {Logo}
                                Color: {Color}
                    Country of origin: {Country}
                               Is AWD: {IsAWD}
                          Engine Size: {EngineSize}
                     Miles per gallon: {Mpg}
                      Cargo Hold Size: {CargoHoldSize}
                  Third Row Available: {HasThirdRow}

                                ");
        }
    }
}

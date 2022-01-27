using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch(wheels.ToLower())
            {
                case "4":
                case "four":
                    return new Car();
                case "4 big":
                case "four big":
                    return new Truck();
                default:
                    return new Car();
            }
        }
    }
}


    


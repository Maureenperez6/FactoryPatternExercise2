using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Truck : IVehicle
    {
        public Truck()
        {
            Console.WriteLine("Building a new Truck!\n");
        }
        public void Drive()

        {
            Console.WriteLine($"I'm driving a new truck!\n");
        }
    }
}

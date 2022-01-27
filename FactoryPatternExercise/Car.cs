using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car!\n");
        }
        public void Drive()

        {
            Console.WriteLine($"I'm driving a new Car!\n");
        }
    }
}

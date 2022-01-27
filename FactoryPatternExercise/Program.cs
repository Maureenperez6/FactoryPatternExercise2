using System;

namespace FactoryPatternExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your car have?");
            string numberOfWheels = Console.ReadLine();

   
           IVehicle vehicle =  VehicleFactory.GetVehicle(numberOfWheels);
            Console.WriteLine();
           
            vehicle.Drive();

            
        }
    }
}

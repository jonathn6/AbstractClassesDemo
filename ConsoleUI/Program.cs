using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var focus = new Car() { Make="Ford", Model="Focus", Year=2021, HasTrunk=true };
            var motorcycle = new Motorcycle() { Make="Kawasaki", Model="Ninja", Year=2020, HasSideCart=true};

            var sedan = new Car() { HasTrunk=true, Make="Dodge", Model="Blah", Year=1999};
            var sportCar = new Car() { HasTrunk=false, Make="Chevy", Model="Corvette", Year=1963};


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(focus);
            vehicles.Add(motorcycle);
            vehicles.Add(sedan);
            vehicles.Add(sportCar);

            foreach (var vehicle in vehicles)
            {
                Console.Write($"There is a {vehicle.Year} {vehicle.Make} {vehicle.Model} in the list. ");
                if (vehicle is Car)
                {
                    var tempCar = new Car();
                    tempCar = (Car)vehicle;
                    if (tempCar.HasTrunk == true)
                    {
                        Console.WriteLine("This car also has a trunk.");
                    } else
                    {
                        Console.WriteLine("This car does not have a trunk.");
                    }
                } else
                {
                    var tempMotorcycle = new Motorcycle();
                    tempMotorcycle = (Motorcycle)vehicle;
                    if (tempMotorcycle.HasSideCart == true)
                    {
                        Console.WriteLine("This motorcycle also has a sidecar.");
                    } else
                    {
                        Console.WriteLine("This motorcycle does not have a sidecar.");
                    }
                }
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
        }
    }
}

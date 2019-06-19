using ExampleCSharpCar.Cars;
using ExampleCSharpCar.Engines;
using ExampleCSharpCar.Purposes;
using System;
using System.Collections.Generic;
using static ExampleCSharpCar.CarFactory;

namespace ExampleCSharpCar
{

    /// <summary>
    /// A class to show a demo of cars.
    /// </summary>
    public class CarDemo
    {

        /// <summary>
        /// A method showing Car demo.
        /// </summary>
        public void ShowDemo()
        {

            // Getting Car Factory "online"
            CarFactory factory = new CarFactory();
            List<Car> myCars = new List<Car>();

            // prepare an Opel car
            CarParameters opelParams = new CarParameters("Opel ", " gasoline ");
            Car opelCar = factory.ProvideCar(opelParams);
            opelCar.Purpose = new GroceriesPurpose();
            myCars.Add(opelCar);

            // prepare a Volvo Car
            CarParameters volvoParams = new CarParameters("volvo", " diesel ", "wrongpurpose...");
            Car volvoCar = factory.ProvideCar(volvoParams);
            myCars.Add(volvoCar);

            // prepare a Stanley Car
            CarParameters stanleyParams = new CarParameters("     stanley", " steam ", "racing ");
            Car stanleyCar = factory.ProvideCar(stanleyParams);
            myCars.Add(stanleyCar);

            // prepare a car, generic
            CarParameters anyParams = new CarParameters();
            Car justACar = factory.ProvideCar(anyParams);
            myCars.Add(justACar);

            Console.WriteLine("=== === === * * * === === ===");

            // Try the cars
            foreach (Car car in myCars)
            {
                car.WhatCarIsIt();
                Console.WriteLine(car.Engine.StartEngine());
                Console.Write("The car now is doing : ");
                car.Purpose.DoTheAction();
                Console.WriteLine("===========");
            }

            Console.WriteLine("=== === === * * * === === === \n");
            Console.WriteLine("Change of mind, some cars get reworked.");
            Console.WriteLine("=== === === * * * === === ===");

            foreach (Car car in myCars)
            {
                
                if (car is StanleyCar) car.Purpose = new GroceriesPurpose();

                if (car is VolvoCar)
                {
                    car.Engine = new ElectricEngine();
                    car.Purpose = new RacingPurpose();
                }
            }

            foreach (Car car in myCars)
            {
                car.WhatCarIsIt();
                Console.WriteLine(car.Engine.StartEngine());
                Console.Write("The car now is doing : ");
                car.Purpose.DoTheAction();
                Console.WriteLine("===========");
            }

            Console.ReadLine();

        }
    }

}

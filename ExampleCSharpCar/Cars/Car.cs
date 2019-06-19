using ExampleCSharpCar.Engines;
using ExampleCSharpCar.Purposes;
using System;

namespace ExampleCSharpCar.Cars
{
    abstract public class Car
    {

        #region Constructors

        /// <summary>
        /// Constructor in case user does not specify what car is needed. You may have problem entering such car.
        /// </summary>
        public Car()
        {

            Engine = new NoneEngine();
            Purpose = new NoPurpose(); 

        }


        #endregion Constructors

        #region Operations

        /// <summary>
        /// Identifies a car.
        /// </summary>
        /// <param name="make">Specific car make.</param>
        public virtual void WhatCarIsIt(string make = "Not specified")
        {
            Console.WriteLine("This car is of make: " + make.Trim());
        }

        #endregion Operations

        #region Properties

        /// <summary>
        /// Engine type of a car.
        /// </summary>
        public IEngine Engine { get; set; }

        /// <summary>
        /// Purpose of a car.
        /// </summary>
        public IPurpose Purpose { get; set; }

        #endregion Properties

    }
}

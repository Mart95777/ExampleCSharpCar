using ExampleCSharpCar.Engines;
using ExampleCSharpCar.Purposes;

namespace ExampleCSharpCar.Cars
{
    public class NullCar : Car
    {
        #region Constructors

        public NullCar()
        {
            Engine = new NoneEngine();
            Purpose = new NoPurpose();
        }
        #endregion Constructors
        /// <summary>
        /// Null car implementation of car make method.
        /// </summary>
        /// <param name="make"></param>
        public override void WhatCarIsIt(string make)
        {
            base.WhatCarIsIt("Not specified.");
        }
    }
}

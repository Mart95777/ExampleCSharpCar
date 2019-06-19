using ExampleCSharpCar.Engines;
using ExampleCSharpCar.Purposes;

namespace ExampleCSharpCar.Cars
{
    public class NullCar : Car
    {
        #region Constructors

        public NullCar()
        {
            // Base class assigns null engine and no purpose. Additional fields, if you add some, put below.
        }
        #endregion Constructors

        #region Operations

        /// <summary>
        /// Null car implementation of car make method.
        /// </summary>
        /// <param name="make"></param>
        public override void WhatCarIsIt(string make)
        {
            base.WhatCarIsIt("Not specified.");
        }
        #endregion Operations
    }
}

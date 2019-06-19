namespace ExampleCSharpCar.Cars
{
    public class OpelCar : Car
    {
        /// <summary>
        /// Opel implementation of car make method.
        /// </summary>
        /// <param name="make"></param>
        public override void WhatCarIsIt(string make)
        {
            base.WhatCarIsIt("Opel");
        }

    }
}

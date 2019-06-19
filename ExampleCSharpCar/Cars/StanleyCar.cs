namespace ExampleCSharpCar.Cars
{
    public class StanleyCar : Car
    {

        /// <summary>
        /// Stanley implementation of car make method.
        /// </summary>
        /// <param name="make"></param>
        public override void WhatCarIsIt(string make)
        {
            base.WhatCarIsIt("Stanley");
        }
    }
}

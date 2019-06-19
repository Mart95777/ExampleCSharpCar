namespace ExampleCSharpCar.Cars
{
    public class VolvoCar : Car
    {

        /// <summary>
        /// Volvo implementation of car make method.
        /// </summary>
        /// <param name="make"></param>
        public override void WhatCarIsIt(string make)
        {
            base.WhatCarIsIt("Volvo");
        }

    }
}

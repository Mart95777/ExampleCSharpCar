using System;

namespace ExampleCSharpCar.Purposes
{

    /// <summary>
    /// Purpose of a car is racing.
    /// </summary>
    public class RacingPurpose : IPurpose
    {

        #region Operations

        /// <summary>
        /// Implements interface method.
        /// </summary>
        public void DoTheAction()
        {
            Console.WriteLine("Racing to win!");
        }

        #endregion Operations
    }
}

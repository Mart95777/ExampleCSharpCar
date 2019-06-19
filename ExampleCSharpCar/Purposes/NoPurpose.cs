using System;

namespace ExampleCSharpCar.Purposes
{

    /// <summary>
    /// No purpose class. Default for a car, that has no chosen purpose yet.
    /// </summary>
    public class NoPurpose : IPurpose
    {

        #region Operations

        /// <summary>
        /// Implements interface method.
        /// </summary>
        public void DoTheAction()
        {
            Console.WriteLine("Nothing. No purpose!");
        }
        #endregion Operations
    }
}

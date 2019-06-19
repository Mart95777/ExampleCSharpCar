using System;

namespace ExampleCSharpCar.Purposes
{

    /// <summary>
    /// Car purpose of driving to a groceries store.
    /// </summary>
    public class GroceriesPurpose : IPurpose
    {

        #region Operations

        /// <summary>
        /// Implements interface method.
        /// </summary>
        public void DoTheAction()
        {
            Console.WriteLine("Driving to a store to get some food.");
        }
        #endregion Operations
    }
}

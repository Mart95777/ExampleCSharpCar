namespace ExampleCSharpCar.Engines
{
    public class SteamEngine : IEngine
    {
        #region Operations

        /// <summary>
        /// Implemets interface method.
        /// </summary>
        public string StartEngine()
        {
            return "Need wood or coal. Beginning to heat water tank...";
        }

        #endregion Operations
    }
}

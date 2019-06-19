namespace ExampleCSharpCar.Engines
{
    class NoneEngine : IEngine
    {

        #region Operations

        /// <summary>
        /// Implemets interface method.
        /// </summary>
        public string StartEngine()
        {
            return "There is no engine! Make sure car body is specified and install an engine.";
        }

        #endregion Operations
    }
}

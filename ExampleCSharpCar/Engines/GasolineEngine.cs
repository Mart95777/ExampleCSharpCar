namespace ExampleCSharpCar.Engines
{
    public class GasolineEngine : IEngine
    {

        /// <summary>
        /// Implemets interface method.
        /// </summary>
        public string StartEngine()
        {
            return "Starting engine. Get more gasoline.";
        }
    }
}

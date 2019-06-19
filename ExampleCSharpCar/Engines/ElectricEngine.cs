namespace ExampleCSharpCar.Engines
{
    public class ElectricEngine : IEngine
    {

        /// <summary>
        /// Implemets interface method.
        /// </summary>
        public string StartEngine()
        {
            return "Starting, but batteries are low...";
        }

    }
}

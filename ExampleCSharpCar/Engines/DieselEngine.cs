namespace ExampleCSharpCar.Engines
{
    public class DieselEngine : IEngine
    {

        /// <summary>
        /// Implemets interface method.
        /// </summary>
        public string StartEngine()
        {
            return "Starting. Add more diesel oil, when you can.";
        }
    }
}

namespace ExampleCSharpCar
{

    /// <summary>
    /// Engine type. In this demo it is also understood as an engine being installed on a car.
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Starts an engine.
        /// </summary>
        /// <returns>String with reply to the user.</returns>
        string StartEngine();

    }
}
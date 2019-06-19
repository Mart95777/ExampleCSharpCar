using ExampleCSharpCar.Cars;
using ExampleCSharpCar.Engines;
using ExampleCSharpCar.Purposes;
using System;

namespace ExampleCSharpCar
{

    /// <summary>
    /// Car Factory. Generates Car objects.
    /// </summary>
    public class CarFactory
    {

        #region Operations

        /// <summary>
        /// Generates a car. Logs to a console in case user specifies car make not correctly and 'Null' car is chosen.
        /// </summary>
        /// <param name="parameters">Parameters for requested car.</param>
        /// <returns>A Car. Can be a 'Null' Car.</returns>
        public Car ProvideCar(CarParameters parameters)
        {
            Car car = null;

            switch (parameters.CarMake)
            {
                case "opel":
                    car = new OpelCar();
                    break;
                case "stanley":
                    car = new StanleyCar();
                    break;
                case "volvo":
                    car = new VolvoCar();
                    break;
                default:
                    car = new NullCar();
                    Console.WriteLine("Logging: Possible problem, a null car is created");
                    break;
            }

            if (!(car is NullCar))
            {
                switch (parameters.EngineRequested)
                {
                    case "diesel":
                        car.Engine = new DieselEngine();
                        break;
                    case "electric":
                        car.Engine = new ElectricEngine();
                        break;
                    case "gasoline":
                        car.Engine = new GasolineEngine();
                        break;
                    case "steam":
                        car.Engine = new SteamEngine();
                        break;
                    default:
                        car.Engine = new NoneEngine();
                        break;
                }

                switch (parameters.PurposeRequested)
                {
                    case "groceries":
                        car.Purpose = new GroceriesPurpose();
                        break;
                    case "racing":
                        car.Purpose = new RacingPurpose();
                        break;
                    default:
                        car.Purpose = new NoPurpose();
                        break;
                }

            }

            return car;

        }
        #endregion Operations

        #region Definitions

        /// <summary>
        /// Helper, nested, class to specify needed car parameters.
        /// </summary>
        public class CarParameters
        {

            #region Constructors

            public CarParameters()
            {
                CarMake = "";
                EngineRequested = "";
                PurposeRequested = "";
            }

            public CarParameters(string make, string engine, string purpose = "")
            {
                CarMake = !System.String.IsNullOrEmpty(make) ? make.Trim().ToLower() : "";
                EngineRequested = !System.String.IsNullOrEmpty(engine) ? engine.Trim().ToLower() : "";
                PurposeRequested = !System.String.IsNullOrEmpty(purpose) ? purpose.Trim().ToLower() : "";
            }

            #endregion Constructors

            #region Properties

            /// <summary>
            /// Car make specification. Can be lower or upper case. Trimming before and after is applied.
            /// </summary>
            public string CarMake { get; set; }

            /// <summary>
            /// Engine type specification. Can be lower or upper case. Trimming before and after is applied.
            /// </summary>
            public string EngineRequested { get; set; }

            /// <summary>
            /// Purpose of a car. Can be lower or upper case. Trimming before and after is applied.
            /// </summary>
            public string PurposeRequested { get; set; }
            #endregion Properties
        }
        #endregion Definitions
    }


}

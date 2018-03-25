using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System.Linq;

namespace Quantum.Entanglement
{
    class Driver
    {
        static void Main(string[] args)
        {
            var simulator = new QuantumSimulator();
            // Define check flag
            var isEqual = true;
            foreach (var i in Enumerable.Range(0, 1000))
            {
                // Make the flag false if the entanglement fails at least once
                isEqual = isEqual && MeasureEntanglement.Run(simulator).Result;
            }

            // Check the flag status
            if (isEqual)
            {
                System.Console.WriteLine("Done");
            }
            else
            {
                System.Console.WriteLine("Failed");
            }
            System.Console.ReadKey();
        }
    }
}
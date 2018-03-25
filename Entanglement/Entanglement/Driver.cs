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
            {
                // Make the flag false if the entanglement fails at least once
                var entanglementResult = MeasureEntanglement.Run(simulator).Result;
                (long a, long b) = entanglementResult;
                System.Console.WriteLine(a);
                System.Console.WriteLine(b);
            }
                       
            System.Console.ReadKey();
        }
    }
}
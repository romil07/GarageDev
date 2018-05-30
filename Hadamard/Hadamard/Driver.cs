using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.Hadamard
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                var result = Hadamard.Run(sim).Result;
                (long a, long b) = result;
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.ReadKey();
            }
        }
    }
}
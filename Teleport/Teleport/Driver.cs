using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

namespace Quantum.Teleport
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var sim = new QuantumSimulator())
            {
                var result = Teleport.Run(sim).Result;
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
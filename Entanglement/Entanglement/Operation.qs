namespace Quantum.Entanglement
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

	
    operation MeasureEntanglement () : (Int, Int)
    {
        body
        {
			mutable countSame = 0;
			mutable countDiff = 0;
			let count = 1000;
            using(qubits = Qubit[2])
			{
				for(i in 1..count)
				{
					// Apply hadamard on qubit1
					H(qubits[0]);

					// Apply CNOT to entangle both qubits
					CNOT(qubits[0], qubits[1]);

					// Measure and compare states
					if(M(qubits[0]) == M(qubits[1]))
					{
						set countSame = countSame + 1;
					}
					else
					{
						set countDiff = countDiff + 1;
					}

					ResetAll(qubits);
				}
			}

			return (countSame, countDiff);
        }
    }
}

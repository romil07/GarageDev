namespace Quantum.Entanglement
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

	
    operation MeasureEntanglement () : (Bool)
    {
        body
        {
			mutable stateFinal = 2;
			mutable r = false;
            using(qubits = Qubit[2])
			{
				// Apply hadamard on qbit1
				H(qubits[0]);
				// Apply CNOT to entanlge both qbits
				CNOT(qubits[0], qubits[1]);
				// Measure and compare states
				set r = (M(qubits[0]) == M(qubits[1]));
				ResetAll(qubits);
			}

			return r;
        }
    }
}

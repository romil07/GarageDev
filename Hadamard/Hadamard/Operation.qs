namespace Quantum.Hadamard
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;

    operation Hadamard () : (Int, Int)
    {
        body
        {
            mutable count0 = 0;
			mutable count1 = 0;
			let count = 10000;

			for(i in 1..count)
			{
				using(qubits = Qubit[1])
				{
					H(qubits[0]);
					let measure = M(qubits[0]);

					if(measure == Zero)
					{
						set count0 = count0 + 1;
					}
					else
					{
						set count1 = count1 + 1;
					}
					ResetAll(qubits);
				}
			}

			return (count0, count1);
        }
    }
}

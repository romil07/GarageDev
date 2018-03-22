namespace Quantum.Teleport
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Math;

    operation Set(incoming: Qubit, target: Result) : ()
	{
		body
		{
			let x = M(incoming);
			if(x != target)
			{
				X(incoming);
			}
		}
	}

    operation Teleport () : (Int)
    {
        body
        {
			mutable m = 0;
            using(qubits = Qubit[3])
			{
				let message = qubits[0];
				let alice = qubits[1];
				let bob = qubits[2];

				let count = 1000;
				for(i in 1..count)
				{
					Set(message, Zero);
					mutable degree = 2.0 * ArcCos(Sqrt(1.0/4.0));
					Rx(degree, message);

					//entangle the two qubits
					H(alice);
					CNOT(alice, bob);

					//combine the 3 qubits
					CNOT(message, alice);
					H(message);

					if(M(message) == One) {Z(bob);}
					if(M(alice) == One) {X(bob);}

					let x = M(bob);
					if(x == One)
					{
						set m = m + 1;
					}

					ResetAll(qubits);
				}
			}

			return m;
        }
    }
}

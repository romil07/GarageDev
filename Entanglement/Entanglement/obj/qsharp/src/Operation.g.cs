#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Entanglement", "MeasureEntanglement () : Bool", new string[] { }, "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs", 165L, 8L, 5L)]
#line hidden
namespace Quantum.Entanglement
{
    public class MeasureEntanglement : Operation<QVoid, Boolean>
    {
        public MeasureEntanglement(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected Allocate Allocate
        {
            get
            {
                return this.Factory.Get<Allocate, Microsoft.Quantum.Primitive.Allocate>();
            }
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
        {
            get
            {
                return this.Factory.Get<IUnitary<(Qubit,Qubit)>, Microsoft.Quantum.Primitive.CNOT>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.H>();
            }
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected Release Release
        {
            get
            {
                return this.Factory.Get<Release, Microsoft.Quantum.Primitive.Release>();
            }
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get
            {
                return this.Factory.Get<ICallable<QArray<Qubit>, QVoid>, Microsoft.Quantum.Primitive.ResetAll>();
            }
        }

        public override Func<QVoid, Boolean> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Entanglement.MeasureEntanglement", OperationFunctor.Body, _args);
                var __result__ = default(Boolean);
                try
                {
#line 11 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    var stateFinal = 2L;
#line 12 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    var r = false;
#line 13 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
                    // Apply hadamard on qbit1
#line 16 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                    // Apply CNOT to entanlge both qbits
#line 18 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
                    // Measure and compare states
#line 20 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    r = (M.Apply<Result>(qubits[0L]) == M.Apply<Result>(qubits[1L]));
#line 21 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    ResetAll.Apply(qubits);
#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = r;
#line 24 "C:\\Users\\pranpati\\Source\\Repos\\Entanglement\\Entanglement\\Operation.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Entanglement.MeasureEntanglement", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<Boolean> Run(IOperationFactory __m__)
        {
            return __m__.Run<MeasureEntanglement, QVoid, Boolean>(QVoid.Instance);
        }
    }
}
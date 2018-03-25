#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Entanglement", "MeasureEntanglement () : (Int, Int)", new string[] { }, "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs", 169L, 8L, 5L)]
#line hidden
namespace Quantum.Entanglement
{
    public class MeasureEntanglement : Operation<QVoid, (Int64,Int64)>
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

        public override Func<QVoid, (Int64,Int64)> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Entanglement.MeasureEntanglement", OperationFunctor.Body, _args);
                var __result__ = default((Int64,Int64));
                try
                {
#line 11 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                    var countSame = 0L;
#line 12 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                    var countDiff = 0L;
#line 13 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                    var count = 1000L;
#line 14 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                    var qubits = Allocate.Apply(2L);
#line 16 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                    foreach (var i in new Range(1L, count))
                    {
                        // Apply hadamard on qubit1
#line 19 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
                        // Apply CNOT to entangle both qubits
#line 22 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
                        // Measure and compare states
#line 25 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                        if ((M.Apply<Result>(qubits[0L]) == M.Apply<Result>(qubits[1L])))
                        {
#line 27 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                            countSame = (countSame + 1L);
                        }
                        else
                        {
#line 31 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                            countDiff = (countDiff + 1L);
                        }

#line 34 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = (countSame, countDiff);
#line 38 "C:\\code\\github\\GarageDev\\Entanglement\\Entanglement\\Operation.qs"
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

        public static System.Threading.Tasks.Task<(Int64,Int64)> Run(IOperationFactory __m__)
        {
            return __m__.Run<MeasureEntanglement, QVoid, (Int64,Int64)>(QVoid.Instance);
        }
    }
}
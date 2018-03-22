#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.Teleport", "Set (incoming : Qubit, target : Result) : ()", new string[] { }, "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs", 207L, 8L, 2L)]
[assembly: OperationDeclaration("Quantum.Teleport", "Teleport () : Int", new string[] { }, "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs", 348L, 20L, 5L)]
#line hidden
namespace Quantum.Teleport
{
    public class Set : Operation<(Qubit,Result), QVoid>
    {
        public Set(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<(Qubit,Result), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Teleport.Set", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (incoming,target) = _args;
#line 11 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var x = M.Apply<Result>(incoming);
#line 12 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    if ((x != target))
                    {
#line 14 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        MicrosoftQuantumPrimitiveX.Apply(incoming);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Teleport.Set", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Qubit incoming, Result target)
        {
            return __m__.Run<Set, (Qubit,Result), QVoid>((incoming, target));
        }
    }

    public class Teleport : Operation<QVoid, Int64>
    {
        public Teleport(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.Allocate), typeof(Microsoft.Quantum.Extensions.Math.ArcCos), typeof(Microsoft.Quantum.Primitive.CNOT), typeof(Microsoft.Quantum.Primitive.H), typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.Release), typeof(Microsoft.Quantum.Primitive.ResetAll), typeof(Microsoft.Quantum.Primitive.Rx), typeof(Quantum.Teleport.Set), typeof(Microsoft.Quantum.Extensions.Math.Sqrt), typeof(Microsoft.Quantum.Primitive.X), typeof(Microsoft.Quantum.Primitive.Z) };
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

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathArcCos
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.ArcCos>();
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

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveRx
        {
            get
            {
                return this.Factory.Get<IUnitary<(Double,Qubit)>, Microsoft.Quantum.Primitive.Rx>();
            }
        }

        protected ICallable<(Qubit,Result), QVoid> Set
        {
            get
            {
                return this.Factory.Get<ICallable<(Qubit,Result), QVoid>, Quantum.Teleport.Set>();
            }
        }

        protected ICallable<Double, Double> MicrosoftQuantumExtensionsMathSqrt
        {
            get
            {
                return this.Factory.Get<ICallable<Double, Double>, Microsoft.Quantum.Extensions.Math.Sqrt>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveZ
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.Z>();
            }
        }

        public override Func<QVoid, Int64> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.Teleport.Teleport", OperationFunctor.Body, _args);
                var __result__ = default(Int64);
                try
                {
#line 23 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var m = 0L;
#line 24 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var qubits = Allocate.Apply(3L);
#line 26 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var message = qubits[0L];
#line 27 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var alice = qubits[1L];
#line 28 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var bob = qubits[2L];
#line 30 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    var count = 1000L;
#line 31 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    foreach (var i in new Range(1L, count))
                    {
#line 33 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        Set.Apply((message, Result.Zero));
#line 34 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        var degree = (2D * MicrosoftQuantumExtensionsMathArcCos.Apply<Double>(MicrosoftQuantumExtensionsMathSqrt.Apply<Double>((1D / 4D))));
#line 35 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        MicrosoftQuantumPrimitiveRx.Apply((degree, message));
                        //entangle the two qubits
#line 38 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(alice);
#line 39 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((alice, bob));
                        //combine the 3 qubits
#line 42 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        MicrosoftQuantumPrimitiveCNOT.Apply((message, alice));
#line 43 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        MicrosoftQuantumPrimitiveH.Apply(message);
#line 45 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        if ((M.Apply<Result>(message) == Result.One))
                        {
#line 45 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                            MicrosoftQuantumPrimitiveZ.Apply(bob);
                        }

#line 46 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        if ((M.Apply<Result>(alice) == Result.One))
                        {
#line 46 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                            MicrosoftQuantumPrimitiveX.Apply(bob);
                        }

#line 48 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        var x = M.Apply<Result>(bob);
#line 49 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        if ((x == Result.One))
                        {
#line 51 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                            m = (m + 1L);
                        }

#line 54 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                        ResetAll.Apply(qubits);
                    }

#line hidden
                    Release.Apply(qubits);
#line hidden
                    __result__ = m;
#line 58 "C:\\code\\github\\GarageDev\\Teleport\\Teleport\\Operation.qs"
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.Teleport.Teleport", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__)
        {
            return __m__.Run<Teleport, QVoid, Int64>(QVoid.Instance);
        }
    }
}
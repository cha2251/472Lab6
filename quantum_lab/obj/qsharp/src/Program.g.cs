//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"Main\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":14,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"Main\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":15,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":15}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"RandomIntArray\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":27},\"Item2\":{\"Line\":1,\"Column\":32}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Int\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"RandomIntArray\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":43,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":25}},\"Documentation\":[]}")]
#line hidden
namespace quantum_lab
{
    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 16, 44)]
    public partial class Main : Operation<QVoid, QVoid>, ICallable
    {
        public Main(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "Main";
        String ICallable.FullName => "quantum_lab.Main";
        public static EntryPointInfo<QVoid, QVoid> Info => new EntryPointInfo<QVoid, QVoid>(typeof(Main));
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected ICallable<Int64, IQArray<Int64>> RandomIntArray__
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 17 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                var qs = Allocate__.Apply(16L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 19 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var biasesHermione = (IQArray<Int64>)RandomIntArray__.Apply(qs.Length);
#line 20 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var bitsHermione = (IQArray<Int64>)RandomIntArray__.Apply(qs.Length);
#line 23 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var biasesHarry = (IQArray<Int64>)RandomIntArray__.Apply(qs.Length);
#line 25 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var bitsHarry = (IQArray<Int64>)RandomIntArray__.Apply(qs.Length);
#line 27 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Hermione's biases: {0}", biasesHermione));
#line 28 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Hermione's bits: {0}", bitsHermione));
#line 29 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Harry's biases: {0}", biasesHarry));
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(qs);
                    }
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.RandomIntArray__ = this.__Factory__.Get<ICallable<Int64, IQArray<Int64>>>(typeof(RandomIntArray));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Main, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 44, -1)]
    public partial class RandomIntArray : Operation<Int64, IQArray<Int64>>, ICallable
    {
        public RandomIntArray(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomIntArray";
        String ICallable.FullName => "quantum_lab.RandomIntArray";
        protected ICallable<Double, Boolean> Microsoft__Quantum__Random__DrawRandomBool
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<Int64>> __Body__ => (__in__) =>
        {
            var count = __in__;
#line 45 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
#line hidden
            var __arg1__ = 0L;
#line 45 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            var array = new QArray<Int64>(QArray.Filled(() => __arg1__, count));
#line 46 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            foreach (var i in new QRange(0L, (count - 1L)))
#line hidden
            {
#line 47 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if (Microsoft__Quantum__Random__DrawRandomBool.Apply(0.5D))
                {
#line 48 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    array.Modify(i, 1L);
                }
            }

#line 51 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            return array;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Random__DrawRandomBool = this.__Factory__.Get<ICallable<Double, Boolean>>(typeof(global::Microsoft.Quantum.Random.DrawRandomBool));
        }

        public override IApplyData __DataIn__(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __DataOut__(IQArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Int64>> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<RandomIntArray, Int64, IQArray<Int64>>(count);
        }
    }
}
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
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"PrepareQubitsHermione\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":39}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"biases\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":51},\"Item2\":{\"Line\":1,\"Column\":57}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"bits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":67},\"Item2\":{\"Line\":1,\"Column\":71}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"PrepareQubitsHermione\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":54,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":32}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"MeasureQubits\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"qubits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":25},\"Item2\":{\"Line\":1,\"Column\":31}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"biases\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":43},\"Item2\":{\"Line\":1,\"Column\":49}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"MeasureQubits\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":65,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":24}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"RandomBoolArray\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"count\"]},\"Type\":{\"Case\":\"Int\"},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":28},\"Item2\":{\"Line\":1,\"Column\":33}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"Int\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"RandomBoolArray\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":74,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":26}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"GenerateSharedKey\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":84,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"biasesHermione\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":29},\"Item2\":{\"Line\":1,\"Column\":43}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"biasesHarry\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":54},\"Item2\":{\"Line\":1,\"Column\":65}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"measuredBits\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":76},\"Item2\":{\"Line\":1,\"Column\":88}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"GenerateSharedKey\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":84,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"quantum_lab\",\"Name\":\"CountMismatchedBits\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"hermioneKey\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":31},\"Item2\":{\"Line\":1,\"Column\":42}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"harryKey\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":53},\"Item2\":{\"Line\":1,\"Column\":61}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Bool\"}]}]]},\"ReturnType\":{\"Case\":\"Int\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"quantum_lab\",\"Name\":\"CountMismatchedBits\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Carter\\\\Desktop\\\\College\\\\CSEC_472\\\\472Lab6\\\\quantum_lab\\\\Program.qs\",\"Position\":{\"Item1\":94,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":30}},\"Documentation\":[]}")]
#line hidden
namespace quantum_lab
{
    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 16, 55)]
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

        protected ICallable<Int64, IQArray<Boolean>> RandomBoolArray__
        {
            get;
            set;
        }

        protected ICallable Length__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid> PrepareQubitsHermione__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Boolean>), IQArray<Boolean>> MeasureQubits__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>), IQArray<Boolean>> GenerateSharedKey__
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Boolean>,IQArray<Boolean>), Int64> CountMismatchedBits__
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> Microsoft__Quantum__Bitwise__Xor
        {
            get;
            set;
        }

        protected ICallable<IQArray<Boolean>, Int64> Microsoft__Quantum__Convert__BoolArrayAsInt
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 17 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                var qubits = Allocate__.Apply(16L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line 19 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var biasesHermione = (IQArray<Boolean>)RandomBoolArray__.Apply(qubits.Length);
#line 20 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var bitsHermione = (IQArray<Boolean>)RandomBoolArray__.Apply(qubits.Length);
#line 22 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    PrepareQubitsHermione__.Apply((qubits, biasesHermione, bitsHermione));
#line 25 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var biasesHarry = (IQArray<Boolean>)RandomBoolArray__.Apply(qubits.Length);
#line 26 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var bitsHarry = (IQArray<Boolean>)MeasureQubits__.Apply((qubits, biasesHarry));
#line 29 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var hermioneKey = (IQArray<Boolean>)GenerateSharedKey__.Apply((biasesHermione, biasesHarry, bitsHermione));
#line 30 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var harryKey = (IQArray<Boolean>)GenerateSharedKey__.Apply((biasesHermione, biasesHarry, bitsHarry));
#line 32 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var mismatches = CountMismatchedBits__.Apply((hermioneKey, harryKey));
#line 33 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    if ((mismatches > 2L))
                    {
#line 34 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                        Message__.Apply("Harry and Hermione are not compatible.");
                    }
                    else
                    {
#line 36 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                        Message__.Apply("Harry and Hermione are compatible.");
                    }

#line 39 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var toEncrypt = 472L;
#line 40 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var encrypted = Microsoft__Quantum__Bitwise__Xor.Apply((Microsoft__Quantum__Convert__BoolArrayAsInt.Apply(hermioneKey), toEncrypt));
#line 41 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    var decrypted = Microsoft__Quantum__Bitwise__Xor.Apply((encrypted, Microsoft__Quantum__Convert__BoolArrayAsInt.Apply(harryKey)));
#line 42 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Message  : {0}", toEncrypt));
#line 43 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Encrypted: {0}", encrypted));
#line 44 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Decrypted: {0}", decrypted));
#line 46 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply("----------------DEBUG----------------");
#line 47 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Hermione's biases: {0}", biasesHermione));
#line 48 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Hermione's bits: {0}", bitsHermione));
#line 49 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Harry's biases: {0}", biasesHarry));
#line 50 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Hermione's key: {0}", hermioneKey));
#line 51 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Message__.Apply(String.Format("Harry's key: {0}", harryKey));
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
                        Release__.Apply(qubits);
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
            this.RandomBoolArray__ = this.__Factory__.Get<ICallable<Int64, IQArray<Boolean>>>(typeof(RandomBoolArray));
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.PrepareQubitsHermione__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid>>(typeof(PrepareQubitsHermione));
            this.MeasureQubits__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,IQArray<Boolean>), IQArray<Boolean>>>(typeof(MeasureQubits));
            this.GenerateSharedKey__ = this.__Factory__.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>), IQArray<Boolean>>>(typeof(GenerateSharedKey));
            this.CountMismatchedBits__ = this.__Factory__.Get<ICallable<(IQArray<Boolean>,IQArray<Boolean>), Int64>>(typeof(CountMismatchedBits));
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Microsoft__Quantum__Bitwise__Xor = this.__Factory__.Get<ICallable<(Int64,Int64), Int64>>(typeof(global::Microsoft.Quantum.Bitwise.Xor));
            this.Microsoft__Quantum__Convert__BoolArrayAsInt = this.__Factory__.Get<ICallable<IQArray<Boolean>, Int64>>(typeof(global::Microsoft.Quantum.Convert.BoolArrayAsInt));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<Main, QVoid, QVoid>(QVoid.Instance);
        }
    }

    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 55, 66)]
    public partial class PrepareQubitsHermione : Operation<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid>, ICallable
    {
        public PrepareQubitsHermione(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "PrepareQubitsHermione";
        String ICallable.FullName => "quantum_lab.PrepareQubitsHermione";
        protected ICallable Length__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid> __Body__ => (__in__) =>
        {
            var (qubits,biases,bits) = __in__;
#line 56 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            foreach (var i in new QRange(0L, (qubits.Length - 1L)))
#line hidden
            {
#line 57 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if (biases[i])
                {
#line 58 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(qubits[i]);
                }

#line 60 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if (bits[i])
                {
#line 61 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(qubits[i]);
                }
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> qubits, IQArray<Boolean> biases, IQArray<Boolean> bits)
        {
            return __m__.Run<PrepareQubitsHermione, (IQArray<Qubit>,IQArray<Boolean>,IQArray<Boolean>), QVoid>((qubits, biases, bits));
        }
    }

    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 66, 75)]
    public partial class MeasureQubits : Operation<(IQArray<Qubit>,IQArray<Boolean>), IQArray<Boolean>>, ICallable
    {
        public MeasureQubits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return ((IApplyData)Data.Item1)?.Qubits;
                }
            }
        }

        String ICallable.Name => "MeasureQubits";
        String ICallable.FullName => "quantum_lab.MeasureQubits";
        protected ICallable Length__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<IQArray<Result>, IQArray<Boolean>> Microsoft__Quantum__Convert__ResultArrayAsBoolArray
        {
            get;
            set;
        }

        protected ICallable<IQArray<Qubit>, IQArray<Result>> Microsoft__Quantum__Measurement__MultiM
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Boolean>), IQArray<Boolean>> __Body__ => (__in__) =>
        {
            var (qubits,biases) = __in__;
#line 67 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            foreach (var i in new QRange(0L, (qubits.Length - 1L)))
#line hidden
            {
#line 68 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if (biases[i])
                {
#line 69 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    Microsoft__Quantum__Intrinsic__X.Apply(qubits[i]);
                }
            }

#line 72 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            return Microsoft__Quantum__Convert__ResultArrayAsBoolArray.Apply(Microsoft__Quantum__Measurement__MultiM.Apply(qubits));
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Microsoft__Quantum__Convert__ResultArrayAsBoolArray = this.__Factory__.Get<ICallable<IQArray<Result>, IQArray<Boolean>>>(typeof(global::Microsoft.Quantum.Convert.ResultArrayAsBoolArray));
            this.Microsoft__Quantum__Measurement__MultiM = this.__Factory__.Get<ICallable<IQArray<Qubit>, IQArray<Result>>>(typeof(global::Microsoft.Quantum.Measurement.MultiM));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __DataOut__(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, IQArray<Qubit> qubits, IQArray<Boolean> biases)
        {
            return __m__.Run<MeasureQubits, (IQArray<Qubit>,IQArray<Boolean>), IQArray<Boolean>>((qubits, biases));
        }
    }

    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 75, 85)]
    public partial class RandomBoolArray : Operation<Int64, IQArray<Boolean>>, ICallable
    {
        public RandomBoolArray(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "RandomBoolArray";
        String ICallable.FullName => "quantum_lab.RandomBoolArray";
        protected ICallable<Double, Boolean> Microsoft__Quantum__Random__DrawRandomBool
        {
            get;
            set;
        }

        public override Func<Int64, IQArray<Boolean>> __Body__ => (__in__) =>
        {
            var count = __in__;
#line 76 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
#line hidden
            var __arg1__ = false;
#line 76 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            var array = new QArray<Boolean>(QArray.Filled(() => __arg1__, count));
#line 77 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            foreach (var i in new QRange(0L, (count - 1L)))
#line hidden
            {
#line 78 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if (Microsoft__Quantum__Random__DrawRandomBool.Apply(0.5D))
                {
#line 79 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    array.Modify(i, true);
                }
            }

#line 82 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            return array;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Random__DrawRandomBool = this.__Factory__.Get<ICallable<Double, Boolean>>(typeof(global::Microsoft.Quantum.Random.DrawRandomBool));
        }

        public override IApplyData __DataIn__(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __DataOut__(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, Int64 count)
        {
            return __m__.Run<RandomBoolArray, Int64, IQArray<Boolean>>(count);
        }
    }

    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 85, 95)]
    public partial class GenerateSharedKey : Operation<(IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>), IQArray<Boolean>>, ICallable
    {
        public GenerateSharedKey(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "GenerateSharedKey";
        String ICallable.FullName => "quantum_lab.GenerateSharedKey";
        protected ICallable Length__
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>), IQArray<Boolean>> __Body__ => (__in__) =>
        {
            var (biasesHermione,biasesHarry,measuredBits) = __in__;
#line 86 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            var sharedKey = new QArray<Boolean>();
#line 87 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            foreach (var i in new QRange(0L, (biasesHermione.Length - 1L)))
#line hidden
            {
#line 88 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if ((biasesHermione[i] == biasesHarry[i]))
                {
#line 89 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    sharedKey = QArray<Boolean>.Add(sharedKey, new QArray<Boolean>(measuredBits[i]));
                }
            }

#line 92 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            return sharedKey;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __DataIn__((IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __DataOut__(IQArray<Boolean> data) => data;
        public static System.Threading.Tasks.Task<IQArray<Boolean>> Run(IOperationFactory __m__, IQArray<Boolean> biasesHermione, IQArray<Boolean> biasesHarry, IQArray<Boolean> measuredBits)
        {
            return __m__.Run<GenerateSharedKey, (IQArray<Boolean>,IQArray<Boolean>,IQArray<Boolean>), IQArray<Boolean>>((biasesHermione, biasesHarry, measuredBits));
        }
    }

    [SourceLocation("C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs", OperationFunctor.Body, 95, -1)]
    public partial class CountMismatchedBits : Operation<(IQArray<Boolean>,IQArray<Boolean>), Int64>, ICallable
    {
        public CountMismatchedBits(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Boolean>,IQArray<Boolean>)>, IApplyData
        {
            public In((IQArray<Boolean>,IQArray<Boolean>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "CountMismatchedBits";
        String ICallable.FullName => "quantum_lab.CountMismatchedBits";
        protected ICallable Length__
        {
            get;
            set;
        }

        public override Func<(IQArray<Boolean>,IQArray<Boolean>), Int64> __Body__ => (__in__) =>
        {
            var (hermioneKey,harryKey) = __in__;
#line 96 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            var mismatches = 0L;
#line 97 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            foreach (var i in new QRange(0L, (hermioneKey.Length - 1L)))
#line hidden
            {
#line 98 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                if ((hermioneKey[i] != harryKey[i]))
                {
#line 99 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
                    mismatches = (mismatches + 1L);
                }
            }

#line 102 "C:\\Users\\Carter\\Desktop\\College\\CSEC_472\\472Lab6\\quantum_lab\\Program.qs"
            return mismatches;
        }

        ;
        public override void __Init__()
        {
            this.Length__ = this.__Factory__.Get<ICallable>(typeof(global::Microsoft.Quantum.Core.Length<>));
        }

        public override IApplyData __DataIn__((IQArray<Boolean>,IQArray<Boolean>) data) => new In(data);
        public override IApplyData __DataOut__(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, IQArray<Boolean> hermioneKey, IQArray<Boolean> harryKey)
        {
            return __m__.Run<CountMismatchedBits, (IQArray<Boolean>,IQArray<Boolean>), Int64>((hermioneKey, harryKey));
        }
    }
}
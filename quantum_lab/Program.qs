namespace quantum_lab {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Arrays;
    open Microsoft.Quantum.Measurement;
    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Diagnostics;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    open Microsoft.Quantum.Math;
    open Microsoft.Quantum.Random;
    open Microsoft.Quantum.Bitwise;
    
    @EntryPoint()
    operation Main() : Unit {
        use qubits = Qubit[16];

        let biasesHermione = RandomIntArray(Length(qubits));
        let bitsHermione = RandomIntArray(Length(qubits));

        PrepareQubitsHermione(qubits, biasesHermione, bitsHermione);

        //Harry guesses at the biases
        let biasesHarry = RandomIntArray(Length(qubits));
        let bitsHarry = MeasureQubits(qubits, biasesHarry);

        Message($"Hermione's biases: {biasesHermione}");
        Message($"Hermione's bits: {bitsHermione}");
        Message($"Harry's biases: {biasesHarry}");
    }

    // ChatGPTd this bit. Pretty sure the gates are right?
    operation PrepareQubitsHermione(qubits : Qubit[], biases: Int[], bits: Int[]) : Unit {
        for i in 0..Length(qubits) - 1 {
            if biases[i] == 1{
                X(qubits[i]);
            }
            if bits[i] == 1{
                H(qubits[i]);
            }
        }
    }

    operation MeasureQubits(qubits : Qubit[], biases : Int[]): Bool[]{
        for i in 0..Length(qubits) - 1 {
            if biases[i] == 1{
                X(qubits[i]);
            }
        }
        return ResultArrayAsBoolArray(MultiM(qubits));
    }

    operation RandomIntArray (count : Int) : Int[] {
        mutable array = [0, size=count];
        for i in 0 .. count - 1 {
            if DrawRandomBool(0.5) {
                set array w/= i <- 1;
            }
        }
        return array;
    }
}

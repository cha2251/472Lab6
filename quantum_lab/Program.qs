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
        use qs = Qubit[16];

        let biasesHermione = RandomIntArray(Length(qs));
        let bitsHermione = RandomIntArray(Length(qs));

        //Harry guesses at the biases
        let biasesHarry = RandomIntArray(Length(qs));
        //Send bits to harry
        let bitsHarry = RandomIntArray(Length(qs));

        Message($"Hermione's biases: {biasesHermione}");
        Message($"Hermione's bits: {bitsHermione}");
        Message($"Harry's biases: {biasesHarry}");
    }

    // ChatGPTd this bit. Pretty sure the gates are right?
    operation PrepareQubitsHermione(qubits : Qubit[], biases: Bool[], bits: Bool[]) : Unit {
        for i in 0..Length(qubits) - 1 {
            if biases[i] {
                X(qubits[i]);
            }
            if bits[i] {
                H(qubits[i]);
            }
        }
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

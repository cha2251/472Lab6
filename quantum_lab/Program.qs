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
        let evesdrop = false;
        use qubits = Qubit[16];

        let biasesHermione = RandomBoolArray(Length(qubits));
        let bitsHermione = RandomBoolArray(Length(qubits));

        PrepareQubitsHermione(qubits, biasesHermione, bitsHermione);

        if evesdrop {
            // He Who Shall Not Be Named guesses at qubits and passes them along
            let biasesVoldy = RandomBoolArray(Length(qubits));
            let bitsVoldy = MeasureQubits(qubits, biasesVoldy);
            Message($"Voldy's biases: {biasesVoldy}");
            Message($"Voldy's measuerments: {bitsVoldy}");
        }

        //Harry guesses at the biases
        let biasesHarry = RandomBoolArray(Length(qubits));
        let bitsHarry = MeasureQubits(qubits, biasesHarry);

        //Gen keys
        let hermioneKey = GenerateSharedKey(biasesHermione, biasesHarry, bitsHermione);
        let harryKey = GenerateSharedKey(biasesHermione, biasesHarry, bitsHarry);

        let mismatches = CountMismatchedBits(hermioneKey, harryKey);
        if mismatches > 2 {
            Message("Harry and Hermione are not compatible.");
        } else {
            Message("Harry and Hermione are compatible.");
        }

        let toEncrypt = 472;
        let encrypted = Xor(BoolArrayAsInt(hermioneKey), toEncrypt);
        let decrypted = Xor(encrypted, BoolArrayAsInt(harryKey));
        Message($"Message  : {toEncrypt}");
        Message($"Encrypted: {encrypted}");
        Message($"Decrypted: {decrypted}");

        if CountMismatchedNumbers(encrypted, decrypted) > 2 {
            Message("VITM Detected!");
        }

        Message($"----------------DEBUG----------------");
        Message($"Hermione's biases: {biasesHermione}");
        Message($"Hermione's bits: {bitsHermione}");
        Message($"Harry's biases: {biasesHarry}");
        Message($"Hermione's key: {hermioneKey}");
        Message($"Harry's key: {harryKey}");
    }

    // ChatGPTd this bit. Pretty sure the gates are right?
    operation PrepareQubitsHermione(qubits : Qubit[], biases: Bool[], bits: Bool[]) : Unit {
        for i in 0..Length(qubits) - 1 {
            if biases[i]{
                X(qubits[i]);
            }
            if bits[i]{
                H(qubits[i]);
            }
        }
    }

    operation MeasureQubits(qubits : Qubit[], biases : Bool[]): Bool[]{
        for i in 0..Length(qubits) - 1 {
            if biases[i]{
                X(qubits[i]);
            }
        }
        return ResultArrayAsBoolArray(MultiM(qubits));
    }

    operation RandomBoolArray (count : Int) : Bool[] {
        mutable array = [false, size=count];
        for i in 0 .. count - 1 {
            if DrawRandomBool(0.5) {
                set array w/= i <- true;
            }
        }
        return array;
    }

    operation GenerateSharedKey(biasesHermione : Bool[], biasesHarry : Bool[], measuredBits : Bool[]) : Bool[] {
        mutable sharedKey = [];
        for i in 0..Length(biasesHermione) - 1 {
            if biasesHermione[i] == biasesHarry[i] {
                set sharedKey += [measuredBits[i]];
            }
        }
        return sharedKey;
    }

    operation CountMismatchedBits(hermioneKey : Bool[], harryKey : Bool[]) : Int {
        mutable mismatches = 0;
        for i in 0..Length(hermioneKey) - 1 {
            if hermioneKey[i] != harryKey[i] {
                set mismatches += 1;
            }
        }
        return mismatches;
    }

    operation CountMismatchedNumbers(encrypted : Int, decrypted : Int) : Int {
        mutable mismatches = 0;
        let encyrptBits = IntAsBoolArray(encrypted,16);
        let decyrptBits = IntAsBoolArray(decrypted,16);
        for i in 0..Length(encyrptBits) - 1 {
            if encyrptBits[i] != decyrptBits[i] {
                set mismatches += 1;
            }
        }
        return mismatches;
    }
}

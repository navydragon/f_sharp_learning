module Task20

// 49.5.1
let even_seq = Seq.initInfinite (fun i -> 2 * (i + 1))

// 49.5.2
let fac_seq = Seq.initInfinite (fun n -> List.fold (*) 1 [1..n])

// 49.5.3
let seq_seq =
    Seq.initInfinite (fun i ->
        if i = 0 then 0
        elif i % 2 = 1 then -((i + 1) / 2)
        else i / 2)

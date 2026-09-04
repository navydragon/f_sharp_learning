module Task21

// 50.2.1
let fac_seq = seq {
    let mutable f = 1
    yield f
    for n in 1 .. System.Int32.MaxValue do
        f <- f * n
        yield f
}

// 50.2.2
let seq_seq = seq {
    yield 0
    for n in 1 .. System.Int32.MaxValue do
        yield -n
        yield n
}

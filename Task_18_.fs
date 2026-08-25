module Task17

// 47.4.1
let f n =
    let mutable result = 1
    let mutable i = 1
    while i <= n do
        result <- result * i
        i <- i + 1
    result

// 47.4.2
let fibo n =
    let mutable a = 0
    let mutable b = 1
    let mutable i = 0
    while i < n do
        let next = a + b
        a <- b
        b <- next
        i <- i + 1
    a

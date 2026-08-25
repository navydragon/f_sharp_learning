module Task17

// 43.3
let try_find key m =
    if Map.containsKey key m then Some (Map.find key m) else None

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

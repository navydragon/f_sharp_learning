module Task5

// 16.1
let notDivisible (n, m) = m % n <> 0

// 16.2
let prime = function
| n when n <= 1 -> false
| n ->
    let rec check = function
    | d when d >= n -> true
    | d when notDivisible (d, n) -> check (d + 1)
    | _ -> false
    check 2

module Task12

// 34.1
let rec upto = function
    | n when n <= 0 -> []
    | n -> upto (n - 1) @ [n]

// 34.2
let rec dnto = function
    | n when n <= 0 -> []
    | n -> n :: dnto (n - 1)

// 34.3
let evenn n =
    let rec loop (current, acc) =
        if current < 0 then acc
        else loop (current - 1, (2 * current) :: acc)

    if n <= 0 then []
    else loop (n - 1, [])

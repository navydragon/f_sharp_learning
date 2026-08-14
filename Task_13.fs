module Task13

// 39.1
let rec rmodd = function
    | [] -> []
    | [_] -> []
    | _ :: x :: xs -> x :: rmodd xs

// 39.2
let rec del_even = function
    | [] -> []
    | x :: xs when x % 2 = 0 -> del_even xs
    | x :: xs -> x :: del_even xs

// 39.3
let rec multiplicity x xs =
    match xs with
    | [] -> 0
    | y :: ys when y = x -> 1 + multiplicity x ys
    | _ :: ys -> multiplicity x ys

// 39.4
let rec split = function
    | [] -> ([], [])
    | [x] -> ([x], [])
    | x :: y :: rest ->
        let xs, ys = split rest
        (x :: xs, y :: ys)

// 39.5
let rec zip (xs1, xs2) =
    match xs1, xs2 with
    | [], [] -> []
    | x :: xs, y :: ys -> (x, y) :: zip (xs, ys)
    | _ -> failwith "Длины списков не совпадают"

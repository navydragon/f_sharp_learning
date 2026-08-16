module Task14

// 40.1
let rec sum (p, xs) =
    match xs with
    | [] -> 0
    | x :: xs' when p x -> x + sum (p, xs')
    | _ :: xs' -> sum (p, xs')

// 40.2.1 
let rec count (xs, n) =
    match xs with
    | [] -> 0
    | x :: xs' when x < n -> count (xs', n)
    | x :: xs' when x = n -> 1 + count (xs', n)
    | _ -> 0

// 40.2.2
let rec insert (xs, n) =
    match xs with
    | [] -> [n]
    | x :: _ when n <= x -> n :: xs
    | x :: xs' -> x :: insert (xs', n)

// 40.2.3
let rec intersect (xs1, xs2) =
    match xs1, xs2 with
    | [], _ | _, [] -> []
    | x :: xs1', y :: xs2' when x = y -> x :: intersect (xs1', xs2')
    | x :: xs1', y :: _ when x < y -> intersect (xs1', xs2)
    | _, _ :: xs2' -> intersect (xs1, xs2')

// 40.2.4
let rec plus (xs1, xs2) =
    match xs1, xs2 with
    | [], ys -> ys
    | xs, [] -> xs
    | x :: xs1', y :: _ when x <= y -> x :: plus (xs1', xs2)
    | _, y :: xs2' -> y :: plus (xs1, xs2')

// 40.2.5
let rec minus (xs1, xs2) =
    match xs1, xs2 with
    | [], _ -> []
    | xs, [] -> xs
    | x :: xs1', y :: xs2' when x = y -> minus (xs1', xs2')
    | x :: xs1', y :: _ when x < y -> x :: minus (xs1', xs2)
    | _, _ :: xs2' -> minus (xs1, xs2')

// 40.3.1
let rec smallest = function
    | [] -> None
    | [x] -> Some x
    | x :: xs ->
        match smallest xs with
        | None -> Some x
        | Some y when x <= y -> Some x
        | Some y -> Some y

// 40.3.2
let rec delete (n, xs) =
    match xs with
    | [] -> []
    | x :: xs' when x = n -> xs'
    | x :: xs' -> x :: delete (n, xs')

// 40.3.3
let rec sort = function
    | [] -> []
    | xs ->
        match smallest xs with
        | None -> []
        | Some m -> m :: sort (delete (m, xs))

// 40.4
let rec revrev = function
    | [] -> []
    | xs :: xss -> revrev xss @ [List.rev xs]

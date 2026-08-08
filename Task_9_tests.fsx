#load "Task_9.fs"
open Task9

let inline assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- 1 ---"
assertEqual "(1,0,128) .+. (0,0,0)" (1, 10, 8) ((1, 0, 128) .+. (0, 0, 0))
assertEqual "(1,0,0) .-. (0,0,1)" (0, 19, 11) ((1, 0, 0) .-. (0, 0, 1))
assertEqual "(1,19,11) .+. (0,0,1)" (2, 0, 0) ((1, 19, 11) .+. (0, 0, 1))
assertEqual "(32,23,5) .+. 0" (33, 3, 5) ((32, 23, 5) .+. (0, 0, 0))
assertEqual "no debt" (0, 0, 0) ((0, 0, 5) .-. (0, 0, 10))

printfn "--- 2 ---"
assertEqual "(1,2) .+ (3,4)" (4.0, 6.0) ((1.0, 2.0) .+ (3.0, 4.0))
assertEqual "(1,2) .* (3,4)" (-5.0, 10.0) ((1.0, 2.0) .* (3.0, 4.0))
assertEqual "(1,2) .- (3,4)" (-2.0, -2.0) ((1.0, 2.0) .- (3.0, 4.0))

let divResult = (1.0, 2.0) ./ (1.0, 0.0)
assertEqual "(1,2) ./ (1,0)" (1.0, 2.0) divResult

let z = (3.0, 4.0)
let inv = (1.0, 0.0) ./ z
let product = z .* inv
let nearOne =
    abs (fst product - 1.0) < 1e-10 && abs (snd product) < 1e-10
assertEqual "z .* (1/z) ~ (1,0)" true nearOne

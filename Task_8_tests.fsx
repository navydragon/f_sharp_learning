#load "Task_8.fs"
open Task8

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- curry ---"
let addPair (x, y) = x + y
let subPair (x, y) = x - y
assertEqual "curry add (2, 3)" 5 ((curry addPair) 2 3)
assertEqual "curry sub (10, 4)" 6 ((curry subPair) 10 4)

printfn "--- uncurry ---"
let addCurried x y = x + y
let mulCurried x y = x * y
assertEqual "uncurry add (2, 3)" 5 ((uncurry addCurried) (2, 3))
assertEqual "uncurry mul (4, 5)" 20 ((uncurry mulCurried) (4, 5))

printfn "--- roundtrip ---"
assertEqual "uncurry (curry addPair)" 9 ((uncurry (curry addPair)) (4, 5))
assertEqual "curry (uncurry addCurried)" 9 ((curry (uncurry addCurried)) 4 5)

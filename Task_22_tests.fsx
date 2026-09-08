#load "Task_22.fs"
open Task22

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

let rec nat (n:int) : int cell = Cons (n, lazy(nat(n+1)))
let n0 = nat 0

printfn "--- nth ---"
assertEqual "nth 0" 0 (nth n0 0)
assertEqual "nth 1" 1 (nth n0 1)
assertEqual "nth 2" 2 (nth n0 2)
assertEqual "nth 5" 5 (nth n0 5)
assertEqual "nth 10" 10 (nth n0 10)
assertEqual "nth 100" 100 (nth n0 100)
assertEqual "nth 1000" 1000 (nth n0 1000)
assertEqual "nth 30000" 30000 (nth n0 30000)

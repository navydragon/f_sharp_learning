#load "Task_17.fs"
open Task17

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- f (factorial) ---"
assertEqual "f 0" 1 (f 0)
assertEqual "f 1" 1 (f 1)
assertEqual "f 2" 2 (f 2)
assertEqual "f 3" 6 (f 3)
assertEqual "f 4" 24 (f 4)
assertEqual "f 5" 120 (f 5)
assertEqual "f 6" 720 (f 6)

printfn "--- fibo ---"
assertEqual "fibo 0" 0 (fibo 0)
assertEqual "fibo 1" 1 (fibo 1)
assertEqual "fibo 2" 1 (fibo 2)
assertEqual "fibo 3" 2 (fibo 3)
assertEqual "fibo 4" 3 (fibo 4)
assertEqual "fibo 5" 5 (fibo 5)
assertEqual "fibo 6" 8 (fibo 6)
assertEqual "fibo 7" 13 (fibo 7)
assertEqual "fibo 10" 55 (fibo 10)

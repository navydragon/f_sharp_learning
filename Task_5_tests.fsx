#load "Task_5.fs"
open Task5

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- notDivisible ---"
assertEqual "2 делит 4"     true  (notDivisible (2, 4))
assertEqual "2 не делит 5"  false (notDivisible (2, 5))
assertEqual "3 не делит 10" false (notDivisible (3, 10))
assertEqual "5 делит 25"    true  (notDivisible (5, 25))
assertEqual "1 делит 7"     true  (notDivisible (1, 7))

printfn "--- prime ---"
assertEqual "1 не простое"  false (prime 1)
assertEqual "0 не простое"  false (prime 0)
assertEqual "-3 не простое" false (prime -3)
assertEqual "2 простое"     true  (prime 2)
assertEqual "3 простое"     true  (prime 3)
assertEqual "4 не простое"  false (prime 4)
assertEqual "9 не простое"  false (prime 9)
assertEqual "17 простое"    true  (prime 17)
assertEqual "25 не простое" false (prime 25)
assertEqual "97 простое"    true  (prime 97)

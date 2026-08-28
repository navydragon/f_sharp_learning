#load "Task_48.fs"
open Task48

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- fibo1 ---"
assertEqual "fibo1 6 1 0" 8 (fibo1 6 1 0)
assertEqual "fibo1 6 5 3" 55 (fibo1 6 5 3)
assertEqual "fibo1 0 1 0" 0 (fibo1 0 1 0)
assertEqual "fibo1 1 1 0" 1 (fibo1 1 1 0)
assertEqual "fibo1 10 1 0" 55 (fibo1 10 1 0)

printfn "--- fibo2 ---"
assertEqual "fibo2 6 id" 8 (fibo2 6 id)
assertEqual "fibo2 0 id" 0 (fibo2 0 id)
assertEqual "fibo2 1 id" 1 (fibo2 1 id)
assertEqual "fibo2 10 id" 55 (fibo2 10 id)

printfn "--- bigList ---"
let list100 = bigList 100 id
assertEqual "bigList 100 length" 100 list100.Length
assertEqual "bigList 100 all ones" true (List.forall ((=) 1) list100)

let list1000 = bigList 1000 id
assertEqual "bigList 1000 length" 1000 list1000.Length

printfn "--- bigList 230000 (stack test) ---"
try
    let list230k = bigList 230000 id
    printfn "OK   bigList 230000 length = %d" list230k.Length
with
| :? System.StackOverflowException ->
    printfn "FAIL bigList 230000 StackOverflow"

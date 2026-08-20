#load "Task_16.fs"
open Task16

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- allSubsets ---"
assertEqual "3 choose 2"
    (set [set [1; 2]; set [1; 3]; set [2; 3]])
    (allSubsets 3 2)

assertEqual "3 choose 1"
    (set [set [1]; set [2]; set [3]])
    (allSubsets 3 1)

assertEqual "3 choose 3"
    (set [set [1; 2; 3]])
    (allSubsets 3 3)

assertEqual "3 choose 0"
    (set [Set.empty])
    (allSubsets 3 0)

assertEqual "4 choose 2"
    (set [set [1; 2]; set [1; 3]; set [1; 4]; set [2; 3]; set [2; 4]; set [3; 4]])
    (allSubsets 4 2)

assertEqual "0 choose 0"
    (set [Set.empty])
    (allSubsets 0 0)

assertEqual "2 choose 5" Set.empty (allSubsets 2 5)

#load "Task_13.fs"
open Task13

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- rmodd ---"
assertEqual "rmodd [1..5]" [2; 4] (rmodd [1; 2; 3; 4; 5])
assertEqual "rmodd even length" [2; 4] (rmodd [1; 2; 3; 4])
assertEqual "rmodd [1]" [] (rmodd [1])
assertEqual "rmodd []" [] (rmodd [])

printfn "--- del_even ---"
assertEqual "del_even [1..5]" [1; 3; 5] (del_even [1; 2; 3; 4; 5])
assertEqual "del_even all even" [] (del_even [2; 4; 6])
assertEqual "del_even []" [] (del_even [])

printfn "--- multiplicity ---"
assertEqual "multiplicity 2" 2 (multiplicity 2 [1; 2; 3; 2; 4])
assertEqual "multiplicity missing" 0 (multiplicity 5 [1; 2; 3])
assertEqual "multiplicity []" 0 (multiplicity 1 [])

printfn "--- split ---"
assertEqual "split [1..5]" ([1; 3; 5], [2; 4]) (split [1; 2; 3; 4; 5])
assertEqual "split [1..4]" ([1; 3], [2; 4]) (split [1; 2; 3; 4])
assertEqual "split [1]" ([1], []) (split [1])
assertEqual "split []" ([], []) (split [])

printfn "--- zip ---"
assertEqual "zip equal" [(1, 4); (2, 5); (3, 6)] (zip ([1; 2; 3], [4; 5; 6]))
assertEqual "zip empty" [] (zip ([], []))

try
    zip ([1; 2], [3]) |> ignore
    printfn "FAIL zip unequal: expected exception"
with _ ->
    printfn "OK   zip unequal throws"

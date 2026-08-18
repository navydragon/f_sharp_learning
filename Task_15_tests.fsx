#load "Task_15.fs"
open Task15

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- list_filter ---"
assertEqual "filter > 0" [2; 3] (list_filter (fun x -> x > 0) [-1; 2; 3])
assertEqual "filter even" [2; 4] (list_filter (fun x -> x % 2 = 0) [1; 2; 3; 4])
assertEqual "filter none" [] (list_filter (fun x -> x < 0) [1; 2; 3])
assertEqual "filter all" [1; 2; 3] (list_filter (fun _ -> true) [1; 2; 3])
assertEqual "filter []" [] (list_filter (fun x -> x > 0) [])

printfn "--- sum ---"
assertEqual "sum even" 6 (sum ((fun x -> x % 2 = 0), [1; 2; 3; 4]))
assertEqual "sum positive" 5 (sum ((fun x -> x > 0), [-1; 2; 3]))
assertEqual "sum all" 10 (sum ((fun _ -> true), [1; 2; 3; 4]))
assertEqual "sum none" 0 (sum ((fun _ -> false), [1; 2; 3; 4]))
assertEqual "sum []" 0 (sum ((fun x -> x > 0), []))

printfn "--- revrev ---"
assertEqual "revrev" [[5; 4; 3]; [2; 1]] (revrev [[1; 2]; [3; 4; 5]])
assertEqual "revrev one" [[3; 2; 1]] (revrev [[1; 2; 3]])
assertEqual "revrev []" [] (revrev [])
assertEqual "revrev empty inner" [[]; [2; 1]] (revrev [[1; 2]; []])
assertEqual "revrev three" [[6]; [5; 4]; [3; 2; 1]] (revrev [[1; 2; 3]; [4; 5]; [6]])

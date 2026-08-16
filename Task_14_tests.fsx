#load "Task_14.fs"
open Task14

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- sum ---"
assertEqual "sum even" 6 (sum ((fun x -> x % 2 = 0), [1; 2; 3; 4]))
assertEqual "sum all" 10 (sum ((fun _ -> true), [1; 2; 3; 4]))
assertEqual "sum none" 0 (sum ((fun _ -> false), [1; 2; 3; 4]))
assertEqual "sum []" 0 (sum ((fun x -> x > 0), []))

printfn "--- count ---"
assertEqual "count 2" 3 (count ([1; 2; 2; 2; 3], 2))
assertEqual "count missing" 0 (count ([1; 2; 3], 5))
assertEqual "count early stop" 0 (count ([1; 2; 3], 0))
assertEqual "count []" 0 (count ([], 1))

printfn "--- insert ---"
assertEqual "insert middle" [1; 2; 3; 4] (insert ([1; 2; 4], 3))
assertEqual "insert start" [0; 1; 2] (insert ([1; 2], 0))
assertEqual "insert end" [1; 2; 3] (insert ([1; 2], 3))
assertEqual "insert dup" [1; 2; 2; 3] (insert ([1; 2; 3], 2))
assertEqual "insert []" [5] (insert ([], 5))

printfn "--- intersect ---"
assertEqual "intersect dups" [2; 2; 4] (intersect ([1; 2; 2; 3; 4], [2; 2; 4; 4; 5]))
assertEqual "intersect empty" [] (intersect ([1; 2], [3; 4]))
assertEqual "intersect []" [] (intersect ([], [1; 2]))

printfn "--- plus ---"
assertEqual "plus merge" [1; 1; 2; 3; 4; 5] (plus ([1; 2; 4], [1; 3; 5]))
assertEqual "plus left empty" [1; 2] (plus ([], [1; 2]))
assertEqual "plus right empty" [1; 2] (plus ([1; 2], []))

printfn "--- minus ---"
assertEqual "minus dups" [1; 3] (minus ([1; 2; 2; 3], [2; 2; 4]))
assertEqual "minus partial" [1; 2] (minus ([1; 2; 2], [2]))
assertEqual "minus all" [] (minus ([1; 2], [1; 2; 3]))
assertEqual "minus []" [1; 2] (minus ([1; 2], []))

printfn "--- smallest ---"
assertEqual "smallest" (Some 1) (smallest [3; 1; 4; 2])
assertEqual "smallest one" (Some 7) (smallest [7])
assertEqual "smallest []" None (smallest [])

printfn "--- delete ---"
assertEqual "delete first" [1; 3; 2] (delete (2, [1; 2; 3; 2]))
assertEqual "delete missing" [1; 2; 3] (delete (5, [1; 2; 3]))
assertEqual "delete []" [] (delete (1, []))

printfn "--- sort ---"
assertEqual "sort" [1; 2; 3; 4] (sort [3; 1; 4; 2])
assertEqual "sort dups" [1; 1; 2; 3] (sort [3; 1; 1; 2])
assertEqual "sort []" [] (sort [])
assertEqual "sort already" [1; 2; 3] (sort [1; 2; 3])

printfn "--- revrev ---"
assertEqual "revrev" [[5; 4; 3]; [2; 1]] (revrev [[1; 2]; [3; 4; 5]])
assertEqual "revrev one" [[3; 2; 1]] (revrev [[1; 2; 3]])
assertEqual "revrev []" [] (revrev [])
assertEqual "revrev empty inner" [[]; [2; 1]] (revrev [[1; 2]; []])

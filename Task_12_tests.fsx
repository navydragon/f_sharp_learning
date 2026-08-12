#load "Task_12.fs"
open Task12

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- upto ---"
assertEqual "upto 5" [1; 2; 3; 4; 5] (upto 5)
assertEqual "upto 1" [1] (upto 1)
assertEqual "upto 0" [] (upto 0)

printfn "--- dnto ---"
assertEqual "dnto 5" [5; 4; 3; 2; 1] (dnto 5)
assertEqual "dnto 1" [1] (dnto 1)
assertEqual "dnto 0" [] (dnto 0)

printfn "--- evenn ---"
assertEqual "evenn 5" [0; 2; 4; 6; 8] (evenn 5)
assertEqual "evenn 1" [0] (evenn 1)
assertEqual "evenn 0" [] (evenn 0)

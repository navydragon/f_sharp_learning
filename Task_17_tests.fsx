#load "Task_17.fs"
open Task17

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

let map1 = Map.ofList [(128, "oksana"); (32, "oleg")]

printfn "--- try_find ---"
assertEqual "128" (Some "oksana") (try_find 128 map1)
assertEqual "32" (Some "oleg") (try_find 32 map1)
assertEqual "64 missing" None (try_find 64 map1)
assertEqual "256 added" (Some "olga") (try_find 256 (Map.add 256 "olga" map1))
assertEqual "32 removed" None (try_find 32 (Map.remove 32 map1))

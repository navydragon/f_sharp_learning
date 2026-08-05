#load "Task_7.fs"
open Task7

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

let assertFloat name expected actual =
    if abs (expected - actual) < 1e-9 then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- vat ---"
assertFloat "10% от 100" 110.0 (vat 10 100.0)
assertFloat "0% от 50"   50.0  (vat 0 50.0)
assertFloat "100% от 20" 40.0  (vat 100 20.0)
assertFloat "25% от 80"  100.0 (vat 25 80.0)
assertFloat "1% от 200"  202.0 (vat 1 200.0)

printfn "--- unvat ---"
assertFloat "unvat 10 110" 100.0 (unvat 10 110.0)
assertFloat "unvat 0 50"   50.0  (unvat 0 50.0)
assertFloat "unvat 100 40" 20.0  (unvat 100 40.0)
assertFloat "unvat 25 100" 80.0  (unvat 25 100.0)

printfn "--- unvat (vat n x) = x ---"
assertFloat "n=10, x=100" 100.0 (unvat 10 (vat 10 100.0))
assertFloat "n=0, x=42"   42.0  (unvat 0 (vat 0 42.0))
assertFloat "n=100, x=7"  7.0   (unvat 100 (vat 100 7.0))
assertFloat "n=33, x=3.5" 3.5   (unvat 33 (vat 33 3.5))

printfn "--- min ---"
assertEqual "n-5 = 0"        5 (min (fun n -> n - 5))
assertEqual "n*n - 16 = 0"   4 (min (fun n -> n * n - 16))
assertEqual "n - 1 = 0"      1 (min (fun n -> n - 1))
assertEqual "n % 7 при n=7"  7 (min (fun n -> n % 7))
assertEqual "(n-10)*(n-3)"   3 (min (fun n -> (n - 10) * (n - 3)))

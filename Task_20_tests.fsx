#load "Task_20.fs"
open Task49

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

let nth n sq = Seq.item n sq

printfn "--- even_seq ---"
assertEqual "even 0" 2 (nth 0 even_seq)
assertEqual "even 1" 4 (nth 1 even_seq)
assertEqual "even 2" 6 (nth 2 even_seq)
assertEqual "even 9" 20 (nth 9 even_seq)

printfn "--- fac_seq ---"
assertEqual "fac 0" 1 (nth 0 fac_seq)
assertEqual "fac 1" 1 (nth 1 fac_seq)
assertEqual "fac 2" 2 (nth 2 fac_seq)
assertEqual "fac 3" 6 (nth 3 fac_seq)
assertEqual "fac 4" 24 (nth 4 fac_seq)
assertEqual "fac 5" 120 (nth 5 fac_seq)
assertEqual "fac 6" 720 (nth 6 fac_seq)

printfn "--- seq_seq ---"
assertEqual "seq 0" 0 (nth 0 seq_seq)
assertEqual "seq 1" -1 (nth 1 seq_seq)
assertEqual "seq 2" 1 (nth 2 seq_seq)
assertEqual "seq 3" -2 (nth 3 seq_seq)
assertEqual "seq 4" 2 (nth 4 seq_seq)
assertEqual "seq 5" -3 (nth 5 seq_seq)
assertEqual "seq 6" 3 (nth 6 seq_seq)
assertEqual "seq 7" -4 (nth 7 seq_seq)

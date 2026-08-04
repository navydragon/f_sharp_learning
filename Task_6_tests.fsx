#load "Task_6.fs"
open Task6

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

printfn "--- pow ---"
assertEqual "abc x 3"  "abcabcabc" (pow ("abc", 3))
assertEqual "x x 1"    "x"         (pow ("x", 1))
assertEqual "hi x 0"   ""          (pow ("hi", 0))
assertEqual "ab x 2"   "abab"      (pow ("ab", 2))

printfn "--- isIthChar ---"
assertEqual "s.[2] = '3'" true  (isIthChar ("12345", 2, '3'))
assertEqual "s.[0] = '1'" true  (isIthChar ("12345", 0, '1'))
assertEqual "s.[1] != 'a'" false (isIthChar ("12345", 1, 'a'))
assertEqual "s.[4] = '5'" true  (isIthChar ("12345", 4, '5'))

printfn "--- occFromIth ---"
assertEqual "a с 0" 4 (occFromIth ("abacada", 0, 'a'))
assertEqual "a с 1" 3 (occFromIth ("abacada", 1, 'a'))
assertEqual "a с 3" 2 (occFromIth ("abacada", 3, 'a'))
assertEqual "a с 6" 1 (occFromIth ("abacada", 6, 'a'))
assertEqual "a с 7" 0 (occFromIth ("abacada", 7, 'a'))
assertEqual "x в abc" 0 (occFromIth ("abc", 0, 'x'))
assertEqual "b с 0" 1 (occFromIth ("abc", 0, 'b'))

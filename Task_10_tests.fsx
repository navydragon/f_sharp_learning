#load "Task_10.fs"
open Task10

let assertEqual name expected actual =
    if expected = actual then
        printfn "OK   %s" name
    else
        printfn "FAIL %s: expected %A, got %A" name expected actual

let am h m = { hours = h; minutes = m; f = "AM" }
let pm h m = { hours = h; minutes = m; f = "PM" }

printfn "--- .>. same period ---"
assertEqual "10:30 AM > 9:00 AM" true (am 10 30 .>. am 9 0)
assertEqual "9:00 AM > 10:30 AM" false (am 9 0 .>. am 10 30)
assertEqual "9:15 AM > 9:10 AM" true (am 9 15 .>. am 9 10)
assertEqual "9:10 AM > 9:10 AM" false (am 9 10 .>. am 9 10)

printfn "--- .>. AM vs PM ---"
assertEqual "12:00 PM > 11:59 AM" true (pm 0 0 .>. am 11 59)
assertEqual "11:59 AM > 12:00 PM" false (am 11 59 .>. pm 0 0)
assertEqual "1:00 PM > 10:00 AM" true (pm 1 0 .>. am 10 0)
assertEqual "12:00 AM > 11:59 PM" false (am 0 0 .>. pm 11 59)
assertEqual "11:59 PM > 12:00 AM" true (pm 11 59 .>. am 0 0)

printfn "--- .>. PM ---"
assertEqual "3:30 PM > 2:00 PM" true (pm 3 30 .>. pm 2 0)
assertEqual "2:45 PM > 2:30 PM" true (pm 2 45 .>. pm 2 30)
assertEqual "2:30 PM > 2:45 PM" false (pm 2 30 .>. pm 2 45)

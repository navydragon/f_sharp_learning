module Task6

// 17.1
let rec pow = function
| (_, 0) -> ""
| (s, n) -> s + pow (s, n - 1)

// 17.2
let isIthChar (s: string, n, c) = s.[n] = c

// 17.3
let rec occFromIth = function
| (s: string, n, _) when n >= String.length s -> 0
| (s, n, c) when s.[n] = c -> 1 + occFromIth (s, n + 1, c)
| (s, n, c) -> occFromIth (s, n + 1, c)

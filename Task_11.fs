module Task11

// 27.5 — 24.4 с размеченным объединением F
type F =
    | AM
    | PM

type TimeOfDay = { hours: int; minutes: int; f: F }

let toMinutes (t: TimeOfDay) =
    let baseMinutes = t.hours * 60 + t.minutes
    match t.f with
    | AM -> baseMinutes
    | PM -> 12 * 60 + baseMinutes

let (.>.) x y = toMinutes x > toMinutes y

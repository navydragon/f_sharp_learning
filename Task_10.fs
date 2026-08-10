module Task10

// 24.4
type TimeOfDay = { hours: int; minutes: int; f: string }

let toMinutes (t:TimeOfDay) =
    let baseMinutes = t.hours * 60 + t.minutes
    if t.f = "AM" then baseMinutes else 12 * 60 + baseMinutes

let (.>.) x y = toMinutes x > toMinutes y

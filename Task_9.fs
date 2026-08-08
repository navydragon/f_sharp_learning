module Task9

// 23.4.1
let private toCopper (g, s, c) = g * 240 + s * 12 + c

let private fromCopper total =
    if total <= 0 then (0, 0, 0)
    else
        let g = total / 240
        let rem = total % 240
        let s = rem / 12
        let c = rem % 12
        (g, s, c)

let (.+.) x y = fromCopper (toCopper x + toCopper y)
let (.-.) x y = fromCopper (toCopper x - toCopper y)

// 23.4.2
let (.+) (a: float, b: float) (c: float, d: float) = (a + c, b + d)

let (.*) (a: float, b: float) (c: float, d: float) = (a * c - b * d, b * c + a * d)

let (.-) x (c: float, d: float) = x .+ (-c, -d)

let (./) x (a: float, b: float) =
    let denom = a * a + b * b
    x .* (a / denom, -b / denom)

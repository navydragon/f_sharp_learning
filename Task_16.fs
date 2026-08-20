module Task16

// 42.3
let rec allSubsets n k =
    if k = 0 then set [Set.empty]
    elif k > n || k < 0 then Set.empty
    else
        let withoutN = allSubsets (n - 1) k
        let withN = Set.map (Set.add n) (allSubsets (n - 1) (k - 1))
        Set.union withoutN withN

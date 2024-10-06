open System.Diagnostics
let rec quickPow x y m acc =
    match (y % 2) with
    | 0 when y = 0 -> acc
    | 0 -> quickPow (x * x % m) (y / 2) m acc 
    | 1 -> quickPow (x * x % m) ((y - 1) / 2) m (acc * x % m)
    | _ -> raise (UnreachableException("something went wrong!"))

   let rec SumPos a = match a with
                      | [] -> 0
                      | x::rest when x > 0 -> x + SumPos rest
                      | x::rest -> SumPos rest 